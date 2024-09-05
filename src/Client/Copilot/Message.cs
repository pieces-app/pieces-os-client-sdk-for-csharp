namespace Pieces.OS.Client.Copilot;

public record Message
{
    internal Message(Role role, string content)
    {
        Role = role;
        Content = content;
    }

    public Role Role { get; init; }
    public string Content { get; init; }
}
