namespace Pieces.OS.Client.WebSocket;

using System.ComponentModel.DataAnnotations;

internal interface IWebSocketBackgroundClient<T> where T: IValidatableObject
{
    /// <summary>
    /// Initiates a WebSocket connection to the specified URL and starts the receive loop.
    /// </summary>
    /// <param name="url">The WebSocket server URL to connect to.</param>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task StartAsync(Uri url, CancellationToken cancellationToken = default);

    /// <summary>
    /// Stops the WebSocket connection and disposes of the WebSocket object.
    /// </summary>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation. Default is default(CancellationToken).</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task StopAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Sends a message asynchronously through the WebSocket connection.
    /// </summary>
    /// <param name="message">The string message to be sent.</param>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation. Defaults to default(CancellationToken).</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    Task SendMessageAsync(string message, CancellationToken cancellationToken = default);

    /// <summary>
    /// An event that is fired every time the websocket has data available
    /// </summary>
    event EventHandler<WebSocketDataEventArgs<T>>? WebsocketDataEvent;

    /// <summary>
    /// An event fired if the websocket is closed
    /// </summary>
    event EventHandler? WebsocketClosedEvent;
}