# Pieces.Os.Core.Api.WorkstreamPatternEngineSourceApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkstreamPatternEngineSourceScoresIncrement**](WorkstreamPatternEngineSourceApi.md#workstreampatternenginesourcescoresincrement) | **POST** /workstream_pattern_engine/source/{source}/scores/increment | &#39;/workstream_pattern_engine/source/{source}/scores/increment&#39; [POST] |
| [**WorkstreamPatternEngineSourceUpdate**](WorkstreamPatternEngineSourceApi.md#workstreampatternenginesourceupdate) | **POST** /workstream_pattern_engine/source/update | /workstream_pattern_engine/source/update [POST] |
| [**WorkstreamPatternEngineSourcesSpecificSourceSnapshot**](WorkstreamPatternEngineSourceApi.md#workstreampatternenginesourcesspecificsourcesnapshot) | **GET** /workstream_pattern_engine/source/{source} | /workstream_pattern_engine/source/{source} [GET] |

<a id="workstreampatternenginesourcescoresincrement"></a>
# **WorkstreamPatternEngineSourceScoresIncrement**
> void WorkstreamPatternEngineSourceScoresIncrement (string source, SeededScoreIncrement seededScoreIncrement = null)

'/workstream_pattern_engine/source/{source}/scores/increment' [POST]

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
    public class WorkstreamPatternEngineSourceScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineSourceApi(config);
            var source = "source_example";  // string | This is a identifier that is used to identify a specific WorkstreamPatternEngineSource
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/workstream_pattern_engine/source/{source}/scores/increment' [POST]
                apiInstance.WorkstreamPatternEngineSourceScoresIncrement(source, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineSourceApi.WorkstreamPatternEngineSourceScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineSourceScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/workstream_pattern_engine/source/{source}/scores/increment' [POST]
    apiInstance.WorkstreamPatternEngineSourceScoresIncrementWithHttpInfo(source, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineSourceApi.WorkstreamPatternEngineSourceScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **source** | **string** | This is a identifier that is used to identify a specific WorkstreamPatternEngineSource |  |
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

<a id="workstreampatternenginesourceupdate"></a>
# **WorkstreamPatternEngineSourceUpdate**
> IdentifiedWorkstreamPatternEngineSource WorkstreamPatternEngineSourceUpdate (bool? transferables = null, IdentifiedWorkstreamPatternEngineSource identifiedWorkstreamPatternEngineSource = null)

/workstream_pattern_engine/source/update [POST]

This will update a specific workstream pattern engine source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineSourceUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineSourceApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var identifiedWorkstreamPatternEngineSource = new IdentifiedWorkstreamPatternEngineSource(); // IdentifiedWorkstreamPatternEngineSource |  (optional) 

            try
            {
                // /workstream_pattern_engine/source/update [POST]
                IdentifiedWorkstreamPatternEngineSource result = apiInstance.WorkstreamPatternEngineSourceUpdate(transferables, identifiedWorkstreamPatternEngineSource);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineSourceApi.WorkstreamPatternEngineSourceUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineSourceUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/source/update [POST]
    ApiResponse<IdentifiedWorkstreamPatternEngineSource> response = apiInstance.WorkstreamPatternEngineSourceUpdateWithHttpInfo(transferables, identifiedWorkstreamPatternEngineSource);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineSourceApi.WorkstreamPatternEngineSourceUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **identifiedWorkstreamPatternEngineSource** | [**IdentifiedWorkstreamPatternEngineSource**](IdentifiedWorkstreamPatternEngineSource.md) |  | [optional]  |

### Return type

[**IdentifiedWorkstreamPatternEngineSource**](IdentifiedWorkstreamPatternEngineSource.md)

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

<a id="workstreampatternenginesourcesspecificsourcesnapshot"></a>
# **WorkstreamPatternEngineSourcesSpecificSourceSnapshot**
> IdentifiedWorkstreamPatternEngineSource WorkstreamPatternEngineSourcesSpecificSourceSnapshot (string source, bool? transferables = null)

/workstream_pattern_engine/source/{source} [GET]

This will get a snapshot of a single workstream pattern engine source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineSourcesSpecificSourceSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineSourceApi(config);
            var source = "source_example";  // string | This is a identifier that is used to identify a specific WorkstreamPatternEngineSource
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /workstream_pattern_engine/source/{source} [GET]
                IdentifiedWorkstreamPatternEngineSource result = apiInstance.WorkstreamPatternEngineSourcesSpecificSourceSnapshot(source, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineSourceApi.WorkstreamPatternEngineSourcesSpecificSourceSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineSourcesSpecificSourceSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/source/{source} [GET]
    ApiResponse<IdentifiedWorkstreamPatternEngineSource> response = apiInstance.WorkstreamPatternEngineSourcesSpecificSourceSnapshotWithHttpInfo(source, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineSourceApi.WorkstreamPatternEngineSourcesSpecificSourceSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **source** | **string** | This is a identifier that is used to identify a specific WorkstreamPatternEngineSource |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**IdentifiedWorkstreamPatternEngineSource**](IdentifiedWorkstreamPatternEngineSource.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | Workstream pattern Engine source not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

