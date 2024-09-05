# Pieces.Os.Core.Api.WorkstreamEventApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkstreamEventAssociateWorkstreamSummary**](WorkstreamEventApi.md#workstreameventassociateworkstreamsummary) | **POST** /workstream_event/{workstream_event}/workstream_summaries/associate/{workstream_summary} | /workstream_event/{workstream_event}/workstream_summaries/associate/{workstream_summary} [POST] |
| [**WorkstreamEventDisassociateWorkstreamSummary**](WorkstreamEventApi.md#workstreameventdisassociateworkstreamsummary) | **POST** /workstream_event/{workstream_event}/workstream_summaries/disassociate/{workstream_summary} | /workstream_event/{workstream_event}/workstream_summaries/disassociate/{workstream_summary} [POST] |
| [**WorkstreamEventScoresIncrement**](WorkstreamEventApi.md#workstreameventscoresincrement) | **POST** /workstream_event/{workstream_event}/scores/increment | &#39;/workstream_event/{workstream_event}/scores/increment&#39; [POST] |
| [**WorkstreamEventUpdate**](WorkstreamEventApi.md#workstreameventupdate) | **POST** /workstream_event/update | /workstream_event/update [POST] |
| [**WorkstreamEventsSpecificWorkstreamEventSnapshot**](WorkstreamEventApi.md#workstreameventsspecificworkstreameventsnapshot) | **GET** /workstream_event/{workstream_event} | /workstream_event/{workstream_event} [GET] |

<a id="workstreameventassociateworkstreamsummary"></a>
# **WorkstreamEventAssociateWorkstreamSummary**
> void WorkstreamEventAssociateWorkstreamSummary (string workstreamEvent, string workstreamSummary)

/workstream_event/{workstream_event}/workstream_summaries/associate/{workstream_summary} [POST]

This will associate a workstream_event with a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamEventAssociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamEventApi(config);
            var workstreamEvent = "workstreamEvent_example";  // string | This is a identifier that is used to identify a specific workstream_event.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /workstream_event/{workstream_event}/workstream_summaries/associate/{workstream_summary} [POST]
                apiInstance.WorkstreamEventAssociateWorkstreamSummary(workstreamEvent, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamEventApi.WorkstreamEventAssociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamEventAssociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_event/{workstream_event}/workstream_summaries/associate/{workstream_summary} [POST]
    apiInstance.WorkstreamEventAssociateWorkstreamSummaryWithHttpInfo(workstreamEvent, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamEventApi.WorkstreamEventAssociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamEvent** | **string** | This is a identifier that is used to identify a specific workstream_event. |  |
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

<a id="workstreameventdisassociateworkstreamsummary"></a>
# **WorkstreamEventDisassociateWorkstreamSummary**
> void WorkstreamEventDisassociateWorkstreamSummary (string workstreamEvent, string workstreamSummary)

/workstream_event/{workstream_event}/workstream_summaries/disassociate/{workstream_summary} [POST]

This will enable us to disassociate a workstream_event from a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamEventDisassociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamEventApi(config);
            var workstreamEvent = "workstreamEvent_example";  // string | This is a identifier that is used to identify a specific workstream_event.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /workstream_event/{workstream_event}/workstream_summaries/disassociate/{workstream_summary} [POST]
                apiInstance.WorkstreamEventDisassociateWorkstreamSummary(workstreamEvent, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamEventApi.WorkstreamEventDisassociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamEventDisassociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_event/{workstream_event}/workstream_summaries/disassociate/{workstream_summary} [POST]
    apiInstance.WorkstreamEventDisassociateWorkstreamSummaryWithHttpInfo(workstreamEvent, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamEventApi.WorkstreamEventDisassociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamEvent** | **string** | This is a identifier that is used to identify a specific workstream_event. |  |
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

<a id="workstreameventscoresincrement"></a>
# **WorkstreamEventScoresIncrement**
> void WorkstreamEventScoresIncrement (string workstreamEvent, SeededScoreIncrement seededScoreIncrement = null)

'/workstream_event/{workstream_event}/scores/increment' [POST]

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
    public class WorkstreamEventScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamEventApi(config);
            var workstreamEvent = "workstreamEvent_example";  // string | This is a identifier that is used to identify a specific workstream_event.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/workstream_event/{workstream_event}/scores/increment' [POST]
                apiInstance.WorkstreamEventScoresIncrement(workstreamEvent, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamEventApi.WorkstreamEventScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamEventScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/workstream_event/{workstream_event}/scores/increment' [POST]
    apiInstance.WorkstreamEventScoresIncrementWithHttpInfo(workstreamEvent, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamEventApi.WorkstreamEventScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamEvent** | **string** | This is a identifier that is used to identify a specific workstream_event. |  |
| **seededScoreIncrement** | [**SeededScoreIncrement**](SeededScoreIncrement.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workstreameventupdate"></a>
# **WorkstreamEventUpdate**
> WorkstreamEvent WorkstreamEventUpdate (bool? transferables = null, WorkstreamEvent workstreamEvent = null)

/workstream_event/update [POST]

This will update a specific workstream_event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamEventUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamEventApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var workstreamEvent = new WorkstreamEvent(); // WorkstreamEvent |  (optional) 

            try
            {
                // /workstream_event/update [POST]
                WorkstreamEvent result = apiInstance.WorkstreamEventUpdate(transferables, workstreamEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamEventApi.WorkstreamEventUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamEventUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_event/update [POST]
    ApiResponse<WorkstreamEvent> response = apiInstance.WorkstreamEventUpdateWithHttpInfo(transferables, workstreamEvent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamEventApi.WorkstreamEventUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **workstreamEvent** | [**WorkstreamEvent**](WorkstreamEvent.md) |  | [optional]  |

### Return type

[**WorkstreamEvent**](WorkstreamEvent.md)

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

<a id="workstreameventsspecificworkstreameventsnapshot"></a>
# **WorkstreamEventsSpecificWorkstreamEventSnapshot**
> WorkstreamEvent WorkstreamEventsSpecificWorkstreamEventSnapshot (string workstreamEvent, bool? transferables = null)

/workstream_event/{workstream_event} [GET]

This will get a snapshot of a single workstream_event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamEventsSpecificWorkstreamEventSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamEventApi(config);
            var workstreamEvent = "workstreamEvent_example";  // string | This is a identifier that is used to identify a specific workstream_event.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /workstream_event/{workstream_event} [GET]
                WorkstreamEvent result = apiInstance.WorkstreamEventsSpecificWorkstreamEventSnapshot(workstreamEvent, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamEventApi.WorkstreamEventsSpecificWorkstreamEventSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamEventsSpecificWorkstreamEventSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_event/{workstream_event} [GET]
    ApiResponse<WorkstreamEvent> response = apiInstance.WorkstreamEventsSpecificWorkstreamEventSnapshotWithHttpInfo(workstreamEvent, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamEventApi.WorkstreamEventsSpecificWorkstreamEventSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamEvent** | **string** | This is a identifier that is used to identify a specific workstream_event. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**WorkstreamEvent**](WorkstreamEvent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | WorkstreamEvent not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

