namespace Pieces.OS.Client;

using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;

using Pieces.Os.Core.Client;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.SdkModel;
using Pieces.OS.Client.WebSocket;
using Pieces.OS.Client.Copilot;
using Pieces.OS.Client.Assets;

/// <summary>
/// A client wrapper to interact with Pieces OS
/// </summary>
public class PiecesClient : IPiecesClient, IDisposable
{
    private readonly ApiClient apiClient;
    private readonly AssetApi assetApi;
    private readonly AssetsApi assetsApi;
    private readonly ModelApi modelApi;
    private readonly ModelsApi modelsApi;
    private readonly WellKnownApi wellKnownApi;
    private readonly ConversationsApi conversationsApi;
    private readonly RangesApi rangesApi;
    private readonly ConnectorApi connectorApi;

    private Application? application;

    private readonly WebSocketBackgroundClient<QGPTStreamOutput> qgptWebSocket;
    private readonly Task webSocketTask;
    private readonly ILogger? logger;
    private IPiecesCopilot? copilot;
    private IPiecesAssets? assets;

    /// <summary>
    /// Creates a new instance of the Pieces OS client
    /// </summary>
    /// <param name="baseUrl">The URL of your Pieces OS instance. This only needs to be passed if you are not connecting to a local Pieces OS instance.</param>
    public PiecesClient(ILogger? logger = null, string? baseUrl = null, string applicationVersion = "0.0.1")
    {
        var os = PlatformEnum.UNKNOWN;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            os = PlatformEnum.LINUX;
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            os = PlatformEnum.WINDOWS;
        }
        else if (!RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
        {
            os = PlatformEnum.MACOS;
        }
        else
        {
            throw new PiecesClientException("OS not supported");
        }

        baseUrl ??= os == PlatformEnum.LINUX
                ? "http://localhost:5323"
                : "http://localhost:1000";

        var webSocketBaseUrl = baseUrl.ToLower().Replace("http://", "ws://").Replace("https://", "ws://");

        apiClient = new ApiClient(baseUrl);
        var configuration = new GlobalConfiguration(GlobalConfiguration.Instance.DefaultHeaders,
                                                    GlobalConfiguration.Instance.ApiKey,
                                                    GlobalConfiguration.Instance.ApiKeyPrefix,
                                                    baseUrl);

        assetApi = new AssetApi(apiClient, apiClient, configuration);
        assetsApi = new AssetsApi(apiClient, apiClient, configuration);
        modelApi = new ModelApi(apiClient, apiClient, configuration);
        modelsApi = new ModelsApi(apiClient, apiClient, configuration);
        wellKnownApi = new WellKnownApi(apiClient, apiClient, configuration);
        conversationsApi = new ConversationsApi(apiClient, apiClient, configuration);
        rangesApi = new RangesApi(apiClient, apiClient, configuration);
        connectorApi = new ConnectorApi(apiClient, apiClient, configuration);

        qgptWebSocket = new WebSocketBackgroundClient<QGPTStreamOutput>();
        var qgptUrlBuilder = new UriBuilder(webSocketBaseUrl)
        {
            Path = "qgpt/stream"
        };

        webSocketTask = Task.Run(async () =>
        {
            var connectTask = Task.Run(async () =>
            {
                logger?.LogInformation("Connecting to Pieces OS...");

                var application = new SeededTrackedApplication(
                    name: ApplicationNameEnum.OPENSOURCE,
                    platform: os,
                    varVersion: applicationVersion
                );
                var seededConnector = new SeededConnectorConnection(application: application);

                var connector = await connectorApi.ConnectAsync(seededConnectorConnection: seededConnector).ConfigureAwait(false);
                this.application = connector.Application;

                logger?.LogInformation("Connected as application {id}", this.application.Id);
            });

            logger?.LogInformation("Starting Pieces OS web sockets...");
            var qgptTask = qgptWebSocket.StartAsync(qgptUrlBuilder.Uri);

            await Task.WhenAll(qgptTask, connectTask).ConfigureAwait(false);

            logger?.LogInformation("Web sockets started");

            // Get all the models to pick a default - choose GPT-4o mini if it is available
            var models = modelsApi.ModelsSnapshot().Iterable;
            var defaultModel = models.FirstOrDefault(x => x.Name.Contains("GPT-4o")) ?? models.First();

            copilot = new PiecesCopilot(logger, defaultModel, application!, qgptWebSocket, conversationsApi, rangesApi);
            assets = new PiecesAssets(logger, application!, assetApi, assetsApi);
        });
        this.logger = logger;
    }

    private async Task EnsureConnected() => await webSocketTask.ConfigureAwait(false);

    /// <summary>
    /// Disposes of the WebSocket connection and releases associated resources.
    /// </summary>
    /// <remarks>
    /// This method is part of the IDisposable pattern implementation.
    /// It ensures that the WebSocket is properly closed and resources are released.
    /// </remarks>
    public void Dispose()
    {
        // Stop the WebSockets asynchronously and wait for completion
        qgptWebSocket.StopAsync().Wait();

        // Suppress finalization for this object, as we've manually disposed of resources
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Get the list of models supported by this Pieces OS instance.
    /// </summary>
    /// <returns>An enumerable of the supported models</returns>
    public async Task<IEnumerable<Model>> GetModelsAsync()
    {
        await EnsureConnected().ConfigureAwait(false);
        return modelsApi.ModelsSnapshot().Iterable;
    }

    /// <summary>
    /// Downloads an offline model.
    /// 
    /// If the model is not offline, this just returns the model.
    /// If the model is an offline model, and is already downloaded, this just returns the model
    /// </summary>
    /// <param name="model">The model to download</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns></returns>
    public async Task<Model> DownloadModelAsync(Model model, CancellationToken cancellationToken = default)
    {
        logger?.LogInformation("Downloading model with id: {id}", model.Id);

        if (model.Cloud)
        {
            logger?.LogInformation("Model with id: {id} is a cloud model, so no need to download", model.Id);
            return model;
        }

        if (model.Downloaded)
        {
            logger?.LogInformation("Model with id: {id} already downloaded", model.Id);
            return model;
        }

        var downloadedModel = await modelApi.ModelSpecificModelDownloadAsync(model.Id, cancellationToken: cancellationToken).ConfigureAwait(false);
        if (downloadedModel.Downloaded)
        {
            logger?.LogInformation("Model with id: {id} already downloaded", model.Id);
            return downloadedModel;
        }

        // Wait for downloading to begin
        while (!downloadedModel.Downloaded && !downloadedModel.Downloading)
        {
            logger?.LogDebug("Polling for downloading to begin for for  model with id: {id}", model.Id);

            cancellationToken.ThrowIfCancellationRequested();

            await Task.Delay(10, cancellationToken).ConfigureAwait(false);
            downloadedModel = await modelApi.ModelsSpecificModelSnapshotAsync(model.Id, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        // Wait for downloading to complete
        while (!downloadedModel.Downloaded && downloadedModel.Downloading)
        {
            logger?.LogDebug("Polling for download for  model with id: {id}", model.Id);

            cancellationToken.ThrowIfCancellationRequested();

            await Task.Delay(10, cancellationToken).ConfigureAwait(false);
            downloadedModel = await modelApi.ModelsSpecificModelSnapshotAsync(model.Id, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        // Now load the model
        var loadedModel = await modelApi.ModelSpecificModelLoadAsync(model.Id, cancellationToken: cancellationToken).ConfigureAwait(false);

        return loadedModel;
    }

    /// <summary>
    /// Get the Pieces OS version
    /// </summary>
    /// <returns>The version as a string</returns>
    public async Task<string> GetVersionAsync(CancellationToken cancellationToken = default)
    {
        await EnsureConnected().ConfigureAwait(false);
        return await wellKnownApi.GetWellKnownVersionAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Get the Pieces Copilot
    /// </summary>
    /// <returns>The copilot</returns>
    public async Task<IPiecesCopilot> GetCopilotAsync()
    {
        await EnsureConnected().ConfigureAwait(false);
        return copilot!;
    }

    /// <summary>
    /// Get the Pieces Assets
    /// </summary>
    /// <returns>The assets</returns>
    public async Task<IPiecesAssets> GetAssetsAsync()
    {
        await EnsureConnected().ConfigureAwait(false);
        return assets!;
    }
}
