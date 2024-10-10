# Pieces.Os.Core.Api.ExternalProviderApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExternalProviderApiKeyCreate**](ExternalProviderApi.md#externalproviderapikeycreate) | **POST** /external_provider/api_key/create | /external_provider/api_key/create [POST] |
| [**ExternalProviderApiKeyDelete**](ExternalProviderApi.md#externalproviderapikeydelete) | **POST** /external_provider/api_key/delete | /external_provider/api_key/delete [POST] |
| [**ExternalProviderApiKeyUpdate**](ExternalProviderApi.md#externalproviderapikeyupdate) | **POST** /external_provider/api_key/update | /external_provider/api_key/update [POST] |

<a id="externalproviderapikeycreate"></a>
# **ExternalProviderApiKeyCreate**
> CreatedExternalProviderApiKey ExternalProviderApiKeyCreate (PrecreatedExternalProviderApiKey precreatedExternalProviderApiKey = null)

/external_provider/api_key/create [POST]

This will create a specific external_provider api_key from a specific user Auth0UserMetadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ExternalProviderApiKeyCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ExternalProviderApi(config);
            var precreatedExternalProviderApiKey = new PrecreatedExternalProviderApiKey(); // PrecreatedExternalProviderApiKey |  (optional) 

            try
            {
                // /external_provider/api_key/create [POST]
                CreatedExternalProviderApiKey result = apiInstance.ExternalProviderApiKeyCreate(precreatedExternalProviderApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalProviderApi.ExternalProviderApiKeyCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalProviderApiKeyCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /external_provider/api_key/create [POST]
    ApiResponse<CreatedExternalProviderApiKey> response = apiInstance.ExternalProviderApiKeyCreateWithHttpInfo(precreatedExternalProviderApiKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalProviderApi.ExternalProviderApiKeyCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **precreatedExternalProviderApiKey** | [**PrecreatedExternalProviderApiKey**](PrecreatedExternalProviderApiKey.md) |  | [optional]  |

### Return type

[**CreatedExternalProviderApiKey**](CreatedExternalProviderApiKey.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Invalid Authentication, Incorrect API key provided or organization |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="externalproviderapikeydelete"></a>
# **ExternalProviderApiKeyDelete**
> DeletedExternalProviderApiKey ExternalProviderApiKeyDelete (PredeletedExternalProviderApiKey predeletedExternalProviderApiKey = null)

/external_provider/api_key/delete [POST]

This will remove a specific external_provider api_key from a specific user Auth0UserMetadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ExternalProviderApiKeyDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ExternalProviderApi(config);
            var predeletedExternalProviderApiKey = new PredeletedExternalProviderApiKey(); // PredeletedExternalProviderApiKey |  (optional) 

            try
            {
                // /external_provider/api_key/delete [POST]
                DeletedExternalProviderApiKey result = apiInstance.ExternalProviderApiKeyDelete(predeletedExternalProviderApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalProviderApi.ExternalProviderApiKeyDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalProviderApiKeyDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /external_provider/api_key/delete [POST]
    ApiResponse<DeletedExternalProviderApiKey> response = apiInstance.ExternalProviderApiKeyDeleteWithHttpInfo(predeletedExternalProviderApiKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalProviderApi.ExternalProviderApiKeyDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **predeletedExternalProviderApiKey** | [**PredeletedExternalProviderApiKey**](PredeletedExternalProviderApiKey.md) |  | [optional]  |

### Return type

[**DeletedExternalProviderApiKey**](DeletedExternalProviderApiKey.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Invalid Authentication, Incorrect API key provided or organization |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="externalproviderapikeyupdate"></a>
# **ExternalProviderApiKeyUpdate**
> UpdatedExternalProviderApiKey ExternalProviderApiKeyUpdate (PreupdatedExternalProviderApiKey preupdatedExternalProviderApiKey = null)

/external_provider/api_key/update [POST]

This will update a specific external_provider api_key from a specific user Auth0UserMetadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ExternalProviderApiKeyUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ExternalProviderApi(config);
            var preupdatedExternalProviderApiKey = new PreupdatedExternalProviderApiKey(); // PreupdatedExternalProviderApiKey |  (optional) 

            try
            {
                // /external_provider/api_key/update [POST]
                UpdatedExternalProviderApiKey result = apiInstance.ExternalProviderApiKeyUpdate(preupdatedExternalProviderApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalProviderApi.ExternalProviderApiKeyUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalProviderApiKeyUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /external_provider/api_key/update [POST]
    ApiResponse<UpdatedExternalProviderApiKey> response = apiInstance.ExternalProviderApiKeyUpdateWithHttpInfo(preupdatedExternalProviderApiKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalProviderApi.ExternalProviderApiKeyUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **preupdatedExternalProviderApiKey** | [**PreupdatedExternalProviderApiKey**](PreupdatedExternalProviderApiKey.md) |  | [optional]  |

### Return type

[**UpdatedExternalProviderApiKey**](UpdatedExternalProviderApiKey.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Invalid Authentication, Incorrect API key provided or organization |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

