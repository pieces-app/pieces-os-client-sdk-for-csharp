# Pieces.Os.Core.Api.WorkstreamEventsApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkstreamEventsCreateNewWorkstreamEvent**](WorkstreamEventsApi.md#workstreameventscreatenewworkstreamevent) | **POST** /workstream_events/create | /workstream_events/create [POST] |
| [**WorkstreamEventsDeleteSpecificWorkstreamEvent**](WorkstreamEventsApi.md#workstreameventsdeletespecificworkstreamevent) | **POST** /workstream_events/{workstream_event}/delete | /workstream_events/{workstream_event}/delete [POST] |
| [**WorkstreamEventsSnapshot**](WorkstreamEventsApi.md#workstreameventssnapshot) | **GET** /workstream_events | /workstream_events [GET] |

<a id="workstreameventscreatenewworkstreamevent"></a>
# **WorkstreamEventsCreateNewWorkstreamEvent**
> WorkstreamEvent WorkstreamEventsCreateNewWorkstreamEvent (bool? transferables = null, SeededWorkstreamEvent seededWorkstreamEvent = null)

/workstream_events/create [POST]

This will create a new WorkstreamEvent in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamEventsCreateNewWorkstreamEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamEventsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seededWorkstreamEvent = new SeededWorkstreamEvent(); // SeededWorkstreamEvent |  (optional) 

            try
            {
                // /workstream_events/create [POST]
                WorkstreamEvent result = apiInstance.WorkstreamEventsCreateNewWorkstreamEvent(transferables, seededWorkstreamEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamEventsApi.WorkstreamEventsCreateNewWorkstreamEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamEventsCreateNewWorkstreamEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_events/create [POST]
    ApiResponse<WorkstreamEvent> response = apiInstance.WorkstreamEventsCreateNewWorkstreamEventWithHttpInfo(transferables, seededWorkstreamEvent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamEventsApi.WorkstreamEventsCreateNewWorkstreamEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seededWorkstreamEvent** | [**SeededWorkstreamEvent**](SeededWorkstreamEvent.md) |  | [optional]  |

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

<a id="workstreameventsdeletespecificworkstreamevent"></a>
# **WorkstreamEventsDeleteSpecificWorkstreamEvent**
> void WorkstreamEventsDeleteSpecificWorkstreamEvent (string workstreamEvent)

/workstream_events/{workstream_event}/delete [POST]

This will delete a specific workstream_event from the database!

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamEventsDeleteSpecificWorkstreamEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamEventsApi(config);
            var workstreamEvent = "workstreamEvent_example";  // string | This is a identifier that is used to identify a specific workstream_event.

            try
            {
                // /workstream_events/{workstream_event}/delete [POST]
                apiInstance.WorkstreamEventsDeleteSpecificWorkstreamEvent(workstreamEvent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamEventsApi.WorkstreamEventsDeleteSpecificWorkstreamEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamEventsDeleteSpecificWorkstreamEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_events/{workstream_event}/delete [POST]
    apiInstance.WorkstreamEventsDeleteSpecificWorkstreamEventWithHttpInfo(workstreamEvent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamEventsApi.WorkstreamEventsDeleteSpecificWorkstreamEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamEvent** | **string** | This is a identifier that is used to identify a specific workstream_event. |  |

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

<a id="workstreameventssnapshot"></a>
# **WorkstreamEventsSnapshot**
> WorkstreamEvents WorkstreamEventsSnapshot (bool? transferables = null)

/workstream_events [GET]

This will get a snapshot of all your workstream events.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamEventsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new WorkstreamEventsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /workstream_events [GET]
                WorkstreamEvents result = apiInstance.WorkstreamEventsSnapshot(transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamEventsApi.WorkstreamEventsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamEventsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_events [GET]
    ApiResponse<WorkstreamEvents> response = apiInstance.WorkstreamEventsSnapshotWithHttpInfo(transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamEventsApi.WorkstreamEventsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**WorkstreamEvents**](WorkstreamEvents.md)

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

