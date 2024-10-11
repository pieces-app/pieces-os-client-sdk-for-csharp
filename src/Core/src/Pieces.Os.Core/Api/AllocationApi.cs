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
    public interface IAllocationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// /allocation/{allocation} [GET]
        /// </summary>
        /// <remarks>
        /// This will get a snapshot of a specific allocation.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocation"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AllocationCloud</returns>
        AllocationCloud AllocationSnapshot(string allocation, int operationIndex = 0);

        /// <summary>
        /// /allocation/{allocation} [GET]
        /// </summary>
        /// <remarks>
        /// This will get a snapshot of a specific allocation.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocation"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AllocationCloud</returns>
        ApiResponse<AllocationCloud> AllocationSnapshotWithHttpInfo(string allocation, int operationIndex = 0);
        /// <summary>
        /// /allocation/update [POST]
        /// </summary>
        /// <remarks>
        /// This will update a specific allocation.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocationCloud"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AllocationCloud</returns>
        AllocationCloud AllocationUpdate(AllocationCloud allocationCloud = default(AllocationCloud), int operationIndex = 0);

        /// <summary>
        /// /allocation/update [POST]
        /// </summary>
        /// <remarks>
        /// This will update a specific allocation.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocationCloud"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AllocationCloud</returns>
        ApiResponse<AllocationCloud> AllocationUpdateWithHttpInfo(AllocationCloud allocationCloud = default(AllocationCloud), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAllocationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// /allocation/{allocation} [GET]
        /// </summary>
        /// <remarks>
        /// This will get a snapshot of a specific allocation.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocation"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AllocationCloud</returns>
        System.Threading.Tasks.Task<AllocationCloud> AllocationSnapshotAsync(string allocation, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// /allocation/{allocation} [GET]
        /// </summary>
        /// <remarks>
        /// This will get a snapshot of a specific allocation.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocation"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AllocationCloud)</returns>
        System.Threading.Tasks.Task<ApiResponse<AllocationCloud>> AllocationSnapshotWithHttpInfoAsync(string allocation, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// /allocation/update [POST]
        /// </summary>
        /// <remarks>
        /// This will update a specific allocation.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocationCloud"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AllocationCloud</returns>
        System.Threading.Tasks.Task<AllocationCloud> AllocationUpdateAsync(AllocationCloud allocationCloud = default(AllocationCloud), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// /allocation/update [POST]
        /// </summary>
        /// <remarks>
        /// This will update a specific allocation.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocationCloud"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AllocationCloud)</returns>
        System.Threading.Tasks.Task<ApiResponse<AllocationCloud>> AllocationUpdateWithHttpInfoAsync(AllocationCloud allocationCloud = default(AllocationCloud), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAllocationApi : IAllocationApiSync, IAllocationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AllocationApi : IAllocationApi
    {
        private Pieces.Os.Core.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AllocationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AllocationApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AllocationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AllocationApi(Pieces.Os.Core.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AllocationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AllocationApi(Pieces.Os.Core.Client.ISynchronousClient client, Pieces.Os.Core.Client.IAsynchronousClient asyncClient, Pieces.Os.Core.Client.IReadableConfiguration configuration)
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
        /// /allocation/{allocation} [GET] This will get a snapshot of a specific allocation.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocation"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AllocationCloud</returns>
        public AllocationCloud AllocationSnapshot(string allocation, int operationIndex = 0)
        {
            Pieces.Os.Core.Client.ApiResponse<AllocationCloud> localVarResponse = AllocationSnapshotWithHttpInfo(allocation);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /allocation/{allocation} [GET] This will get a snapshot of a specific allocation.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocation"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AllocationCloud</returns>
        public Pieces.Os.Core.Client.ApiResponse<AllocationCloud> AllocationSnapshotWithHttpInfo(string allocation, int operationIndex = 0)
        {
            // verify the required parameter 'allocation' is set
            if (allocation == null)
            {
                throw new Pieces.Os.Core.Client.ApiException(400, "Missing required parameter 'allocation' when calling AllocationApi->AllocationSnapshot");
            }

            Pieces.Os.Core.Client.RequestOptions localVarRequestOptions = new Pieces.Os.Core.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("allocation", Pieces.Os.Core.Client.ClientUtils.ParameterToString(allocation)); // path parameter

            localVarRequestOptions.Operation = "AllocationApi.AllocationSnapshot";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Application-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Application-ID", this.Configuration.GetApiKeyWithPrefix("X-Application-ID"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AllocationCloud>("/allocation/{allocation}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AllocationSnapshot", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /allocation/{allocation} [GET] This will get a snapshot of a specific allocation.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocation"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AllocationCloud</returns>
        public async System.Threading.Tasks.Task<AllocationCloud> AllocationSnapshotAsync(string allocation, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Pieces.Os.Core.Client.ApiResponse<AllocationCloud> localVarResponse = await AllocationSnapshotWithHttpInfoAsync(allocation, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /allocation/{allocation} [GET] This will get a snapshot of a specific allocation.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocation"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AllocationCloud)</returns>
        public async System.Threading.Tasks.Task<Pieces.Os.Core.Client.ApiResponse<AllocationCloud>> AllocationSnapshotWithHttpInfoAsync(string allocation, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'allocation' is set
            if (allocation == null)
            {
                throw new Pieces.Os.Core.Client.ApiException(400, "Missing required parameter 'allocation' when calling AllocationApi->AllocationSnapshot");
            }


            Pieces.Os.Core.Client.RequestOptions localVarRequestOptions = new Pieces.Os.Core.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("allocation", Pieces.Os.Core.Client.ClientUtils.ParameterToString(allocation)); // path parameter

            localVarRequestOptions.Operation = "AllocationApi.AllocationSnapshot";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Application-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Application-ID", this.Configuration.GetApiKeyWithPrefix("X-Application-ID"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AllocationCloud>("/allocation/{allocation}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AllocationSnapshot", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /allocation/update [POST] This will update a specific allocation.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocationCloud"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AllocationCloud</returns>
        public AllocationCloud AllocationUpdate(AllocationCloud allocationCloud = default(AllocationCloud), int operationIndex = 0)
        {
            Pieces.Os.Core.Client.ApiResponse<AllocationCloud> localVarResponse = AllocationUpdateWithHttpInfo(allocationCloud);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /allocation/update [POST] This will update a specific allocation.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocationCloud"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AllocationCloud</returns>
        public Pieces.Os.Core.Client.ApiResponse<AllocationCloud> AllocationUpdateWithHttpInfo(AllocationCloud allocationCloud = default(AllocationCloud), int operationIndex = 0)
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

            localVarRequestOptions.Data = allocationCloud;

            localVarRequestOptions.Operation = "AllocationApi.AllocationUpdate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Application-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Application-ID", this.Configuration.GetApiKeyWithPrefix("X-Application-ID"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AllocationCloud>("/allocation/update", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AllocationUpdate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /allocation/update [POST] This will update a specific allocation.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocationCloud"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AllocationCloud</returns>
        public async System.Threading.Tasks.Task<AllocationCloud> AllocationUpdateAsync(AllocationCloud allocationCloud = default(AllocationCloud), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Pieces.Os.Core.Client.ApiResponse<AllocationCloud> localVarResponse = await AllocationUpdateWithHttpInfoAsync(allocationCloud, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /allocation/update [POST] This will update a specific allocation.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="allocationCloud"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AllocationCloud)</returns>
        public async System.Threading.Tasks.Task<Pieces.Os.Core.Client.ApiResponse<AllocationCloud>> AllocationUpdateWithHttpInfoAsync(AllocationCloud allocationCloud = default(AllocationCloud), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = allocationCloud;

            localVarRequestOptions.Operation = "AllocationApi.AllocationUpdate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Application-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Application-ID", this.Configuration.GetApiKeyWithPrefix("X-Application-ID"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AllocationCloud>("/allocation/update", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AllocationUpdate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
