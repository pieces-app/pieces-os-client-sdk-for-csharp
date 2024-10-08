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
}