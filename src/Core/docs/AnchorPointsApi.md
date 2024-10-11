# Pieces.Os.Core.Api.AnchorPointsApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AnchorPointsCreateNewAnchorPoint**](AnchorPointsApi.md#anchorpointscreatenewanchorpoint) | **POST** /anchor_points/create | /anchor_points/create [POST] |
| [**AnchorPointsDeleteSpecificAnchorPoint**](AnchorPointsApi.md#anchorpointsdeletespecificanchorpoint) | **POST** /anchor_points/{anchor_point}/delete | /anchor_points/{anchor_point}/delete [POST] |
| [**AnchorPointsSnapshot**](AnchorPointsApi.md#anchorpointssnapshot) | **GET** /anchor_points | /anchor_points [GET] |
| [**AnchorPointsStreamIdentifiers**](AnchorPointsApi.md#anchorpointsstreamidentifiers) | **GET** /anchor_points/stream/identifiers | /anchor_points/stream/identifiers [WS] |

<a id="anchorpointscreatenewanchorpoint"></a>
# **AnchorPointsCreateNewAnchorPoint**
> AnchorPoint AnchorPointsCreateNewAnchorPoint (bool? transferables = null, SeededAnchorPoint seededAnchorPoint = null)

/anchor_points/create [POST]

This will create a anchorPoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorPointsCreateNewAnchorPointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AnchorPointsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seededAnchorPoint = new SeededAnchorPoint(); // SeededAnchorPoint |  (optional) 

            try
            {
                // /anchor_points/create [POST]
                AnchorPoint result = apiInstance.AnchorPointsCreateNewAnchorPoint(transferables, seededAnchorPoint);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorPointsApi.AnchorPointsCreateNewAnchorPoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorPointsCreateNewAnchorPointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor_points/create [POST]
    ApiResponse<AnchorPoint> response = apiInstance.AnchorPointsCreateNewAnchorPointWithHttpInfo(transferables, seededAnchorPoint);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorPointsApi.AnchorPointsCreateNewAnchorPointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seededAnchorPoint** | [**SeededAnchorPoint**](SeededAnchorPoint.md) |  | [optional]  |

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

<a id="anchorpointsdeletespecificanchorpoint"></a>
# **AnchorPointsDeleteSpecificAnchorPoint**
> void AnchorPointsDeleteSpecificAnchorPoint (string anchorPoint)

/anchor_points/{anchor_point}/delete [POST]

This will delete a specific anchorPoint!

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorPointsDeleteSpecificAnchorPointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AnchorPointsApi(config);
            var anchorPoint = "anchorPoint_example";  // string | This is the specific uuid of an anchor_point.

            try
            {
                // /anchor_points/{anchor_point}/delete [POST]
                apiInstance.AnchorPointsDeleteSpecificAnchorPoint(anchorPoint);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorPointsApi.AnchorPointsDeleteSpecificAnchorPoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorPointsDeleteSpecificAnchorPointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor_points/{anchor_point}/delete [POST]
    apiInstance.AnchorPointsDeleteSpecificAnchorPointWithHttpInfo(anchorPoint);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorPointsApi.AnchorPointsDeleteSpecificAnchorPointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchorPoint** | **string** | This is the specific uuid of an anchor_point. |  |

### Return type

void (empty response body)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="anchorpointssnapshot"></a>
# **AnchorPointsSnapshot**
> AnchorPoints AnchorPointsSnapshot (bool? transferables = null)

/anchor_points [GET]

This will get a snapshot of all your anchorPoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorPointsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AnchorPointsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /anchor_points [GET]
                AnchorPoints result = apiInstance.AnchorPointsSnapshot(transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorPointsApi.AnchorPointsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorPointsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor_points [GET]
    ApiResponse<AnchorPoints> response = apiInstance.AnchorPointsSnapshotWithHttpInfo(transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorPointsApi.AnchorPointsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**AnchorPoints**](AnchorPoints.md)

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

<a id="anchorpointsstreamidentifiers"></a>
# **AnchorPointsStreamIdentifiers**
> StreamedIdentifiers AnchorPointsStreamIdentifiers ()

/anchor_points/stream/identifiers [WS]

Provides a WebSocket connection that emits changes to your annotation identifiers (UUIDs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorPointsStreamIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AnchorPointsApi(config);

            try
            {
                // /anchor_points/stream/identifiers [WS]
                StreamedIdentifiers result = apiInstance.AnchorPointsStreamIdentifiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorPointsApi.AnchorPointsStreamIdentifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorPointsStreamIdentifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor_points/stream/identifiers [WS]
    ApiResponse<StreamedIdentifiers> response = apiInstance.AnchorPointsStreamIdentifiersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorPointsApi.AnchorPointsStreamIdentifiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**StreamedIdentifiers**](StreamedIdentifiers.md)

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

