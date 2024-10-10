using System.Runtime.CompilerServices;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Logging;
using Pieces.Os.Core.SdkModel;
using Pieces.OS.Client;
using Pieces.OS.Client.Copilot;

namespace Pieces.Extensions.AI;

public class PiecesChatClient(IPiecesClient piecesClient, string chatName = "", ILogger? logger = null, Model? model = null) : IChatClient
{
    private readonly IPiecesClient piecesClient = piecesClient;
    private readonly string chatName = chatName;
    private readonly ILogger? logger = logger;
    private Model? model = model;
    private IPiecesCopilot? piecesCopilot;

    // A cache of chats. These are keyed on a long string that is in the format "<Role><Message><Role><Message>..."
    // This is so we can take a set of chat messages and see if there is an existing conversation. If so, we can re-use this.
    // If not, we create a new conversation.
    // As new messages get added to the conversation, delete the old cache entry and create a new one.
    private readonly Dictionary<string, ICopilotChat> chatCache = [];

    /// <inheritdoc />
    public ChatClientMetadata Metadata => new("Pieces for Developers", new Uri("https://pieces.app"), (model?.Name) ?? "Unknown model");

    //
    // Summary:
    //     Sends chat messages to the model and returns the response messages.
    //
    // Parameters:
    //   chatMessages:
    //     The chat content to send.
    //
    //   options:
    //     The chat options to configure the request. To use Pieces specific features, set the following
    //     in the AdditionalProperties collection:
    //
    //     ["LiveContext"] = true/false; // set to true to use live context. Default to false.
    //     ["LiveContextTimeSpan"] = TimeSpan?; // The timespan to use for live context. Defaults to 15 minutes if not set.
    //     ["AssetIds"] = [];  // Set to an enumerable of asset ids to use saved assets in the chat. Default to none.
    //     ["PersistChat] = true/false; // By defaults these chats are persisted in Pieces. If this is set to false, 
    //       the chat is deleted after the response is returned
    //
    //   cancellationToken:
    //     The System.Threading.CancellationToken to monitor for cancellation requests.
    //     The default is System.Threading.CancellationToken.None.
    //
    // Returns:
    //     The response messages generated by the client.
    //
    // Remarks:
    //     The returned messages will not have been added to chatMessages. However, any
    //     intermediate messages generated implicitly by the client, including any messages
    //     for roundtrips to the model as part of the implementation of this request, will
    //     be included.
    //
    //     For every unique set of chat messages, a new Pieces conversation will be created,
    //     unless PersistChat is set to false. A conversation will be reused if
    //     it matches an existing conversation created by this chat client. Conversations created outside of this instance of the
    //     client will not be used.
    public async Task<ChatCompletion> CompleteAsync(IList<ChatMessage> chatMessages, ChatOptions? options = null, CancellationToken cancellationToken = default)
    {
        var chatWithCacheKey = await GetOrCreateChat(chatMessages, options, cancellationToken).ConfigureAwait(false);

        // Ask the question
        var response = await chatWithCacheKey.Chat.AskQuestionAsync(chatMessages.Last().Text!,
                                                                    liveContextTimeSpan: GetLiveContextTimeSpanFromOptions(options),
                                                                    cancellationToken: cancellationToken).ConfigureAwait(false);

        // Build the response
        var responseMessage = new ChatMessage(ChatRole.Assistant, response);

        // Cache or delete the chat depending on the options
        await CacheOrDeleteChat(chatMessages, options, chatWithCacheKey, responseMessage, cancellationToken).ConfigureAwait(false);

        // Build the response
        return new ChatCompletion([responseMessage])
        {
            ModelId = chatWithCacheKey.Chat.Model.Id,
            FinishReason = ChatFinishReason.Stop,
            CompletionId = chatWithCacheKey.Chat.Id,
            RawRepresentation = responseMessage.Text,
            CreatedAt = DateTime.UtcNow,
            Usage = new UsageDetails {
                AdditionalProperties = options?.AdditionalProperties is null ? null : new AdditionalPropertiesDictionary(options.AdditionalProperties)
            }
        };
    }

    //
    // Summary:
    //     Sends chat messages to the model and streams the response messages.
    //
    // Parameters:
    //   chatMessages:
    //     The chat content to send.
    //
    //   options:
    //     The chat options to configure the request. To use Pieces specific features, set the following
    //     in the AdditionalProperties collection:
    //
    //     ["LiveContext"] = true/false; // set to true to use live context. Default to false.
    //     ["LiveContextTimeSpan"] = TimeSpan?; // The timespan to use for live context. Defaults to 15 minutes if not set.
    //     ["AssetIds"] = [];  // Set to an enumerable of asset ids to use saved assets in the chat. Default to none.
    //     ["PersistChat] = true/false; // By defaults these chats are persisted in Pieces. If this is set to false, 
    //       the chat is deleted after the response is returned
    //
    //   cancellationToken:
    //     The System.Threading.CancellationToken to monitor for cancellation requests.
    //     The default is System.Threading.CancellationToken.None.
    //
    // Returns:
    //     The response messages generated by the client.
    //
    // Remarks:
    //     The returned messages will not have been added to chatMessages. However, any
    //     intermediate messages generated implicitly by the client, including any messages
    //     for roundtrips to the model as part of the implementation of this request, will
    //     be included.
    //
    //     For every unique set of chat messages, a new Pieces conversation will be created,
    //     unless PersistChat is set to false. A conversation will be reused if
    //     it matches an existing conversation created by this chat client. Conversations created outside of this instance of the
    //     client will not be used.
    public async IAsyncEnumerable<StreamingChatCompletionUpdate> CompleteStreamingAsync(IList<ChatMessage> chatMessages,
                                                                                        ChatOptions? options = null,
                                                                                        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        var chatWithCacheKey = await GetOrCreateChat(chatMessages, options, cancellationToken).ConfigureAwait(false);

        var responseText = "";

        // Ask the question
        await foreach (var r in chatWithCacheKey.Chat.AskStreamingQuestionAsync(chatMessages.Last().Text!,
                                                               liveContextTimeSpan: GetLiveContextTimeSpanFromOptions(options),
                                                               cancellationToken: cancellationToken))
        {
            var response = new StreamingChatCompletionUpdate()
            {
                Text = r,
                CompletionId = chatWithCacheKey.Chat.Id,
                Role = ChatRole.Assistant,
                FinishReason = null,
                CreatedAt = DateTime.UtcNow,
                RawRepresentation = r,
                AuthorName = "Pieces for Developers",
            };

            responseText += r;

            yield return response;
        }

        // Build the response
        var responseMessage = new ChatMessage(ChatRole.Assistant, responseText);

        // Cache or delete the chat depending on the options
        await CacheOrDeleteChat(chatMessages, options, chatWithCacheKey, responseMessage, cancellationToken).ConfigureAwait(false);

        yield return new StreamingChatCompletionUpdate()
        {
            Text = responseText,
            CompletionId = chatWithCacheKey.Chat.Id,
            Role = ChatRole.Assistant,
            FinishReason = ChatFinishReason.Stop,
            CreatedAt = DateTime.UtcNow,
            RawRepresentation = responseText,
            AuthorName = "Pieces for Developers",
        };
    }

    private async Task CacheOrDeleteChat(IList<ChatMessage> chatMessages,
                                         ChatOptions? options,
                                         ChatWithCacheKey chatWithCacheKey,
                                         ChatMessage responseMessage,
                                         CancellationToken cancellationToken)
    {
        // If we got this chat from the cache, remove the old entry as the messages will be updated to reflect this response
        chatCache.Remove(chatWithCacheKey.CacheKey);

        var persist = GetBoolValueFromOptions(options, "PersistChat", true);

        if (persist)
        {
            // Cache the chat
            var chatCacheKey = string.Join("", chatMessages.Append(responseMessage).Select(m => $"{m.Role}{m.Text}"));
            chatCache.Add(chatCacheKey, chatWithCacheKey.Chat);
        }
        else
        {
            // Delete the chat
            await piecesCopilot!.DeleteChatAsync(chatWithCacheKey.Chat, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }

    private record ChatWithCacheKey(string CacheKey, ICopilotChat Chat);

    private async Task<ChatWithCacheKey> GetOrCreateChat(IList<ChatMessage> chatMessages, ChatOptions? options, CancellationToken cancellationToken)
    {
        // Look up this chat in our cache
        var chatCacheKey = GetChatKey(chatMessages);
        if (chatCache.TryGetValue(chatCacheKey, out var chat))
        {
            logger?.LogInformation("Reusing conversation with Id {id}", chat?.Id);

            // Check the chat model - this can change between calls
            model = await GetModelFromChatOptionsAsync(options, cancellationToken).ConfigureAwait(false);
            if (model is not null && model.Id != chat!.Model.Id)
            {
                logger?.LogInformation("Updating conversation model to {model_name}", model.Name);
                chat!.Model = model;
            }
        }
        else
        {
            logger?.LogInformation("Creating a new conversation");

            // Build the seeds
            // Remove the last, as this is passed as the question
            var seeds = GetSeedsFromChatMessages(chatMessages);
            seeds.Remove(seeds.Last());

            // Create the chat if we don't have one from our cache
            // Ensure the copilot has been created
            piecesCopilot ??= await piecesClient.GetCopilotAsync().ConfigureAwait(false);

            // extract the relevant properties from the options
            model = await GetModelFromChatOptionsAsync(options, cancellationToken).ConfigureAwait(false);
            var assetIds = GetAssetIdsFromOptions(options);
            var liveContext = GetBoolValueFromOptions(options, "LiveContext");

            // Create a new chat using all the messages that have been sent
            chat = await piecesCopilot.CreateSeededChatAsync(chatName,
                                                             model: model,
                                                             seeds: seeds,
                                                             assetIds: assetIds,
                                                             useLiveContext: liveContext,
                                                             cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        return new(chatCacheKey, chat!);
    }

    private static string GetChatKey(IList<ChatMessage> chatMessages)
    {
        return string.Join("", chatMessages.Take(chatMessages.Count - 1).Select(m => $"{m.Role}{m.Text}"));
    }

    private static IEnumerable<string>? GetAssetIdsFromOptions(ChatOptions? options)
    {
        if (options is not null &&
            options.AdditionalProperties is not null &&
            options!.AdditionalProperties!.TryGetValue("AssetIds", out object? assetIdsVal))
        {
            return assetIdsVal as IEnumerable<string>;
        }

        return null;
    }

    private static bool GetBoolValueFromOptions(ChatOptions? options, string propertyName, bool defaultValue = false)
    {
        if (options is not null &&
            options.AdditionalProperties is not null &&
            options!.AdditionalProperties!.TryGetValue(propertyName, out object? boolVal))
        {
            return boolVal is bool v && v;
        }

        return defaultValue;
    }

    private static TimeSpan? GetLiveContextTimeSpanFromOptions(ChatOptions? options)
    {
        if (options is not null &&
            options.AdditionalProperties is not null &&
            options!.AdditionalProperties!.TryGetValue("LiveContextTimeSpan", out object? liveContextTimeSpanVal))
        {
            return liveContextTimeSpanVal as TimeSpan?;
        }

        return null;
    }

    private static List<SeedMessage> GetSeedsFromChatMessages(IList<ChatMessage> chatMessages)
    {
        // Validate the chat messages - we need at least one, and the last should be a user message
        if (!chatMessages.Any())
        {
            throw new ArgumentException("No chat messages provided", nameof(chatMessages));
        }

        // Check that the last message is from the user - if not we don't have a question to ask.
        if (!chatMessages.Last().Role.Equals(ChatRole.User))
        {
            throw new PiecesClientException($"The last messages is expected to be a user message as this is the question that will be asked. It is a {chatMessages.Last().Role} message.");
        }

        return chatMessages.Select(c =>
        {
            var role = c.Role switch
            {
                ChatRole when c.Role == ChatRole.System => QGPTConversationMessageRoleEnum.SYSTEM,
                ChatRole when c.Role == ChatRole.User => QGPTConversationMessageRoleEnum.USER,
                _ => QGPTConversationMessageRoleEnum.ASSISTANT,
            };
            return new SeedMessage(role, c.Text!);
        }).ToList();
    }

    private async Task<Model?> GetModelFromChatOptionsAsync(ChatOptions? options, CancellationToken cancellationToken)
    {
        // If we have a model ID, get that model
        // Otherwise use the last one set
        return (options?.ModelId) switch
        {
            not null => await piecesClient.DownloadModelAsync(options!.ModelId!, cancellationToken).ConfigureAwait(false),
            _ => model
        };
    }

    /// <inheritdoc />
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    /// <inheritdoc />
    public TService? GetService<TService>(object? key = null)
        where TService : class
        => key is null ? this as TService : null;
}