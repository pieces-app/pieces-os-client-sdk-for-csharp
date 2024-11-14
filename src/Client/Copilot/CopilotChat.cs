namespace Pieces.OS.Client.Copilot;

using System.Runtime.CompilerServices;
using System.Text;

using Microsoft.Extensions.Logging;

using Pieces.Os.Core.SdkModel;
using Pieces.OS.Client.Util;
using Pieces.OS.Client.WebSocket;

public class CopilotChat : ICopilotChat
{
    private readonly List<Message> messages = [];
    private readonly ILogger? logger;
    private readonly Application application;
    private readonly IWebSocketBackgroundClient<QGPTStreamOutput> webSocketClient;
    private Conversation conversation;
    private readonly PiecesApis piecesApis;

    /// <summary>
    /// Has this chat been deleted? If true, then any calls to ask questions will fail.
    /// </summary>
    public bool Deleted { get; internal set; } = false;

    /// <summary>
    /// The context for this chat
    /// </summary>
    public ChatContext? ChatContext { get; set; }

    internal CopilotChat(ILogger? logger,
                         Model model,
                         Application application,
                         IWebSocketBackgroundClient<QGPTStreamOutput> webSocketClient,
                         Conversation conversation,
                         PiecesApis piecesApis,
                         ChatContext? chatContext,
                         IEnumerable<SeedMessage>? seeds = null)
    {
        this.logger = logger;
        this.application = application;
        this.webSocketClient = webSocketClient;
        this.conversation = conversation;
        this.piecesApis = piecesApis;

        if (seeds is not null)
        {
            messages.AddRange(seeds.Select(s => new Message(s.Role, s.Message)));
        }

        Model = model;
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

        ValidateChatContext();

        logger?.LogInformation("Streaming question {question} asked", question);

        // Save the question
        messages.Add(new Message(Role.User, question));

        // Get the question stream as JSON
        var questionStreamJson = await CreateQuestionInputJsonAsync(question, cancellationToken).ConfigureAwait(false);

        logger?.LogDebug("Question stream JSON:");
        logger?.LogDebug("{json}", questionStreamJson);

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

        void cancelEventHandler(object? sender, EventArgs e)
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

            // refresh the conversation
            logger?.LogInformation("Updating relevant assets and anchors on conversation...");

            // Update the assets associated with the conversation
            await UpdateConversationAssetsAsync(cancellationToken).ConfigureAwait(false);
            await UpdateConversationAnchorsAsync(cancellationToken).ConfigureAwait(false);

            conversation = await piecesApis.ConversationApi.ConversationGetSpecificConversationAsync(conversation.Id, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        finally
        {
            // Unsubscribe from the web socket events
            webSocketClient.WebsocketDataEvent -= dataEventHandler;
            webSocketClient.WebsocketClosedEvent -= cancelEventHandler;
        }
    }

    /// <summary>
    /// Validates that the chat context is valid. Throws a <see cref="AggregateException"/>  if the chat context is not valid, containing exceptions
    /// for all the issues
    /// </summary>
    /// <exception cref="AggregateException"></exception>
    private void ValidateChatContext()
    {
        if (ChatContext is null) return;

        var exceptions = new List<Exception>();

        // Check folders exist
        if (ChatContext?.Folders is not null)
        {
            foreach (var folder in ChatContext.Folders.Distinct())
            {
                if (!Path.Exists(folder))
                {
                    logger?.LogError("Folder {folder} does not exist", folder);
                    exceptions.Add(new PiecesClientException($"Folder {folder} does not exist"));
                }
            }
        }
        // Check files exist
        if (ChatContext?.Files is not null)
        {
            foreach (var file in ChatContext.Files.Distinct())
            {
                if (!Path.Exists(file))
                {
                    logger?.LogError("File {file} does not exist", file);
                    exceptions.Add(new PiecesClientException($"File {file} does not exist"));
                }
            }
        }

        if (exceptions.Count != 0)
        {
            throw new AggregateException(exceptions);
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

    private async Task<string> CreateQuestionInputJsonAsync(string question, CancellationToken cancellationToken)
    {
        logger?.LogInformation("Creating question input for question: {question}.", question);

        var temporalRangeGrounding = await CreateGroundingAsync(cancellationToken).ConfigureAwait(false);
        var assets = new FlattenedAssets(iterable: ChatContext?.AssetIds?.Select(assetId => new ReferencedAsset(id: assetId)).ToList());
        var paths = (ChatContext?.Files ?? []).Concat(ChatContext?.Folders ?? []).ToList();
        var relevantOptions = new QGPTRelevanceInputOptions(question: true, pipeline: conversation.Pipeline);

        // Build a relevance input
        var qGPTRelevanceInput = new QGPTRelevanceInput(query: question,
                                                        application: application.Id,
                                                        model: Model.Id,
                                                        temporal: temporalRangeGrounding,
                                                        assets: assets,
                                                        messages: conversation.Messages,
                                                        paths: paths.Count != 0 ? paths : null,
                                                        options: relevantOptions);

        // Build a stream input
        var questionStreamInput = new QGPTStreamInput(
            conversation: conversation.Id,
            relevance: qGPTRelevanceInput
        );

        // Return the input as JSON
        return questionStreamInput.ToJson();
    }

    private async Task UpdateConversationAnchorsAsync(CancellationToken cancellationToken)
    {
        if (conversation.Anchors?.Iterable is not null)
        {
            foreach (var anchor in conversation.Anchors.Iterable.ToList())
            {
                logger?.LogDebug("Removing anchor {anchor}", anchor.Id);
                await piecesApis.ConversationApi.ConversationDisassociateAnchorAsync(conversation.Id, anchor.Id, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        await AddAnchorsAsync(ChatContext?.Files, AnchorTypeEnum.FILE, cancellationToken).ConfigureAwait(false);
        await AddAnchorsAsync(ChatContext?.Folders, AnchorTypeEnum.DIRECTORY, cancellationToken).ConfigureAwait(false);
    }

    private async Task AddAnchorsAsync(IEnumerable<string>? paths, AnchorTypeEnum anchorType, CancellationToken cancellationToken)
    {
        if (paths is not null)
        {
            foreach (var path in paths)
            {
                logger?.LogDebug("Adding seeded anchor {file}", path);
                var seededAnchor = new SeededAnchor(fullpath: path, type: anchorType);
                var anchor = await piecesApis.AnchorsApi.AnchorsCreateNewAnchorAsync(seededAnchor: seededAnchor, cancellationToken: cancellationToken).ConfigureAwait(false);
                await piecesApis.ConversationApi.ConversationAssociateAnchorAsync(conversation.Id, anchor.Id, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }

    private async Task UpdateConversationAssetsAsync(CancellationToken cancellationToken)
    {
        if (conversation.Assets?.Iterable is not null)
        {
            foreach (var asset in conversation.Assets.Iterable.ToList())
            {
                logger?.LogDebug("Removing asset {id}", asset.Id);
                await piecesApis.ConversationApi.ConversationDisassociateAssetAsync(conversation.Id, Guid.Parse(asset.Id), cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        if (ChatContext?.AssetIds is not null)
        {
            foreach (var asset in ChatContext.AssetIds)
            {
                logger?.LogDebug("Adding asset {id}", asset);
                await piecesApis.ConversationApi.ConversationAssociateAssetAsync(conversation.Id, Guid.Parse(asset), cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }

    /// <summary>
    /// Create the temporal grounding. This is only relevant for Pieces Long-Term Memory, and creates a grounding based
    /// off the time span specified in the chat context, defaulting to 15 minutes if this is not set.
    /// 
    /// As part of this, the pipeline is checked. For Pieces Long-Term Memory, this pipeline should contain a
    /// <see cref="QGPTConversationPipelineForContextualizedCodeWorkstreamDialog"/>. If not using live
    /// context, it should contain a <see cref="QGPTConversationPipelineForGeneralizedCodeDialog"/>.
    /// 
    /// If the pipeline on the conversation doesn't match this (for example, the chat context has changed since
    /// the chat was created), then the pipeline is updated.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>The temporal range grounding used in the question</returns>
    private async Task<TemporalRangeGrounding?> CreateGroundingAsync(CancellationToken cancellationToken)
    {
        TemporalRangeGrounding? temporalRangeGrounding = default;

        if (ChatContext?.LongTermMemory == true)
        {
            var span = ChatContext?.LongTermMemoryTimeSpan ?? TimeSpan.FromMinutes(15);
            logger?.LogInformation("Using Pieces Long-Term Memory with a time span of: {span}.", span);
            // Create a temporal range from the provided time span ago to now minutes
            // If the provided time span is null, use 15 minutes ago
            var to = new GroupedTimestamp(value: DateTime.UtcNow);
            var from = new GroupedTimestamp(value: DateTime.UtcNow - span);
            var seededRange = new SeededRange(to: to, from: from);

            var range = await piecesApis.RangesApi.RangesCreateNewRangeAsync(seededRange: seededRange, cancellationToken: cancellationToken).ConfigureAwait(false);
            var referencedRange = new ReferencedRange(id: range.Id);
            var flattenedRanges = new FlattenedRanges(iterable: [referencedRange]);
            temporalRangeGrounding = new TemporalRangeGrounding(workstreams: flattenedRanges);

            // If the conversation wasn't set up for Pieces Long-Term Memory, set this up now
            if (conversation.Pipeline.Conversation.ContextualizedCodeWorkstreamDialog is null)
            {
                var dialog = new QGPTConversationPipelineForContextualizedCodeWorkstreamDialog();
                var conversationPipeline = new QGPTConversationPipeline(contextualizedCodeWorkstreamDialog: dialog);
                conversation.Pipeline = new QGPTPromptPipeline(conversation: conversationPipeline);
            }
        }
        else
        {
            logger?.LogInformation("Not using Pieces Long-Term Memory");

            // If the conversation was set up for Pieces Long-Term Memory, disable this if we are not using Pieces Long-Term Memory now
            if (conversation.Pipeline.Conversation.ContextualizedCodeWorkstreamDialog is null)
            {
                var dialog = new QGPTConversationPipelineForGeneralizedCodeDialog();
                var conversationPipeline = new QGPTConversationPipeline(generalizedCodeDialog: dialog);
                conversation.Pipeline = new QGPTPromptPipeline(conversation: conversationPipeline);
            }
        }

        return temporalRangeGrounding;
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
