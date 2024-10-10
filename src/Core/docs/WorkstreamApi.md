# Pieces.Os.Core.Api.WorkstreamApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkstreamSuggestionsRefresh**](WorkstreamApi.md#workstreamsuggestionsrefresh) | **POST** /workstream/suggestions/refresh | /workstream/suggestions/refresh [POST] |
| [**WorkstreamSuggestionsStream**](WorkstreamApi.md#workstreamsuggestionsstream) | **GET** /workstream/suggestions/stream | /workstream/suggestions/stream [WS] |

<a id="workstreamsuggestionsrefresh"></a>
# **WorkstreamSuggestionsRefresh**
> WorkstreamSuggestionsRefresh WorkstreamSuggestionsRefresh (SeededWorkstreamSuggestionsRefresh seededWorkstreamSuggestionsRefresh = null)

/workstream/suggestions/refresh [POST]

This will trigger a refresh(recalculation) of the suggestions items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSuggestionsRefreshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamApi(config);
            var seededWorkstreamSuggestionsRefresh = new SeededWorkstreamSuggestionsRefresh(); // SeededWorkstreamSuggestionsRefresh |  (optional) 

            try
            {
                // /workstream/suggestions/refresh [POST]
                WorkstreamSuggestionsRefresh result = apiInstance.WorkstreamSuggestionsRefresh(seededWorkstreamSuggestionsRefresh);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamApi.WorkstreamSuggestionsRefresh: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSuggestionsRefreshWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream/suggestions/refresh [POST]
    ApiResponse<WorkstreamSuggestionsRefresh> response = apiInstance.WorkstreamSuggestionsRefreshWithHttpInfo(seededWorkstreamSuggestionsRefresh);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamApi.WorkstreamSuggestionsRefreshWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededWorkstreamSuggestionsRefresh** | [**SeededWorkstreamSuggestionsRefresh**](SeededWorkstreamSuggestionsRefresh.md) |  | [optional]  |

### Return type

[**WorkstreamSuggestionsRefresh**](WorkstreamSuggestionsRefresh.md)

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

<a id="workstreamsuggestionsstream"></a>
# **WorkstreamSuggestionsStream**
> WorkstreamSuggestions WorkstreamSuggestionsStream ()

/workstream/suggestions/stream [WS]

Provides a WebSocket connection that emits changes to your workstream suggestions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSuggestionsStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamApi(config);

            try
            {
                // /workstream/suggestions/stream [WS]
                WorkstreamSuggestions result = apiInstance.WorkstreamSuggestionsStream();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamApi.WorkstreamSuggestionsStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSuggestionsStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream/suggestions/stream [WS]
    ApiResponse<WorkstreamSuggestions> response = apiInstance.WorkstreamSuggestionsStreamWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamApi.WorkstreamSuggestionsStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkstreamSuggestions**](WorkstreamSuggestions.md)

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

