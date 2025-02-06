namespace Pieces.OS.Client;

using Pieces.Os.Core.SdkModel;
using Pieces.OS.Client.Assets;
using Pieces.OS.Client.Copilot;

public interface IPiecesClient
{

    /// <summary>
    /// Get the list of models supported by this Pieces OS instance.
    /// </summary>
    /// <returns>An enumerable of the supported models</returns>
    Task<IEnumerable<Model>> GetModelsAsync();

    /// <summary>
    /// Downloads an offline model.
    /// 
    /// If the model is not offline, this just returns the model.
    /// If the model is an offline model, and is already downloaded, this just returns the model
    /// </summary>
    /// <param name="model">The model to download</param>
    /// <returns></returns>
    Task<Model> DownloadModelAsync(Model model, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes an offline model.
    /// 
    /// If the model is not offline, this does nothing
    /// If the model is an offline model, it is deleted
    /// </summary>
    /// <param name="model">The model to delete</param>
    Task DeleteModelAsync(Model model, CancellationToken cancellationToken = default);

    /// <summary>
    /// Downloads an offline model based off the name. Models are found using a case insensitive comparison
    /// finding the first model with a name that contains the given model name.
    /// 
    /// For example, if you use GPT-4o as the model name, it will match GPT-4o Mini Chat Model.
    /// 
    /// If the model is not found, a <see cref="PiecesException"/> is thrown.
    /// 
    /// If the model is not offline, this just returns the model.
    /// If the model is an offline model, and is already downloaded, this just returns the model
    /// </summary>
    /// <param name="modelName">The name model to download</param>
    /// <returns></returns>
    Task<Model> DownloadModelAsync(string modelName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the first model that contains the given name.
    /// If no model matches, the first is returned, unless <see cref="throwIfNotFound"/> 
    /// is set, then this throws a <see cref="PiecesClientException"/>.
    /// </summary>
    /// <param name="modelName">The search string for the model name</param>
    /// <param name="throwIfNotFound">If false and the model is not found, return the first model. Otherwise throw</param>
    /// <returns></returns>
    Task<Model> GetModelByNameAsync(string modelName, bool throwIfNotFound = false);

    /// <summary>
    /// Get the Pieces OS version
    /// </summary>
    /// <returns>The version as a string</returns>
    Task<string> GetVersionAsync(CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Get the Pieces Copilot
    /// </summary>
    /// <returns>The copilot</returns>
    Task<IPiecesCopilot> GetCopilotAsync();

    /// <summary>
    /// Get the Pieces Assets
    /// </summary>
    /// <returns>The assets</returns>
    Task<IPiecesAssets> GetAssetsAsync();

    /// <summary>
    /// Clears all the long-term memories from Pieces
    /// </summary>
    /// <param name="cancellationToken"></param>
    Task ClearLongTermMemoryAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears all the long-term memories from Pieces from now going back by the specified time span
    /// </summary>
    /// <param name="periodToClear">The period to clear going back from now</param>
    /// <param name="cancellationToken"></param>
    Task ClearLongTermMemoryAsync(TimeSpan periodToClear, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears all the long-term memories from Pieces for the given date and time range
    /// </summary>
    /// <param name="from">The start date and time to clear from</param>
    /// <param name="to">The end date and time to clear to</param>
    /// <param name="cancellationToken"></param>
    Task ClearLongTermMemoryAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deactivates long-term memory capture
    /// </summary>
    /// <param name="cancellationToken"></param>
    Task DeactivateLongTermMemoryCaptureAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Activates long-term memory capture
    /// </summary>
    /// <param name="cancellationToken"></param>
    Task ActivateLongTermMemoryCaptureAsync(CancellationToken cancellationToken = default);
}