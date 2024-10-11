# Pieces.Os.Core.Api.DistributionApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DistributionUpdate**](DistributionApi.md#distributionupdate) | **POST** /distribution/update | /distribution/update [POST] |
| [**DistributionsSpecificDistributionSnapshot**](DistributionApi.md#distributionsspecificdistributionsnapshot) | **GET** /distribution/{distribution} | /distribution/{distribution} [GET] |

<a id="distributionupdate"></a>
# **DistributionUpdate**
> Distribution DistributionUpdate (Distribution distribution = null)

/distribution/update [POST]

This will update a specific Distribution.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DistributionUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new DistributionApi(config);
            var distribution = new Distribution(); // Distribution |  (optional) 

            try
            {
                // /distribution/update [POST]
                Distribution result = apiInstance.DistributionUpdate(distribution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistributionApi.DistributionUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DistributionUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /distribution/update [POST]
    ApiResponse<Distribution> response = apiInstance.DistributionUpdateWithHttpInfo(distribution);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DistributionApi.DistributionUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **distribution** | [**Distribution**](Distribution.md) |  | [optional]  |

### Return type

[**Distribution**](Distribution.md)

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

<a id="distributionsspecificdistributionsnapshot"></a>
# **DistributionsSpecificDistributionSnapshot**
> Distribution DistributionsSpecificDistributionSnapshot (string distribution)

/distribution/{distribution} [GET]

This will get a specific snapshot of a distribution.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DistributionsSpecificDistributionSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new DistributionApi(config);
            var distribution = "distribution_example";  // string | This is the uuid of a specific distribution.

            try
            {
                // /distribution/{distribution} [GET]
                Distribution result = apiInstance.DistributionsSpecificDistributionSnapshot(distribution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistributionApi.DistributionsSpecificDistributionSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DistributionsSpecificDistributionSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /distribution/{distribution} [GET]
    ApiResponse<Distribution> response = apiInstance.DistributionsSpecificDistributionSnapshotWithHttpInfo(distribution);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DistributionApi.DistributionsSpecificDistributionSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **distribution** | **string** | This is the uuid of a specific distribution. |  |

### Return type

[**Distribution**](Distribution.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | Distribution not found. |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

