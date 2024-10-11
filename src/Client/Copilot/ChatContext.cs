namespace Pieces.OS.Client.Copilot;

/// <summary>
/// A record that holds the context for a conversation
/// </summary>
public record ChatContext
{
    /// <summary>
    /// Should this conversation use live context?
    /// </summary>
    public bool LiveContext { get; set; }

    /// <summary>
    /// If this conversation uses live context, what is the size of the context window time
    /// </summary>
    public TimeSpan? LiveContextTimeSpan { get; set; } = TimeSpan.FromMinutes(15);

    /// <summary>
    /// A list of asset Ids to use as context
    /// </summary>
    public IEnumerable<string>? AssetIds { get; set; } = null;
}