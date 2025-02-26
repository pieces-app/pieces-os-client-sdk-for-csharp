using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

using Pieces.OS.Client;
using Pieces.Os.Core.SdkModel;

namespace Pieces.Extensions.AI;

public static class ServiceCollectionChatClientExtensions
{
    /// <summary>
    /// Add the ability to create a chat client from a host application builder
    /// </summary>
    /// <param name="hostBuilder">The host builder to call this on</param>
    /// <param name="builder">A builder function</param>
    /// <param name="modelId">The Id or name of the model to use</param>
    /// <param name="chatName">The name of the chat</param>
    /// <param name="piecesClient">The pieces client to use, or create one if this is null</pram>
    /// <returns></returns>
    public static IServiceCollection AddPiecesChatClient(
        this IHostApplicationBuilder hostBuilder,
        Func<ChatClientBuilder, ChatClientBuilder>? builder = null,
        string? model = null,
        string chatName = "",
        IPiecesClient? piecesClient = null)
    {
        return hostBuilder.Services.AddPiecesChatClient(
            model,
            chatName,
            piecesClient,
            builder);
    }

    /// <summary>
    /// Add the ability to create a chat client from a service collection
    /// </summary>
    /// <param name="services">The service collection to call this on</param>
    /// <param name="builder">A builder function</param>
    /// <param name="modelId">The Id or name of the model to use</param>
    /// <param name="chatName">The name of the chat</param>
    /// <param name="piecesClient">The pieces client to use, or create one if this is null</pram>
    /// <returns></returns>
    public static IServiceCollection AddPiecesChatClient(
        this IServiceCollection services,
        string? model = null,
        string chatName = "",
        IPiecesClient? piecesClient = null,
        Func<ChatClientBuilder, ChatClientBuilder>? builder = null)
    {
        var chatClientBuilder = services.AddChatClient(services =>
        {
            // Get the logger. If the logger is not created yet, create a Pieces logger using the logger factory if it exists
            var logger =
                services.GetService<ILogger>() ??
                services.GetService<ILoggerFactory>()?.CreateLogger("Pieces logger");

            // Create the Pieces client
            piecesClient ??= new PiecesClient(logger);

            Model? piecesModel = default;

            if (!string.IsNullOrWhiteSpace(model))
            {
                // Load the models. This is a sync function, and loading models is async, so do the bad thing and 
                // get the result to force this to be synchronous
                var models = piecesClient.GetModelsAsync().Result;

                // Find the first model that matches the Id
                // If there is no match, try based off the name instead
                piecesModel = models.FirstOrDefault(m => m.Id == model) ?? piecesClient.GetModelByNameAsync(model).Result;
            }

            return new PiecesChatClient(piecesClient, chatName, logger, piecesModel);
        });

        builder?.Invoke(chatClientBuilder);

        return services;
    }
}
