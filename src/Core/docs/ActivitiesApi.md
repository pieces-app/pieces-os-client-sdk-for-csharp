# Pieces.Os.Core.Api.ActivitiesApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivitiesCreateNewActivity**](ActivitiesApi.md#activitiescreatenewactivity) | **POST** /activities/create | /activities/create [POST] |
| [**ActivitiesDeleteSpecificActivity**](ActivitiesApi.md#activitiesdeletespecificactivity) | **POST** /activities/{activity}/delete | /activities/{activity}/delete [POST] |
| [**ActivitiesSnapshot**](ActivitiesApi.md#activitiessnapshot) | **GET** /activities | /activities [GET] |
| [**ActivitiesStreamIdentifiers**](ActivitiesApi.md#activitiesstreamidentifiers) | **GET** /activities/stream/identifiers | /activities/stream/identifiers [WS] |

<a id="activitiescreatenewactivity"></a>
# **ActivitiesCreateNewActivity**
> Activity ActivitiesCreateNewActivity (bool? transferables = null, SeededActivity seededActivity = null)

/activities/create [POST]

This will create a new Activity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ActivitiesCreateNewActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ActivitiesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seededActivity = new SeededActivity(); // SeededActivity |  (optional) 

            try
            {
                // /activities/create [POST]
                Activity result = apiInstance.ActivitiesCreateNewActivity(transferables, seededActivity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivitiesApi.ActivitiesCreateNewActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivitiesCreateNewActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /activities/create [POST]
    ApiResponse<Activity> response = apiInstance.ActivitiesCreateNewActivityWithHttpInfo(transferables, seededActivity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivitiesApi.ActivitiesCreateNewActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seededActivity** | [**SeededActivity**](SeededActivity.md) |  | [optional]  |

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

<a id="activitiesdeletespecificactivity"></a>
# **ActivitiesDeleteSpecificActivity**
> void ActivitiesDeleteSpecificActivity (string activity)

/activities/{activity}/delete [POST]

This will delete a specific activity.  important note: if we delete an activity: that is going to be a generic or a specific/ we will also delete its counter part i.e the specific. and vise versa, this ensures that the references are always cleaned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ActivitiesDeleteSpecificActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ActivitiesApi(config);
            var activity = "activity_example";  // string | This is a specific activity uuid.

            try
            {
                // /activities/{activity}/delete [POST]
                apiInstance.ActivitiesDeleteSpecificActivity(activity);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivitiesApi.ActivitiesDeleteSpecificActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivitiesDeleteSpecificActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /activities/{activity}/delete [POST]
    apiInstance.ActivitiesDeleteSpecificActivityWithHttpInfo(activity);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivitiesApi.ActivitiesDeleteSpecificActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activity** | **string** | This is a specific activity uuid. |  |

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

<a id="activitiessnapshot"></a>
# **ActivitiesSnapshot**
> Activities ActivitiesSnapshot (bool? transferables = null, bool? pseudo = null)

/activities [GET]

This will get a snapshot of all of the activities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ActivitiesSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ActivitiesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var pseudo = true;  // bool? | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. (optional) 

            try
            {
                // /activities [GET]
                Activities result = apiInstance.ActivitiesSnapshot(transferables, pseudo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivitiesApi.ActivitiesSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivitiesSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /activities [GET]
    ApiResponse<Activities> response = apiInstance.ActivitiesSnapshotWithHttpInfo(transferables, pseudo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivitiesApi.ActivitiesSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **pseudo** | **bool?** | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. | [optional]  |

### Return type

[**Activities**](Activities.md)

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

<a id="activitiesstreamidentifiers"></a>
# **ActivitiesStreamIdentifiers**
> StreamedIdentifiers ActivitiesStreamIdentifiers ()

/activities/stream/identifiers [WS]

Provides a WebSocket connection that emits changes to your activity identifiers (UUIDs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ActivitiesStreamIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ActivitiesApi(config);

            try
            {
                // /activities/stream/identifiers [WS]
                StreamedIdentifiers result = apiInstance.ActivitiesStreamIdentifiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivitiesApi.ActivitiesStreamIdentifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivitiesStreamIdentifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /activities/stream/identifiers [WS]
    ApiResponse<StreamedIdentifiers> response = apiInstance.ActivitiesStreamIdentifiersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivitiesApi.ActivitiesStreamIdentifiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**StreamedIdentifiers**](StreamedIdentifiers.md)

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

