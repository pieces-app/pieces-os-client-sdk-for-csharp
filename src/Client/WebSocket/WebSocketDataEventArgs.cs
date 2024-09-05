using System.ComponentModel.DataAnnotations;

namespace Pieces.OS.Client.WebSocket;

internal class WebSocketDataEventArgs<T>(T? data) : EventArgs
where T : IValidatableObject
    {
        public T? Data { get; } = data;
    }
