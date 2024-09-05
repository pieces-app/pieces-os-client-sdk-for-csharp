[Serializable]
internal class WebSocketException : Exception
{
    public WebSocketException()
    {
    }

    public WebSocketException(string? message) : base(message)
    {
    }

    public WebSocketException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}