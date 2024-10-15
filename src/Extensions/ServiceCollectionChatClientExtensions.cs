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
    /// <param name="modelId">The Id of the model to use</param>
    /// <param name="chatName">The name of the chat</param>
    /// <returns></returns>
    public static IServiceCollection AddPiecesChatClient(
        this IHostApplicationBuilder hostBuilder,
        Func<ChatClientBuilder, ChatClientBuilder>? builder = null,
        string? modelId = null,
        string chatName = "")
    {
        return hostBuilder.Services.AddPiecesChatClient(
            modelId,
            chatName,
            builder);
    }

    /// <summary>
    /// Add the ability to create a chat client from a service collection
    /// </summary>
    /// <param name="services">The service collection to call this on</param>
    /// <param name="builder">A builder function</param>
    /// <param name="modelId">The Id of the model to use</param>
    /// <param name="chatName">The name of the chat</param>
    /// <returns></returns>
    public static IServiceCollection AddPiecesChatClient(
        this IServiceCollection services,
        string? modelId = null,
        string chatName = "",
        Func<ChatClientBuilder, ChatClientBuilder>? builder = null)
    {
        return services.AddChatClient(pipeline =>
        {
            builder?.Invoke(pipeline);
            var logger = pipeline.Services.GetService<ILogger>();

            // Create the Pieces client
            var client = new PiecesClient(logger);

            Model? model = default;

            if (!string.IsNullOrWhiteSpace(modelId))
            {
                // Load the models. This is a sync function, and loading models is async, so do the bad thing and 
                // get the result to force this to be synchronous
                var models = client.GetModelsAsync().Result;

                // Find the first model that matches the Id
                // If there is no match, try based off the name instead
                model = models.FirstOrDefault(m => m.Id == modelId) ?? client.GetModelFromName(modelId);
            }

            // Create the chat client in the pipeline
            return pipeline.Use(new PiecesChatClient(client, chatName, logger, model));
        });
    }
}
