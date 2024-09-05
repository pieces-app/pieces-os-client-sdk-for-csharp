[Serializable]
public class PiecesClientException : Exception
{
    public PiecesClientException()
    {
    }

    public PiecesClientException(string? message) : base(message)
    {
    }

    public PiecesClientException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}