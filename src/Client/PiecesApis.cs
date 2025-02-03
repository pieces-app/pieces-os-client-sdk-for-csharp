using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;

namespace Pieces.OS.Client;

public record PiecesApis
{
    public required ApiClient ApiClient { get; init; }

    public required IAnchorsApi AnchorsApi { get; init; }
    public required IAssetApi AssetApi { get; init; }
    public required IAssetsApi AssetsApi { get; init; }
    public required IConnectorApi ConnectorApi { get; init; }
    public required IConversationApi ConversationApi { get; init; }
    public required IConversationsApi ConversationsApi { get; init; }
    public required IModelApi ModelApi { get; init; }
    public required IModelsApi ModelsApi { get; init; }
    public required IQGPTApi QGPTApi { get; init; }
    public required IRangesApi RangesApi { get; init; }
    public required IWellKnownApi WellKnownApi { get; init; }
    public required IWorkstreamPatternEngineApi WorkstreamPatternEngineApi { get; init; }
}