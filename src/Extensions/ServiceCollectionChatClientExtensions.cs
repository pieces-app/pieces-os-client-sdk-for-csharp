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
    /// <returns></returns>
    public static IServiceCollection AddPiecesChatClient(
        this IServiceCollection services,
        string? model = null,
        string chatName = "",
        IPiecesClient? piecesClient = null,
        Func<ChatClientBuilder, ChatClientBuilder>? builder = null)
    {
        return services.AddChatClient(pipeline =>
        {

            builder?.Invoke(pipeline);

            // Get the logger
            var logger = pipeline.Services.GetService<ILogger>();

            // If the logger is not created yet, create a Pieces logger using the logger factory if it exists
            if (logger is null)
            {
                var loggerFactory = pipeline.Services.GetService<ILoggerFactory>();
                logger = loggerFactory?.CreateLogger("Pieces logger");
            }

            // Create the Pieces client
            var client = piecesClient ?? new PiecesClient(logger);

            Model? piecesModel = default;

            if (!string.IsNullOrWhiteSpace(model))
            {
                // Load the models. This is a sync function, and loading models is async, so do the bad thing and 
                // get the result to force this to be synchronous
                var models = client.GetModelsAsync().Result;

                // Find the first model that matches the Id
                // If there is no match, try based off the name instead
                piecesModel = models.FirstOrDefault(m => m.Id == model) ?? client.GetModelFromName(model);
            }

            // Create the chat client in the pipeline
            return pipeline.Use(new PiecesChatClient(client, chatName, logger, piecesModel));
        });
    }
}
