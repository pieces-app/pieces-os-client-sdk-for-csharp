# Pieces.Os.Core.Api.OllamaApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OllamaInstall**](OllamaApi.md#ollamainstall) | **POST** /ollama/install | /ollama/install [POST] |
| [**OllamaInstallCancel**](OllamaApi.md#ollamainstallcancel) | **POST** /ollama/install/{identifier}/cancel | /ollama/install/{identifier}/cancel [POST] |
| [**OllamaInstallSnapshot**](OllamaApi.md#ollamainstallsnapshot) | **GET** /ollama/install/{identifier} | /ollama/install/{identifier} [GET] |
| [**OllamaInstallsSnapshot**](OllamaApi.md#ollamainstallssnapshot) | **GET** /ollama/installs | /ollama/installs [GET] |
| [**OllamaStatusCheck**](OllamaApi.md#ollamastatuscheck) | **GET** /ollama/status | /ollama/status [GET] |
| [**OllamaStatusCheckStream**](OllamaApi.md#ollamastatuscheckstream) | **GET** /ollama/status/stream | /ollama/status/stream [WS] |
| [**OllamaUninstall**](OllamaApi.md#ollamauninstall) | **POST** /ollama/uninstall | /ollama/uninstall [POST] |
| [**OllamaUpdate**](OllamaApi.md#ollamaupdate) | **POST** /ollama/update | /ollama/update [POST] |
| [**OllamaUpdateCancel**](OllamaApi.md#ollamaupdatecancel) | **POST** /ollama/update/{identifier}/cancel | /ollama/update/{identifier}/cancel [POST] |
| [**OllamaUpdateSnapshot**](OllamaApi.md#ollamaupdatesnapshot) | **GET** /ollama/update/{identifier} | /ollama/update/{identifier} [GET] |
| [**OllamaUpdatesSnapshot**](OllamaApi.md#ollamaupdatessnapshot) | **GET** /ollama/updates | /ollama/updates [GET] |

<a id="ollamainstall"></a>
# **OllamaInstall**
> OllamaDeployment OllamaInstall ()

/ollama/install [POST]

This will start the installation for ollama. NOTE: This will return immediately, use the update status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaInstallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);

            try
            {
                // /ollama/install [POST]
                OllamaDeployment result = apiInstance.OllamaInstall();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaInstall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaInstallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/install [POST]
    ApiResponse<OllamaDeployment> response = apiInstance.OllamaInstallWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaInstallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OllamaDeployment**](OllamaDeployment.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ollamainstallcancel"></a>
# **OllamaInstallCancel**
> OllamaDeployment OllamaInstallCancel (string identifier)

/ollama/install/{identifier}/cancel [POST]

This will cancel a specific installation that is in-progress.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaInstallCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);
            var identifier = "identifier_example";  // string | This is a identifier that is used to identify a specific generic event.

            try
            {
                // /ollama/install/{identifier}/cancel [POST]
                OllamaDeployment result = apiInstance.OllamaInstallCancel(identifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaInstallCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaInstallCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/install/{identifier}/cancel [POST]
    ApiResponse<OllamaDeployment> response = apiInstance.OllamaInstallCancelWithHttpInfo(identifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaInstallCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifier** | **string** | This is a identifier that is used to identify a specific generic event. |  |

### Return type

[**OllamaDeployment**](OllamaDeployment.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ollamainstallsnapshot"></a>
# **OllamaInstallSnapshot**
> OllamaDeployment OllamaInstallSnapshot (string identifier)

/ollama/install/{identifier} [GET]

This will get the status of a given installation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaInstallSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);
            var identifier = "identifier_example";  // string | This is a identifier that is used to identify a specific generic event.

            try
            {
                // /ollama/install/{identifier} [GET]
                OllamaDeployment result = apiInstance.OllamaInstallSnapshot(identifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaInstallSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaInstallSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/install/{identifier} [GET]
    ApiResponse<OllamaDeployment> response = apiInstance.OllamaInstallSnapshotWithHttpInfo(identifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaInstallSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifier** | **string** | This is a identifier that is used to identify a specific generic event. |  |

### Return type

[**OllamaDeployment**](OllamaDeployment.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ollamainstallssnapshot"></a>
# **OllamaInstallsSnapshot**
> OllamaDeployments OllamaInstallsSnapshot ()

/ollama/installs [GET]

This will return all the installation in a given session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaInstallsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);

            try
            {
                // /ollama/installs [GET]
                OllamaDeployments result = apiInstance.OllamaInstallsSnapshot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaInstallsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaInstallsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/installs [GET]
    ApiResponse<OllamaDeployments> response = apiInstance.OllamaInstallsSnapshotWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaInstallsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OllamaDeployments**](OllamaDeployments.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ollamastatuscheck"></a>
# **OllamaStatusCheck**
> OllamaStatus OllamaStatusCheck ()

/ollama/status [GET]

This will get a status on Ollama, ie if ollama is installed, if it needs an update,  if there are installations in progress, or updates in progress

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaStatusCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);

            try
            {
                // /ollama/status [GET]
                OllamaStatus result = apiInstance.OllamaStatusCheck();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaStatusCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaStatusCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/status [GET]
    ApiResponse<OllamaStatus> response = apiInstance.OllamaStatusCheckWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaStatusCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OllamaStatus**](OllamaStatus.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ollamastatuscheckstream"></a>
# **OllamaStatusCheckStream**
> OllamaStatus OllamaStatusCheckStream ()

/ollama/status/stream [WS]

This provides a Websocket connection, that will emit a change on the initial connection and then all realtime updates: - if an update have started - if an installation has started - if Ollama has been installed/uninstalled - if an updated is required for Ollama

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaStatusCheckStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);

            try
            {
                // /ollama/status/stream [WS]
                OllamaStatus result = apiInstance.OllamaStatusCheckStream();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaStatusCheckStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaStatusCheckStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/status/stream [WS]
    ApiResponse<OllamaStatus> response = apiInstance.OllamaStatusCheckStreamWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaStatusCheckStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OllamaStatus**](OllamaStatus.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ollamauninstall"></a>
# **OllamaUninstall**
> OllamaDeployment OllamaUninstall (OllamaDeployment ollamaDeployment = null)

/ollama/uninstall [POST]

This will uninstall Ollama.  NOTE: the request body is the installation that will be deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaUninstallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);
            var ollamaDeployment = new OllamaDeployment(); // OllamaDeployment |  (optional) 

            try
            {
                // /ollama/uninstall [POST]
                OllamaDeployment result = apiInstance.OllamaUninstall(ollamaDeployment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaUninstall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaUninstallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/uninstall [POST]
    ApiResponse<OllamaDeployment> response = apiInstance.OllamaUninstallWithHttpInfo(ollamaDeployment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaUninstallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ollamaDeployment** | [**OllamaDeployment**](OllamaDeployment.md) |  | [optional]  |

### Return type

[**OllamaDeployment**](OllamaDeployment.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ollamaupdate"></a>
# **OllamaUpdate**
> OllamaDeployment OllamaUpdate (OllamaDeployment ollamaDeployment = null)

/ollama/update [POST]

This will start the update for ollama. NOTE: This will return immediately, use the ollama status endpoint to checks it status. NOTE: This will required a user to pass in deployment that they would like to update to.(only thing required will be version here, and that this is a valid version to update to.)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);
            var ollamaDeployment = new OllamaDeployment(); // OllamaDeployment |  (optional) 

            try
            {
                // /ollama/update [POST]
                OllamaDeployment result = apiInstance.OllamaUpdate(ollamaDeployment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/update [POST]
    ApiResponse<OllamaDeployment> response = apiInstance.OllamaUpdateWithHttpInfo(ollamaDeployment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ollamaDeployment** | [**OllamaDeployment**](OllamaDeployment.md) |  | [optional]  |

### Return type

[**OllamaDeployment**](OllamaDeployment.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ollamaupdatecancel"></a>
# **OllamaUpdateCancel**
> OllamaDeployment OllamaUpdateCancel (string identifier)

/ollama/update/{identifier}/cancel [POST]

This will cancel a specific update that is in-progress.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaUpdateCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);
            var identifier = "identifier_example";  // string | This is a identifier that is used to identify a specific generic event.

            try
            {
                // /ollama/update/{identifier}/cancel [POST]
                OllamaDeployment result = apiInstance.OllamaUpdateCancel(identifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaUpdateCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaUpdateCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/update/{identifier}/cancel [POST]
    ApiResponse<OllamaDeployment> response = apiInstance.OllamaUpdateCancelWithHttpInfo(identifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaUpdateCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifier** | **string** | This is a identifier that is used to identify a specific generic event. |  |

### Return type

[**OllamaDeployment**](OllamaDeployment.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ollamaupdatesnapshot"></a>
# **OllamaUpdateSnapshot**
> OllamaDeployment OllamaUpdateSnapshot (string identifier)

/ollama/update/{identifier} [GET]

This will get the status of a given update.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaUpdateSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);
            var identifier = "identifier_example";  // string | This is a identifier that is used to identify a specific generic event.

            try
            {
                // /ollama/update/{identifier} [GET]
                OllamaDeployment result = apiInstance.OllamaUpdateSnapshot(identifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaUpdateSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaUpdateSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/update/{identifier} [GET]
    ApiResponse<OllamaDeployment> response = apiInstance.OllamaUpdateSnapshotWithHttpInfo(identifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaUpdateSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifier** | **string** | This is a identifier that is used to identify a specific generic event. |  |

### Return type

[**OllamaDeployment**](OllamaDeployment.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ollamaupdatessnapshot"></a>
# **OllamaUpdatesSnapshot**
> OllamaDeployments OllamaUpdatesSnapshot ()

/ollama/updates [GET]

This will return all the attempted updates in a given session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OllamaUpdatesSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OllamaApi(config);

            try
            {
                // /ollama/updates [GET]
                OllamaDeployments result = apiInstance.OllamaUpdatesSnapshot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OllamaApi.OllamaUpdatesSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OllamaUpdatesSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ollama/updates [GET]
    ApiResponse<OllamaDeployments> response = apiInstance.OllamaUpdatesSnapshotWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OllamaApi.OllamaUpdatesSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OllamaDeployments**](OllamaDeployments.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

