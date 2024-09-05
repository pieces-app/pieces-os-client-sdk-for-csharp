namespace Pieces.OS.Client.Copilot;

using Pieces.Os.Core.SdkModel;

public interface ICopilotChat
{
    /// <summary>
    /// The conversation Id
    /// </summary>
    string Id { get; }

    /// <summary>
    /// The name of this conversation
    /// </summary>
    string Name { get; }

    /// <summary>
    /// The AI model to use for this chat
    /// </summary>
    Model Model { get; set; }

    /// <summary>
    /// The messages between the user and the copilot
    /// </summary>
    IEnumerable<Message> Messages { get; }

    /// <summary>
    /// An event that is fired every time the copilot stream has a new token available
    /// </summary>
    event EventHandler<TokenEventArgs>? TokenEvent;

    /// <summary>
    /// Ask the copilot a question and get the response as a stream
    /// 
    /// The response is streamed as an async enumerable that you can iterate through.
    /// In addition the <see cref="TokenEvent"/> is raised as each token is returned 
    /// 
    /// Both the question and the response are added to the <see cref="Messages"/> collection
    /// </summary>
    /// <param name="question">The question to ask</param>
    /// <param name="assetIds">The Ids of assets to add to this chat</param>
    /// <param name="liveContextTimeSpan">The time window for live context queries if this is created using live context</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The full response</returns>
    /// <exception cref="CopilotException">A <see cref="CopilotException"/> is raised if there is an error asking the question, such as losing connection to Pieces OS</exception>
    IAsyncEnumerable<string> AskStreamingQuestionAsync(string question, IEnumerable<string>? assetIds = default, TimeSpan? liveContextTimeSpan = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Ask the copilot a question and get the response as a string
    /// 
    /// This function gets the entire response and returns it as a string,
    /// In addition the <see cref="TokenEvent"/> is raised as each token is returned 
    /// 
    /// Both the question and the response are added to the <see cref="Messages"/> collection
    /// </summary>
    /// <param name="question">The question to ask</param>
    /// <param name="assetIds">The Ids of assets to add to this chat</param>
    /// <param name="liveContextTimeSpan">The time window for live context queries if this is created using live context</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The full response</returns>
    /// <exception cref="CopilotException">A <see cref="CopilotException"/> is raised if there is an error asking the question, such as losing connection to Pieces OS</exception>
    Task<string?> AskQuestionAsync(string question, IEnumerable<string>? assetIds = default, TimeSpan? liveContextTimeSpan = default, CancellationToken cancellationToken = default);
}