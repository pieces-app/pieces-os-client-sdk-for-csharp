namespace Pieces.OS.Client.Assets;

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.SdkModel;

public class PiecesAssets : IPiecesAssets
{
    private readonly ILogger? logger;
    private readonly Application application;
    private readonly AssetApi assetApi;
    private readonly AssetsApi assetsApi;

    internal PiecesAssets(ILogger? logger, Application application, AssetApi assetApi, AssetsApi assetsApi)
    {
        this.logger = logger;
        this.application = application;
        this.assetApi = assetApi;
        this.assetsApi = assetsApi;
    }

    /// <summary>
    /// Load all the assets contained in Pieces OS
    /// </summary>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>An IEnumerable of all the assets in Pieces OS</returns>
    public async IAsyncEnumerable<Asset> GetAllAssetsAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        logger?.LogInformation("Getting all assets");

        // Get the Ids of all assets
        var identifiers = await assetsApi.AssetsIdentifiersSnapshotAsync(cancellationToken: cancellationToken).ConfigureAwait(false);

        foreach (var identifier in identifiers.Iterable)
        {
            cancellationToken.ThrowIfCancellationRequested();

            logger?.LogDebug("Getting asset with identifier {id}", identifier.Id);

            // Load an individual asset
            var asset = await assetApi.AssetSnapshotAsync(Guid.Parse(identifier.Id), cancellationToken: cancellationToken);

            logger?.LogDebug("Added asset with identifier {id}", identifier.Id);

            yield return asset;
        }
    }

    /// <summary>
    /// Create a new asset in Pieces using the provided raw fragment and metadata
    /// </summary>
    /// <param name="rawFragment">The raw string representation of the asset</param>
    /// <param name="metadata">The metadata</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The newly created asset</returns>
    public async Task<Asset> CreateAssetAsync(string rawFragment, FragmentMetadata? metadata = default, CancellationToken cancellationToken = default)
    {
        var seededFragment = new SeededFragment(
            varString: new TransferableString(raw: rawFragment),
            metadata: metadata
        );

        var seededFormat = new SeededFormat(fragment: seededFragment);

        var seededAsset = new SeededAsset(
            application: application,
            format: seededFormat
        );

        var seed = new Seed(asset: seededAsset, type: Seed.TypeEnum.ASSET);

        return await assetsApi.AssetsCreateNewAssetAsync(seed: seed, cancellationToken: cancellationToken).ConfigureAwait(false);
    }
}