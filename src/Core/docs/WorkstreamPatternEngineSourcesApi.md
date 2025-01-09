# Pieces.Os.Core.Api.WorkstreamPatternEngineSourcesApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkstreamPatternEngineSearchSources**](WorkstreamPatternEngineSourcesApi.md#workstreampatternenginesearchsources) | **POST** /workstream_pattern_engine/sources/search | /workstream_pattern_engine/sources/search [POST] |
| [**WorkstreamPatternEngineSourcesCreateNewSource**](WorkstreamPatternEngineSourcesApi.md#workstreampatternenginesourcescreatenewsource) | **POST** /workstream_pattern_engine/sources/create | /workstream_pattern_engine/sources/create [POST] |
| [**WorkstreamPatternEngineSourcesDeleteSpecificSource**](WorkstreamPatternEngineSourcesApi.md#workstreampatternenginesourcesdeletespecificsource) | **POST** /workstream_pattern_engine/sources/{source}/delete | /workstream_pattern_engine/sources/{source}/delete [POST] |
| [**WorkstreamPatternEngineSourcesSnapshot**](WorkstreamPatternEngineSourcesApi.md#workstreampatternenginesourcessnapshot) | **GET** /workstream_pattern_engine/sources | /workstream_pattern_engine/sources [GET] |
| [**WorkstreamPatternEngineSourcesStreamIdentifiers**](WorkstreamPatternEngineSourcesApi.md#workstreampatternenginesourcesstreamidentifiers) | **GET** /workstream_pattern_engine/sources/stream/identifiers | /workstream_pattern_engine/sources/stream/identifiers [WS] |

<a id="workstreampatternenginesearchsources"></a>
# **WorkstreamPatternEngineSearchSources**
> SearchedIdentifiedWorkstreamPatternEngineSources WorkstreamPatternEngineSearchSources (bool? transferables = null, SearchInput searchInput = null)

/workstream_pattern_engine/sources/search [POST]

This will search your workstream pattern engine sources

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineSearchSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineSourcesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var searchInput = new SearchInput(); // SearchInput |  (optional) 

            try
            {
                // /workstream_pattern_engine/sources/search [POST]
                SearchedIdentifiedWorkstreamPatternEngineSources result = apiInstance.WorkstreamPatternEngineSearchSources(transferables, searchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineSourcesApi.WorkstreamPatternEngineSearchSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineSearchSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/sources/search [POST]
    ApiResponse<SearchedIdentifiedWorkstreamPatternEngineSources> response = apiInstance.WorkstreamPatternEngineSearchSourcesWithHttpInfo(transferables, searchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineSourcesApi.WorkstreamPatternEngineSearchSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **searchInput** | [**SearchInput**](SearchInput.md) |  | [optional]  |

### Return type

[**SearchedIdentifiedWorkstreamPatternEngineSources**](SearchedIdentifiedWorkstreamPatternEngineSources.md)

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

<a id="workstreampatternenginesourcescreatenewsource"></a>
# **WorkstreamPatternEngineSourcesCreateNewSource**
> IdentifiedWorkstreamPatternEngineSource WorkstreamPatternEngineSourcesCreateNewSource (bool? transferables = null, SeededWorkstreamPatternEngineSource seededWorkstreamPatternEngineSource = null)

/workstream_pattern_engine/sources/create [POST]

This will create a anchor and attach it to a specific asset(s) This will also ensure the anchor is normalized.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineSourcesCreateNewSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineSourcesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seededWorkstreamPatternEngineSource = new SeededWorkstreamPatternEngineSource(); // SeededWorkstreamPatternEngineSource |  (optional) 

            try
            {
                // /workstream_pattern_engine/sources/create [POST]
                IdentifiedWorkstreamPatternEngineSource result = apiInstance.WorkstreamPatternEngineSourcesCreateNewSource(transferables, seededWorkstreamPatternEngineSource);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineSourcesApi.WorkstreamPatternEngineSourcesCreateNewSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineSourcesCreateNewSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/sources/create [POST]
    ApiResponse<IdentifiedWorkstreamPatternEngineSource> response = apiInstance.WorkstreamPatternEngineSourcesCreateNewSourceWithHttpInfo(transferables, seededWorkstreamPatternEngineSource);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineSourcesApi.WorkstreamPatternEngineSourcesCreateNewSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seededWorkstreamPatternEngineSource** | [**SeededWorkstreamPatternEngineSource**](SeededWorkstreamPatternEngineSource.md) |  | [optional]  |

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

<a id="workstreampatternenginesourcesdeletespecificsource"></a>
# **WorkstreamPatternEngineSourcesDeleteSpecificSource**
> void WorkstreamPatternEngineSourcesDeleteSpecificSource (string source)

/workstream_pattern_engine/sources/{source}/delete [POST]

This will delete a specific workstream pattern engine source!

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineSourcesDeleteSpecificSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineSourcesApi(config);
            var source = "source_example";  // string | This is a identifier that is used to identify a specific WorkstreamPatternEngineSource

            try
            {
                // /workstream_pattern_engine/sources/{source}/delete [POST]
                apiInstance.WorkstreamPatternEngineSourcesDeleteSpecificSource(source);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineSourcesApi.WorkstreamPatternEngineSourcesDeleteSpecificSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineSourcesDeleteSpecificSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/sources/{source}/delete [POST]
    apiInstance.WorkstreamPatternEngineSourcesDeleteSpecificSourceWithHttpInfo(source);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineSourcesApi.WorkstreamPatternEngineSourcesDeleteSpecificSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **source** | **string** | This is a identifier that is used to identify a specific WorkstreamPatternEngineSource |  |

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

<a id="workstreampatternenginesourcessnapshot"></a>
# **WorkstreamPatternEngineSourcesSnapshot**
> IdentifiedWorkstreamPatternEngineSources WorkstreamPatternEngineSourcesSnapshot (bool? transferables = null)

/workstream_pattern_engine/sources [GET]

This will get a snapshot of all your anchors.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineSourcesSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineSourcesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /workstream_pattern_engine/sources [GET]
                IdentifiedWorkstreamPatternEngineSources result = apiInstance.WorkstreamPatternEngineSourcesSnapshot(transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineSourcesApi.WorkstreamPatternEngineSourcesSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineSourcesSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/sources [GET]
    ApiResponse<IdentifiedWorkstreamPatternEngineSources> response = apiInstance.WorkstreamPatternEngineSourcesSnapshotWithHttpInfo(transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineSourcesApi.WorkstreamPatternEngineSourcesSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**IdentifiedWorkstreamPatternEngineSources**](IdentifiedWorkstreamPatternEngineSources.md)

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

<a id="workstreampatternenginesourcesstreamidentifiers"></a>
# **WorkstreamPatternEngineSourcesStreamIdentifiers**
> StreamedIdentifiers WorkstreamPatternEngineSourcesStreamIdentifiers ()

/workstream_pattern_engine/sources/stream/identifiers [WS]

Provides a WebSocket connection that emits changes to your workstream-pattern-engine soures identifiers (UUIDs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineSourcesStreamIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineSourcesApi(config);

            try
            {
                // /workstream_pattern_engine/sources/stream/identifiers [WS]
                StreamedIdentifiers result = apiInstance.WorkstreamPatternEngineSourcesStreamIdentifiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineSourcesApi.WorkstreamPatternEngineSourcesStreamIdentifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineSourcesStreamIdentifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/sources/stream/identifiers [WS]
    ApiResponse<StreamedIdentifiers> response = apiInstance.WorkstreamPatternEngineSourcesStreamIdentifiersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineSourcesApi.WorkstreamPatternEngineSourcesStreamIdentifiersWithHttpInfo: " + e.Message);
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

