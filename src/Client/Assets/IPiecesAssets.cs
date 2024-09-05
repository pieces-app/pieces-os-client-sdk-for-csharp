namespace Pieces.OS.Client.Assets;

using Pieces.Os.Core.SdkModel;

public interface IPiecesAssets
{
    /// <summary>
    /// Load all the assets contained in Pieces OS
    /// </summary>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>An IEnumerable of all the assets in Pieces OS</returns>
    IAsyncEnumerable<Asset> GetAllAssetsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new asset in Pieces using the provided raw fragment and metadata
    /// </summary>
    /// <param name="rawFragment">The raw string representation of the asset</param>
    /// <param name="metadata">The metadata</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The newly created asset</returns>
    Task<Asset> CreateAssetAsync(string rawFragment, FragmentMetadata? metadata = default, CancellationToken cancellationToken = default);
}