using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;
using System.Text;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Pieces.OS.Client.WebSocket;

internal class WebSocketBackgroundClient<T>(ILogger? logger = null) : IWebSocketBackgroundClient<T>
where T : IValidatableObject
{
    private ClientWebSocket? webSocket;
    private readonly ILogger? logger = logger;

    /// <summary>
    /// Initiates a WebSocket connection to the specified URL and starts the receive loop.
    /// </summary>
    /// <param name="url">The WebSocket server URL to connect to.</param>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task StartAsync(Uri url, CancellationToken cancellationToken = default)
    {
        // Initialize a new ClientWebSocket instance
        webSocket = new ClientWebSocket();

        try
        {
            // Attempt to connect to the WebSocket server
            await webSocket.ConnectAsync(url, cancellationToken).ConfigureAwait(false);
            logger?.LogInformation("Connected to WebSocket server");

            // Start the receive loop in the background
            // The underscore (_) discards the returned Task since we're not awaiting it
            _ = ReceiveLoopAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            // Log any connection errors
            logger?.LogError("Error connecting to WebSocket: {message}", ex.Message);
        }
    }

    /// <summary>
    /// Asynchronously receives messages from a WebSocket connection in a continuous loop.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    private async Task ReceiveLoopAsync(CancellationToken cancellationToken)
    {
        if (webSocket == null)
        {
            return;
        }

        // Buffer to store received data
        var buffer = new byte[1024 * 4];

        try
        {
            // Continue loop while the WebSocket is open and cancellation is not requested
            while (webSocket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
            {
                // Receive data from the WebSocket
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken).ConfigureAwait(false);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    // If a close message is received, close the WebSocket connection
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, cancellationToken).ConfigureAwait(false);
                    OnWebsocketClosedEvent();
                }
                else
                {
                    // Convert received data to a string
                    var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    logger?.LogDebug("Received: {message}", message);
                    
                    // Send the message to the event
                    var webSocketData = JsonConvert.DeserializeObject<T>(message);
                    OnWebsocketEvent(webSocketData);

                }
            }
        }
        catch (Exception ex)
        {
            // Log any errors that occur during the receive loop
            logger?.LogError("Error in receive loop: {message}", ex.Message);
            OnWebsocketClosedEvent();
        }
    }

    /// <summary>
    /// Stops the WebSocket connection and disposes of the WebSocket object.
    /// </summary>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation. Default is default(CancellationToken).</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task StopAsync(CancellationToken cancellationToken = default)
    {
        // If we haven't started the web socket then there's nothing to stop
        if (webSocket == null)
        {
            return;
        }

        // Check if the WebSocket connection is open
        if (webSocket.State == WebSocketState.Open)
        {
            // Close the WebSocket connection gracefully
            await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, cancellationToken).ConfigureAwait(false);
            OnWebsocketClosedEvent();
        }

        // Dispose of the WebSocket object to release resources
        webSocket.Dispose();
        webSocket = null;
    }

    /// <summary>
    /// Sends a message asynchronously through the WebSocket connection.
    /// </summary>
    /// <param name="message">The string message to be sent.</param>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation. Defaults to default(CancellationToken).</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public async Task SendMessageAsync(string message, CancellationToken cancellationToken = default)
    {
        if (webSocket == null)
        {
            logger?.LogError("Websocket has not been started - call StartAsync before sending messages");
            throw new WebSocketException("Websocket has not been started - call StartAsync before sending messages");
        }

        // Check if the WebSocket connection is open before sending the message
        if (webSocket.State == WebSocketState.Open)
        {
            // Convert the string message to a byte array using UTF-8 encoding
            var buffer = Encoding.UTF8.GetBytes(message);

            // Send the message asynchronously through the WebSocket
            // Use WebSocketMessageType.Text to indicate that the message is text-based
            // The 'true' parameter indicates that this is the final part of the message
            await webSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, cancellationToken).ConfigureAwait(false);
        }
        // Note: If the WebSocket is not open, the method will silently do nothing
    }

    /// <summary>
    /// An event that is fired every time the websocket has data available
    /// </summary>
    public event EventHandler<WebSocketDataEventArgs<T>>? WebsocketDataEvent;

    /// <summary>
    /// An event fired if the websocket is closed
    /// </summary>
    public event EventHandler? WebsocketClosedEvent;

    /// <summary>
    /// Raise the WebsocketDataEvent with the given message
    /// </summary>
    /// <param name="message">The message to pass to the event</param>
    private void OnWebsocketEvent(T? message) => WebsocketDataEvent?.Invoke(this, new WebSocketDataEventArgs<T>(message));

    /// <summary>
    /// Raise the WebsocketClosedEvent
    /// </summary>
    private void OnWebsocketClosedEvent() => WebsocketClosedEvent?.Invoke(this, EventArgs.Empty);
}
