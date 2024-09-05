namespace Pieces.OS.Client.Copilot;

[Serializable]
internal class CopilotException : Exception
{
    public CopilotException()
    {
    }

    public CopilotException(string? message) : base(message)
    {
    }

    public CopilotException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}