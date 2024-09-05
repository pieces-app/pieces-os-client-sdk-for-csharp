# Pieces.Os.Core.Api.WorkstreamSummariesApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SearchWorkstreamSummaries**](WorkstreamSummariesApi.md#searchworkstreamsummaries) | **POST** /workstream_summaries/search | /workstream_summaries/search [POST] |
| [**WorkstreamSummariesCreateNewWorkstreamSummary**](WorkstreamSummariesApi.md#workstreamsummariescreatenewworkstreamsummary) | **POST** /workstream_summaries/create | /workstream_summaries/create [POST] |
| [**WorkstreamSummariesDeleteSpecificWorkstreamSummary**](WorkstreamSummariesApi.md#workstreamsummariesdeletespecificworkstreamsummary) | **POST** /workstream_summaries/{workstream_summary}/delete | /workstream_summaries/{workstream_summary}/delete [POST] |
| [**WorkstreamSummariesSnapshot**](WorkstreamSummariesApi.md#workstreamsummariessnapshot) | **GET** /workstream_summaries | /workstream_summaries [GET] |

<a id="searchworkstreamsummaries"></a>
# **SearchWorkstreamSummaries**
> SearchedWorkstreamSummaries SearchWorkstreamSummaries (bool? transferables = null, SearchInput searchInput = null)

/workstream_summaries/search [POST]

This will search your workstream_summaries for a specific workstream_summary  note: we will just search the summary value(which is an annotation)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SearchWorkstreamSummariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamSummariesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var searchInput = new SearchInput(); // SearchInput |  (optional) 

            try
            {
                // /workstream_summaries/search [POST]
                SearchedWorkstreamSummaries result = apiInstance.SearchWorkstreamSummaries(transferables, searchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummariesApi.SearchWorkstreamSummaries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchWorkstreamSummariesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summaries/search [POST]
    ApiResponse<SearchedWorkstreamSummaries> response = apiInstance.SearchWorkstreamSummariesWithHttpInfo(transferables, searchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummariesApi.SearchWorkstreamSummariesWithHttpInfo: " + e.Message);
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

[**SearchedWorkstreamSummaries**](SearchedWorkstreamSummaries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workstreamsummariescreatenewworkstreamsummary"></a>
# **WorkstreamSummariesCreateNewWorkstreamSummary**
> WorkstreamSummary WorkstreamSummariesCreateNewWorkstreamSummary (bool? transferables = null, SeededWorkstreamSummary seededWorkstreamSummary = null)

/workstream_summaries/create [POST]

This will create a new WorkstreamSummary in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummariesCreateNewWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamSummariesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seededWorkstreamSummary = new SeededWorkstreamSummary(); // SeededWorkstreamSummary |  (optional) 

            try
            {
                // /workstream_summaries/create [POST]
                WorkstreamSummary result = apiInstance.WorkstreamSummariesCreateNewWorkstreamSummary(transferables, seededWorkstreamSummary);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummariesApi.WorkstreamSummariesCreateNewWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummariesCreateNewWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summaries/create [POST]
    ApiResponse<WorkstreamSummary> response = apiInstance.WorkstreamSummariesCreateNewWorkstreamSummaryWithHttpInfo(transferables, seededWorkstreamSummary);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummariesApi.WorkstreamSummariesCreateNewWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seededWorkstreamSummary** | [**SeededWorkstreamSummary**](SeededWorkstreamSummary.md) |  | [optional]  |

### Return type

[**WorkstreamSummary**](WorkstreamSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workstreamsummariesdeletespecificworkstreamsummary"></a>
# **WorkstreamSummariesDeleteSpecificWorkstreamSummary**
> void WorkstreamSummariesDeleteSpecificWorkstreamSummary (string workstreamSummary)

/workstream_summaries/{workstream_summary}/delete [POST]

This will delete a specific workstream_summary from the database!

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummariesDeleteSpecificWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamSummariesApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /workstream_summaries/{workstream_summary}/delete [POST]
                apiInstance.WorkstreamSummariesDeleteSpecificWorkstreamSummary(workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummariesApi.WorkstreamSummariesDeleteSpecificWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummariesDeleteSpecificWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summaries/{workstream_summary}/delete [POST]
    apiInstance.WorkstreamSummariesDeleteSpecificWorkstreamSummaryWithHttpInfo(workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummariesApi.WorkstreamSummariesDeleteSpecificWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workstreamsummariessnapshot"></a>
# **WorkstreamSummariesSnapshot**
> WorkstreamSummaries WorkstreamSummariesSnapshot (bool? transferables = null)

/workstream_summaries [GET]

This will get a snapshot of all your workstream summaries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummariesSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamSummariesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /workstream_summaries [GET]
                WorkstreamSummaries result = apiInstance.WorkstreamSummariesSnapshot(transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummariesApi.WorkstreamSummariesSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummariesSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summaries [GET]
    ApiResponse<WorkstreamSummaries> response = apiInstance.WorkstreamSummariesSnapshotWithHttpInfo(transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummariesApi.WorkstreamSummariesSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**WorkstreamSummaries**](WorkstreamSummaries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

