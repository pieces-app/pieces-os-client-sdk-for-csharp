namespace Pieces.OS.Client.Copilot;

using Pieces.Os.Core.SdkModel;
using Pieces.Os.Core.Api;
using Pieces.OS.Client.WebSocket;
using Microsoft.Extensions.Logging;

public class PiecesCopilot : IPiecesCopilot
{
    private readonly WebSocketBackgroundClient<QGPTStreamOutput> client;
    private readonly IConversationApi conversationApi;
    private readonly IConversationsApi conversationsApi;
    private readonly List<ICopilotChat> copilotChats = [];
    private readonly IRangesApi rangesApi;
    private readonly IQGPTApi qGPTApi;
    private readonly ILogger? logger;
    private readonly Application application;

    internal PiecesCopilot(ILogger? logger, 
                           Model model, 
                           Application application, 
                           WebSocketBackgroundClient<QGPTStreamOutput> client, 
                           IConversationApi conversationApi, 
                           IConversationsApi conversationsApi, 
                           IRangesApi rangesApi,
                           IQGPTApi qGPTApi)
    {
        this.logger = logger;
        Model = model;
        this.application = application;
        this.client = client;
        this.conversationApi = conversationApi;
        this.conversationsApi = conversationsApi;
        this.rangesApi = rangesApi;
        this.qGPTApi = qGPTApi;
    }

    /// <summary>
    /// Get all the chats with the current copilot
    /// </summary>
    public IEnumerable<ICopilotChat> Chats
    {
        get { return copilotChats; }
    }

    /// <summary>
    /// The AI model to use for all newly generated chats. Changing this will not affect existing chats
    /// </summary>
    public Model Model { get; set; }

    /// <summary>
    /// Create a new chat with the copilot
    /// </summary>
    /// <param name="chatName">An optional name for the chat. If nothing is provided, the name will be New conversation</param>
    /// <param name="chatContext">An optional list of asset Ids to add to the chat</param>
    /// <param name="model">The LLM model to use</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The new chat</returns>
    public async Task<ICopilotChat> CreateChatAsync(string chatName = "",
                                                    ChatContext? chatContext = null,
                                                    Model? model = default,
                                                    CancellationToken cancellationToken = default)
    {
        chatName = string.IsNullOrWhiteSpace(chatName) ? "New Conversation" : chatName;

        QGPTPromptPipeline? pipeline;

        if (chatContext?.LiveContext == true)
        {
            logger?.LogDebug("Creating copilot chat with live context");
            var dialog = new QGPTConversationPipelineForContextualizedCodeWorkstreamDialog();
            var conversationPipeline = new QGPTConversationPipeline(contextualizedCodeWorkstreamDialog: dialog);
            pipeline = new QGPTPromptPipeline(conversation: conversationPipeline);
        }
        else
        {
            logger?.LogDebug("Creating copilot chat without live context");
            var dialog = new QGPTConversationPipelineForGeneralizedCodeDialog();
            var conversationPipeline = new QGPTConversationPipeline(generalizedCodeDialog: dialog);
            pipeline = new QGPTPromptPipeline(conversation: conversationPipeline);
        }

        logger?.LogInformation("Creating conversation {name}...", chatName);

        var seededConversation = new SeededConversation(type: ConversationTypeEnum.COPILOT,
                                                        name: chatName,
                                                        pipeline: pipeline);
        var conversation = await conversationsApi.ConversationsCreateSpecificConversationAsync(
            seededConversation: seededConversation,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        logger?.LogInformation("Conversation {name} created", chatName);

        var chat = new CopilotChat(logger, model ?? Model, application, client, conversation, rangesApi, qGPTApi, conversationApi, chatContext);
        copilotChats.Add(chat);

        logger?.LogInformation("Copilot chat {name} created", chatName);

        return chat;
    }

    /// <summary>
    /// Deletes a copilot chat
    /// </summary>
    /// <param name="chat">The chat to delete</param>
    /// <returns></returns>
    public async Task DeleteChatAsync(ICopilotChat chat, CancellationToken cancellationToken = default)
    {
        await conversationsApi.ConversationsDeleteSpecificConversationAsync(conversation: chat.Id, cancellationToken: cancellationToken).ConfigureAwait(false);
        ((CopilotChat)chat).Deleted = true;
    }
}
