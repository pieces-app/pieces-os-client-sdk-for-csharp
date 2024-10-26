namespace Pieces.OS.Client.Copilot;

/// <summary>
/// A record that holds the context for a conversation
/// </summary>
public record ChatContext
{
    /// <summary>
    /// Should this conversation use Pieces Long-Term Memory?
    /// </summary>
    public bool LongTermMemory { get; set; }

    /// <summary>
    /// If this conversation uses Pieces Long-Term Memory, what is the size of the context window time
    /// </summary>
    public TimeSpan? LongTermMemoryTimeSpan { get; set; } = TimeSpan.FromMinutes(15);

    /// <summary>
    /// A list of asset Ids to use as context
    /// </summary>
    public IEnumerable<string>? AssetIds { get; set; } = null;

    /// <summary>
    /// The paths for files to add to the copilot chat
    /// </summary>
    public IEnumerable<string>? Files { get; set; } = null;

    /// <summary>folders
    /// The paths for files to add to the copilot chat
    /// </summary>
    public IEnumerable<string>? Folders { get; set; } = null;
}