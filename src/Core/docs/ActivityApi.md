# Pieces.Os.Core.Api.ActivityApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivitiesSpecificActivitySnapshot**](ActivityApi.md#activitiesspecificactivitysnapshot) | **GET** /activity/{activity} | /activity/{activity} [GET] |
| [**ActivityIdentifiersSnapshot**](ActivityApi.md#activityidentifierssnapshot) | **GET** /activity/identifiers | /activity/identifiers [GET] |
| [**ActivityUpdate**](ActivityApi.md#activityupdate) | **POST** /activity/update | /activity/update [POST] |

<a id="activitiesspecificactivitysnapshot"></a>
# **ActivitiesSpecificActivitySnapshot**
> Activity ActivitiesSpecificActivitySnapshot (string activity, bool? transferables = null)

/activity/{activity} [GET]

This will attempt to get a specific activity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ActivitiesSpecificActivitySnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ActivityApi(config);
            var activity = "activity_example";  // string | This is a specific activity uuid.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /activity/{activity} [GET]
                Activity result = apiInstance.ActivitiesSpecificActivitySnapshot(activity, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivitiesSpecificActivitySnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivitiesSpecificActivitySnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /activity/{activity} [GET]
    ApiResponse<Activity> response = apiInstance.ActivitiesSpecificActivitySnapshotWithHttpInfo(activity, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivityApi.ActivitiesSpecificActivitySnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activity** | **string** | This is a specific activity uuid. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Activity**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | Activity was not found. |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="activityidentifierssnapshot"></a>
# **ActivityIdentifiersSnapshot**
> FlattenedActivities ActivityIdentifiersSnapshot (bool? pseudo = null, string activityFilterEnum = null)

/activity/identifiers [GET]

This is going to return all the identifiers of the activity event in order of most recent -> oldest.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ActivityIdentifiersSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ActivityApi(config);
            var pseudo = true;  // bool? | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. (optional) 
            var activityFilterEnum = "CREATED";  // string | This is an ActivityFilterEnum as a optional filter. Ensure you update ActivityFilterEnum if this is updated. (optional) 

            try
            {
                // /activity/identifiers [GET]
                FlattenedActivities result = apiInstance.ActivityIdentifiersSnapshot(pseudo, activityFilterEnum);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityIdentifiersSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivityIdentifiersSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /activity/identifiers [GET]
    ApiResponse<FlattenedActivities> response = apiInstance.ActivityIdentifiersSnapshotWithHttpInfo(pseudo, activityFilterEnum);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivityApi.ActivityIdentifiersSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pseudo** | **bool?** | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. | [optional]  |
| **activityFilterEnum** | **string** | This is an ActivityFilterEnum as a optional filter. Ensure you update ActivityFilterEnum if this is updated. | [optional]  |

### Return type

[**FlattenedActivities**](FlattenedActivities.md)

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

<a id="activityupdate"></a>
# **ActivityUpdate**
> Activity ActivityUpdate (bool? transferables = null, Activity activity = null)

/activity/update [POST]

this will update a specific activity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ActivityUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ActivityApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var activity = new Activity(); // Activity |  (optional) 

            try
            {
                // /activity/update [POST]
                Activity result = apiInstance.ActivityUpdate(transferables, activity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivityUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /activity/update [POST]
    ApiResponse<Activity> response = apiInstance.ActivityUpdateWithHttpInfo(transferables, activity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivityApi.ActivityUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **activity** | [**Activity**](Activity.md) |  | [optional]  |

### Return type

[**Activity**](Activity.md)

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

