namespace Pieces.OS.Client.Copilot;

using System.Runtime.CompilerServices;
using System.Text;

using Microsoft.Extensions.Logging;

using Pieces.Os.Core.Api;
using Pieces.Os.Core.SdkModel;
using Pieces.OS.Client.Util;
using Pieces.OS.Client.WebSocket;

public class CopilotChat : ICopilotChat
{
    private readonly List<Message> messages = [];
    private readonly ILogger? logger;
    private readonly Application application;
    private readonly IWebSocketBackgroundClient<QGPTStreamOutput> webSocketClient;
    private readonly Conversation conversation;
    private readonly IRangesApi rangesApi;

    /// <summary>
    /// Has this chat been deleted? If true, then any calls to ask questions will fail.
    /// </summary>
    public bool Deleted { get; internal set; } = false;

    /// <summary>
    /// The context for this chat
    /// </summary>
    public ChatContext? ChatContext { get; set; }

    internal CopilotChat(ILogger? logger, Model model, Application application, IWebSocketBackgroundClient<QGPTStreamOutput> webSocketClient, Conversation conversation, IRangesApi rangesApi, ChatContext? chatContext = null)
    {
        this.logger = logger;
        Model = model;
        this.application = application;
        this.webSocketClient = webSocketClient;
        this.conversation = conversation;
        this.rangesApi = rangesApi;
        ChatContext = chatContext;
    }

    /// <summary>
    /// The conversation Id
    /// </summary>
    public string Id => conversation.Id;

    /// <summary>
    /// The name of this conversation
    /// </summary>
    public string Name => conversation.Name;

    /// <summary>
    /// The AI model to use for this chat
    /// </summary>
    public Model Model { get; set; }

    /// <summary>
    /// The messages between the user and the copilot
    /// </summary>
    public IEnumerable<Message> Messages => messages;

    /// <summary>
    /// Ask the copilot a question and get the response as a stream
    /// 
    /// The response is streamed as an async enumerable that you can iterate through.
    /// In addition the <see cref="TokenEvent"/> is raised as each token is returned 
    /// 
    /// Both the question and the response are added to the <see cref="Messages"/> collection
    /// </summary>
    /// <param name="question">The question to ask</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The full response</returns>
    /// <exception cref="CopilotException">A <see cref="CopilotException"/> is raised if there is an error asking the question, such as losing connection to Pieces OS</exception>
    public async IAsyncEnumerable<string> AskStreamingQuestionAsync(string question, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (Deleted)
        {
            logger?.LogError("Cannot ask streaming question, this conversation has been deleted");
            throw new PiecesClientException("Cannot ask streaming question, this conversation has been deleted");
        }

        logger?.LogInformation("Streaming question {question} asked", question);

        // Save the question
        messages.Add(new Message(Role.User, question));

        // Get the question stream as JSON
        var questionStreamJson = await CreateQuestionInputJson(question, cancellationToken).ConfigureAwait(false);

        // Build a waiter to wait for events
        var eventWaiter = new EventWaiter<EventArgs>(cancellationToken);
        var tokenEventWaiter = new EventWaiter<TokenEventArgs>(cancellationToken);

        var resultStringBuilder = new StringBuilder();

        // When we have data we need to :
        // - Send an event to publish the token
        // - Store the token so we can return a whole answer
        // - Check the status and if it is the end of the stream then toggle the event waiter
        void dataEventHandler(object? sender, WebSocketDataEventArgs<QGPTStreamOutput> e)
        {
            logger?.LogDebug("Received event from web socket with data {data}", e.Data);

            if (e.Data == null)
            {
                logger?.LogError("Received empty data from web socket");

                tokenEventWaiter.EventRaised(sender, new TokenEventArgs(null));
                eventWaiter.EventRaisedWithError(sender, e);
            }
            else
            {
                var token = e.Data.Question?.Answers?.Iterable?.FirstOrDefault()?.Text;
                if (token != null)
                {
                    resultStringBuilder.Append(token);
                    OnTokenEvent(token);
                }

                tokenEventWaiter.EventRaised(sender, new TokenEventArgs(token));

                switch (e.Data.Status)
                {
                    case QGPTStreamEnum.INPROGRESS:
                        break;
                    case QGPTStreamEnum.COMPLETED:
                        eventWaiter.EventRaised(sender, e);
                        break;
                    default:
                        logger?.LogError("Received error status from Pieces OS: {status}", e.Data.Status);
                        eventWaiter.EventRaisedWithError(sender, e);
                        break;
                }
            }
        }

        void cancelEventHandler(Object? sender, EventArgs e)
        {
            tokenEventWaiter.EventRaised(sender, new TokenEventArgs(null));
            eventWaiter.EventRaisedWithError(sender, e);
        };

        webSocketClient.WebsocketDataEvent += dataEventHandler;
        webSocketClient.WebsocketClosedEvent += cancelEventHandler;

        // Send the message to the websocket
        logger?.LogInformation("Sending message to the web socket...");
        await webSocketClient.SendMessageAsync(questionStreamJson, cancellationToken).ConfigureAwait(false);
        logger?.LogInformation("Message sent to the web socket.");

        try
        {
            // Wait for the event waiter
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var tokenArgs = await tokenEventWaiter.WaitForEventAsync().ConfigureAwait(false);

                if (tokenArgs.Token == null)
                {
                    var eventData = await eventWaiter.WaitForEventAsync().ConfigureAwait(false) as WebSocketDataEventArgs<QGPTStreamOutput>;

                    if (eventWaiter.IsError)
                    {
                        logger?.LogError("Error getting chat from the copilot");
                        throw new CopilotException($"Error getting chat from the copilot - {eventData?.Data?.ErrorMessage}");
                    }

                    break;
                }
                else
                {
                    tokenEventWaiter.Reset();
                    logger?.LogDebug("Returning token: {token}", tokenArgs.Token);
                    yield return tokenArgs.Token;
                }
            }

            // Save the response
            messages.Add(new Message(Role.Assistant, resultStringBuilder.ToString()));
        }
        finally
        {
            // Unsubscribe from the web socket events
            webSocketClient.WebsocketDataEvent -= dataEventHandler;
            webSocketClient.WebsocketClosedEvent -= cancelEventHandler;
        }
    }

    /// <summary>
    /// Ask the copilot a question and get the response as a string
    /// 
    /// This function gets the entire response and returns it as a string,
    /// In addition the <see cref="TokenEvent"/> is raised as each token is returned.
    /// 
    /// Both the question and the response are added to the <see cref="Messages"/> collection
    /// </summary>
    /// <param name="question">The question to ask</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The full response</returns>
    /// <exception cref="CopilotException">A <see cref="CopilotException"/> is raised if there is an error asking the question, such as losing connection to Pieces OS</exception>
    public async Task<string?> AskQuestionAsync(string question, CancellationToken cancellationToken = default)
    {
        if (Deleted)
        {
            logger?.LogError("Cannot ask question, this conversation has been deleted");
            throw new PiecesClientException("Cannot ask question, this conversation has been deleted");
        }

        logger?.LogInformation("Question {question} asked", question);

        // Reuse the streaming function, and let it run
        await foreach (var _ in AskStreamingQuestionAsync(question, cancellationToken)) ;

        // Return the response from the messages collection
        return messages.LastOrDefault()?.Content;
    }

    private async Task<string> CreateQuestionInputJson(string question, CancellationToken cancellationToken)
    {
        logger?.LogInformation("Creating question input for question: {question}.", question);
        TemporalRangeGrounding? temporalRangeGrounding = default;

        if (ChatContext?.LiveContext == true)
        {
            var span = ChatContext?.LiveContextTimeSpan ?? TimeSpan.FromMinutes(15);
            logger?.LogInformation("Using live context with a time span of: {span}.", span);
            // Create a temporal range from the provided time span ago to now minutes
            // If the provided time span is null, use 15 minutes ago
            var to = new GroupedTimestamp(value: DateTime.UtcNow);
            var from = new GroupedTimestamp(value: DateTime.UtcNow - span);
            var seededRange = new SeededRange(to: to, from: from);

            var range = await rangesApi.RangesCreateNewRangeAsync(seededRange: seededRange, cancellationToken: cancellationToken).ConfigureAwait(false);
            var referencedRange = new ReferencedRange(id: range.Id);
            var flattenedRanges = new FlattenedRanges(iterable: [referencedRange]);
            temporalRangeGrounding = new TemporalRangeGrounding(workstreams: flattenedRanges);

            // If the conversation wasn't set up for live context, set this up now
            if (conversation.Pipeline.Conversation.ContextualizedCodeWorkstreamDialog is null)
            {
                var dialog = new QGPTConversationPipelineForContextualizedCodeWorkstreamDialog();
                var conversationPipeline = new QGPTConversationPipeline(contextualizedCodeWorkstreamDialog: dialog);
                conversation.Pipeline = new QGPTPromptPipeline(conversation: conversationPipeline);
            }
        }
        else
        {
            logger?.LogInformation("Not using live context");

            // If the conversation was set up for live context, disable this if we are not using live context now
            if (conversation.Pipeline.Conversation.ContextualizedCodeWorkstreamDialog is null)
            {
                var dialog = new QGPTConversationPipelineForGeneralizedCodeDialog();
                var conversationPipeline = new QGPTConversationPipeline(generalizedCodeDialog: dialog);
                conversation.Pipeline = new QGPTPromptPipeline(conversation: conversationPipeline);
            }
        }

        // Get all relevant assets passed in to this chat
        var relevantQgptSeeds = new List<RelevantQGPTSeed>();

        if (ChatContext?.AssetIds is not null)
        {
            logger?.LogInformation("Adding assets to question input");
            var referencedAssets = ChatContext.AssetIds.Select(assetId => new ReferencedAsset(id: assetId)).ToList();
            var flattenedAssets = new FlattenedAssets(iterable: referencedAssets);

            foreach (var flattenedAsset in flattenedAssets.Iterable)
            {
                if (!relevantQgptSeeds.Any(s => s.Asset.Id == flattenedAsset.Id))
                {
                    logger?.LogDebug("Adding asset id: {id}", flattenedAsset.Id);
                    relevantQgptSeeds.Add(new RelevantQGPTSeed(asset: flattenedAsset));
                }
            }
        }

        // Add all the assets from the conversation
        var conversationAssets = conversation.Assets?.Iterable;
        if (conversationAssets is not null)
        {
            logger?.LogInformation("Adding conversation assets to question input");
            var referencedAssets = conversationAssets.Select(asset => new ReferencedAsset(id: asset.Id)).ToList();
            var flattenedAssets = new FlattenedAssets(iterable: referencedAssets);

            foreach (var flattenedAsset in flattenedAssets.Iterable)
            {
                if (!relevantQgptSeeds.Any(s => s.Asset.Id == flattenedAsset.Id))
                {
                    logger?.LogDebug("Adding asset id: {id}", flattenedAsset.Id);
                    relevantQgptSeeds.Add(new RelevantQGPTSeed(asset: flattenedAsset));
                }
            }
        }

        // Build the question input
        var questionInput = new QGPTQuestionInput(
            query: question,
            pipeline: conversation.Pipeline,
            relevant: new RelevantQGPTSeeds(iterable: relevantQgptSeeds),
            application: application.Id,
            temporal: temporalRangeGrounding,
            model: Model.Id
        );

        // Build a stream input
        var questionStreamInput = new QGPTStreamInput(
            conversation: conversation.Id,
            question: questionInput
        );

        // Return the input as JSON
        return questionStreamInput.ToJson();
    }

    /// <summary>
    /// An event that is fired every time the copilot stream has a new token available
    /// </summary>
    public event EventHandler<TokenEventArgs>? TokenEvent;

    /// <summary>
    /// Raise the TokenEvent with the given token
    /// </summary>
    /// <param name="token">The token to pass to the event</param>
    private void OnTokenEvent(string token)
    {
        logger?.LogDebug("Raising token event with token: {token}", token);
        TokenEvent?.Invoke(this, new TokenEventArgs(token));
    }
}
