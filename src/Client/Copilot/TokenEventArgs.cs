namespace Pieces.OS.Client.Copilot;

public class TokenEventArgs(string? token) : EventArgs
{
    public string? Token { get; } = token;
}
