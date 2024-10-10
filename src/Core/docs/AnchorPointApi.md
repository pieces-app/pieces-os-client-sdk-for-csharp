# Pieces.Os.Core.Api.AnchorPointApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AnchorPointScoresIncrement**](AnchorPointApi.md#anchorpointscoresincrement) | **POST** /anchor_point/{anchor_point}/scores/increment | &#39;/anchor_point/{anchor_point}/scores/increment&#39; [POST] |
| [**AnchorPointSpecificAnchorPointSnapshot**](AnchorPointApi.md#anchorpointspecificanchorpointsnapshot) | **GET** /anchor_point/{anchor_point} | /anchor_point/{anchor_point} [GET] |
| [**AnchorPointUpdate**](AnchorPointApi.md#anchorpointupdate) | **POST** /anchor_point/update | /anchor_point/update [POST] |

<a id="anchorpointscoresincrement"></a>
# **AnchorPointScoresIncrement**
> void AnchorPointScoresIncrement (string anchorPoint, SeededScoreIncrement seededScoreIncrement = null)

'/anchor_point/{anchor_point}/scores/increment' [POST]

This will take in a SeededScoreIncrement and will increment the material relative to the incoming body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorPointScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AnchorPointApi(config);
            var anchorPoint = "anchorPoint_example";  // string | This is the specific uuid of an anchor_point.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/anchor_point/{anchor_point}/scores/increment' [POST]
                apiInstance.AnchorPointScoresIncrement(anchorPoint, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorPointApi.AnchorPointScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorPointScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/anchor_point/{anchor_point}/scores/increment' [POST]
    apiInstance.AnchorPointScoresIncrementWithHttpInfo(anchorPoint, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorPointApi.AnchorPointScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchorPoint** | **string** | This is the specific uuid of an anchor_point. |  |
| **seededScoreIncrement** | [**SeededScoreIncrement**](SeededScoreIncrement.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="anchorpointspecificanchorpointsnapshot"></a>
# **AnchorPointSpecificAnchorPointSnapshot**
> AnchorPoint AnchorPointSpecificAnchorPointSnapshot (string anchorPoint, bool? transferables = null)

/anchor_point/{anchor_point} [GET]

This will get a snapshot of a single anchorPoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorPointSpecificAnchorPointSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AnchorPointApi(config);
            var anchorPoint = "anchorPoint_example";  // string | This is the specific uuid of an anchor_point.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /anchor_point/{anchor_point} [GET]
                AnchorPoint result = apiInstance.AnchorPointSpecificAnchorPointSnapshot(anchorPoint, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorPointApi.AnchorPointSpecificAnchorPointSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorPointSpecificAnchorPointSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor_point/{anchor_point} [GET]
    ApiResponse<AnchorPoint> response = apiInstance.AnchorPointSpecificAnchorPointSnapshotWithHttpInfo(anchorPoint, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorPointApi.AnchorPointSpecificAnchorPointSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchorPoint** | **string** | This is the specific uuid of an anchor_point. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**AnchorPoint**](AnchorPoint.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | AnchorPoint not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="anchorpointupdate"></a>
# **AnchorPointUpdate**
> AnchorPoint AnchorPointUpdate (bool? transferables = null, AnchorPoint anchorPoint = null)

/anchor_point/update [POST]

This will update a specific anchorPoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorPointUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AnchorPointApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var anchorPoint = new AnchorPoint(); // AnchorPoint |  (optional) 

            try
            {
                // /anchor_point/update [POST]
                AnchorPoint result = apiInstance.AnchorPointUpdate(transferables, anchorPoint);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorPointApi.AnchorPointUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorPointUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor_point/update [POST]
    ApiResponse<AnchorPoint> response = apiInstance.AnchorPointUpdateWithHttpInfo(transferables, anchorPoint);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorPointApi.AnchorPointUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **anchorPoint** | [**AnchorPoint**](AnchorPoint.md) |  | [optional]  |

### Return type

[**AnchorPoint**](AnchorPoint.md)

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

