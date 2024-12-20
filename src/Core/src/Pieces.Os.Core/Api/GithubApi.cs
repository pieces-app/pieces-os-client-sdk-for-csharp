/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.Client.Auth;
using Pieces.Os.Core.SdkModel;

namespace Pieces.Os.Core.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGithubApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// /github/gists/import [POST]
        /// </summary>
        /// <remarks>
        /// This will attempt to get all the gist availble and return them to the user as a DiscoveredAssets.  if automatic is true we will automatically create the asset.  v1. will just get all the users&#39; gists. implemented. v2. can get specific a public gist.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="automatic">For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional, default to true)</param>
        /// <param name="seededGithubGistsImport"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Seeds</returns>
        Seeds ImportGithubGists(bool? automatic = default(bool?), SeededGithubGistsImport seededGithubGistsImport = default(SeededGithubGistsImport), int operationIndex = 0);

        /// <summary>
        /// /github/gists/import [POST]
        /// </summary>
        /// <remarks>
        /// This will attempt to get all the gist availble and return them to the user as a DiscoveredAssets.  if automatic is true we will automatically create the asset.  v1. will just get all the users&#39; gists. implemented. v2. can get specific a public gist.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="automatic">For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional, default to true)</param>
        /// <param name="seededGithubGistsImport"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Seeds</returns>
        ApiResponse<Seeds> ImportGithubGistsWithHttpInfo(bool? automatic = default(bool?), SeededGithubGistsImport seededGithubGistsImport = default(SeededGithubGistsImport), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGithubApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// /github/gists/import [POST]
        /// </summary>
        /// <remarks>
        /// This will attempt to get all the gist availble and return them to the user as a DiscoveredAssets.  if automatic is true we will automatically create the asset.  v1. will just get all the users&#39; gists. implemented. v2. can get specific a public gist.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="automatic">For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional, default to true)</param>
        /// <param name="seededGithubGistsImport"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Seeds</returns>
        System.Threading.Tasks.Task<Seeds> ImportGithubGistsAsync(bool? automatic = default(bool?), SeededGithubGistsImport seededGithubGistsImport = default(SeededGithubGistsImport), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// /github/gists/import [POST]
        /// </summary>
        /// <remarks>
        /// This will attempt to get all the gist availble and return them to the user as a DiscoveredAssets.  if automatic is true we will automatically create the asset.  v1. will just get all the users&#39; gists. implemented. v2. can get specific a public gist.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="automatic">For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional, default to true)</param>
        /// <param name="seededGithubGistsImport"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Seeds)</returns>
        System.Threading.Tasks.Task<ApiResponse<Seeds>> ImportGithubGistsWithHttpInfoAsync(bool? automatic = default(bool?), SeededGithubGistsImport seededGithubGistsImport = default(SeededGithubGistsImport), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGithubApi : IGithubApiSync, IGithubApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GithubApi : IGithubApi
    {
        private Pieces.Os.Core.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GithubApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GithubApi(string basePath)
        {
            this.Configuration = Pieces.Os.Core.Client.Configuration.MergeConfigurations(
                Pieces.Os.Core.Client.GlobalConfiguration.Instance,
                new Pieces.Os.Core.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Pieces.Os.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GithubApi(Pieces.Os.Core.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Pieces.Os.Core.Client.Configuration.MergeConfigurations(
                Pieces.Os.Core.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Pieces.Os.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GithubApi(Pieces.Os.Core.Client.ISynchronousClient client, Pieces.Os.Core.Client.IAsynchronousClient asyncClient, Pieces.Os.Core.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Pieces.Os.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Pieces.Os.Core.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Pieces.Os.Core.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Pieces.Os.Core.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Pieces.Os.Core.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// /github/gists/import [POST] This will attempt to get all the gist availble and return them to the user as a DiscoveredAssets.  if automatic is true we will automatically create the asset.  v1. will just get all the users&#39; gists. implemented. v2. can get specific a public gist.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="automatic">For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional, default to true)</param>
        /// <param name="seededGithubGistsImport"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Seeds</returns>
        public Seeds ImportGithubGists(bool? automatic = default(bool?), SeededGithubGistsImport seededGithubGistsImport = default(SeededGithubGistsImport), int operationIndex = 0)
        {
            Pieces.Os.Core.Client.ApiResponse<Seeds> localVarResponse = ImportGithubGistsWithHttpInfo(automatic, seededGithubGistsImport);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /github/gists/import [POST] This will attempt to get all the gist availble and return them to the user as a DiscoveredAssets.  if automatic is true we will automatically create the asset.  v1. will just get all the users&#39; gists. implemented. v2. can get specific a public gist.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="automatic">For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional, default to true)</param>
        /// <param name="seededGithubGistsImport"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Seeds</returns>
        public Pieces.Os.Core.Client.ApiResponse<Seeds> ImportGithubGistsWithHttpInfo(bool? automatic = default(bool?), SeededGithubGistsImport seededGithubGistsImport = default(SeededGithubGistsImport), int operationIndex = 0)
        {
            Pieces.Os.Core.Client.RequestOptions localVarRequestOptions = new Pieces.Os.Core.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Pieces.Os.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Pieces.Os.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (automatic != null)
            {
                localVarRequestOptions.QueryParameters.Add(Pieces.Os.Core.Client.ClientUtils.ParameterToMultiMap("", "automatic", automatic));
            }
            localVarRequestOptions.Data = seededGithubGistsImport;

            localVarRequestOptions.Operation = "GithubApi.ImportGithubGists";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Application-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Application-ID", this.Configuration.GetApiKeyWithPrefix("X-Application-ID"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Seeds>("/github/gists/import", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ImportGithubGists", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /github/gists/import [POST] This will attempt to get all the gist availble and return them to the user as a DiscoveredAssets.  if automatic is true we will automatically create the asset.  v1. will just get all the users&#39; gists. implemented. v2. can get specific a public gist.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="automatic">For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional, default to true)</param>
        /// <param name="seededGithubGistsImport"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Seeds</returns>
        public async System.Threading.Tasks.Task<Seeds> ImportGithubGistsAsync(bool? automatic = default(bool?), SeededGithubGistsImport seededGithubGistsImport = default(SeededGithubGistsImport), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Pieces.Os.Core.Client.ApiResponse<Seeds> localVarResponse = await ImportGithubGistsWithHttpInfoAsync(automatic, seededGithubGistsImport, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /github/gists/import [POST] This will attempt to get all the gist availble and return them to the user as a DiscoveredAssets.  if automatic is true we will automatically create the asset.  v1. will just get all the users&#39; gists. implemented. v2. can get specific a public gist.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="automatic">For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional, default to true)</param>
        /// <param name="seededGithubGistsImport"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Seeds)</returns>
        public async System.Threading.Tasks.Task<Pieces.Os.Core.Client.ApiResponse<Seeds>> ImportGithubGistsWithHttpInfoAsync(bool? automatic = default(bool?), SeededGithubGistsImport seededGithubGistsImport = default(SeededGithubGistsImport), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Pieces.Os.Core.Client.RequestOptions localVarRequestOptions = new Pieces.Os.Core.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Pieces.Os.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Pieces.Os.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (automatic != null)
            {
                localVarRequestOptions.QueryParameters.Add(Pieces.Os.Core.Client.ClientUtils.ParameterToMultiMap("", "automatic", automatic));
            }
            localVarRequestOptions.Data = seededGithubGistsImport;

            localVarRequestOptions.Operation = "GithubApi.ImportGithubGists";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Application-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Application-ID", this.Configuration.GetApiKeyWithPrefix("X-Application-ID"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Seeds>("/github/gists/import", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ImportGithubGists", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
