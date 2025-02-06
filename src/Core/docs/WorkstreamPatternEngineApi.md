# Pieces.Os.Core.Api.WorkstreamPatternEngineApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkstreamPatternEngineCreateIngestion**](WorkstreamPatternEngineApi.md#workstreampatternenginecreateingestion) | **POST** /workstream_pattern_engine/ingestions/create | /workstream_pattern_engine/ingestions/create [POST] |
| [**WorkstreamPatternEngineProcessorsSources**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorssources) | **GET** /workstream_pattern_engine/processors/sources | /workstream_pattern_engine/processors/sources [GET] |
| [**WorkstreamPatternEngineProcessorsVisionActivate**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisionactivate) | **POST** /workstream_pattern_engine/processors/vision/activate | /workstream_pattern_engine/processors/vision/activate [POST] |
| [**WorkstreamPatternEngineProcessorsVisionCalibrationCapture**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisioncalibrationcapture) | **POST** /workstream_pattern_engine/processors/vision/calibration/capture | /workstream_pattern_engine/processors/vision/calibration/capture [POST] |
| [**WorkstreamPatternEngineProcessorsVisionCalibrationsFocused**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisioncalibrationsfocused) | **GET** /workstream_pattern_engine/processors/vision/calibrations/focused | /workstream_pattern_engine/processors/vision/calibrations/focused [GET] |
| [**WorkstreamPatternEngineProcessorsVisionCalibrationsSnapshot**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisioncalibrationssnapshot) | **GET** /workstream_pattern_engine/processors/vision/calibrations | /workstream_pattern_engine/processors/vision/calibrations [GET] |
| [**WorkstreamPatternEngineProcessorsVisionDataClear**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisiondataclear) | **POST** /workstream_pattern_engine/processors/vision/data/clear | /workstream_pattern_engine/processors/vision/data/clear [POST] |
| [**WorkstreamPatternEngineProcessorsVisionDeactivate**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisiondeactivate) | **POST** /workstream_pattern_engine/processors/vision/deactivate | /workstream_pattern_engine/processors/vision/deactivate [POST] |
| [**WorkstreamPatternEngineProcessorsVisionEventDeleteSpecificVisionEvent**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisioneventdeletespecificvisionevent) | **POST** /workstream_pattern_engine/processors/vision/data/events/{vision_event}/delete | /workstream_pattern_engine/processors/vision/events/{vision_event}/delete [POST] |
| [**WorkstreamPatternEngineProcessorsVisionEventsScopedDelete**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisioneventsscopeddelete) | **POST** /workstream_pattern_engine/processors/vision/data/events/scoped_delete | /workstream_pattern_engine/processors/vision/events/scoped_delete [POST] |
| [**WorkstreamPatternEngineProcessorsVisionEventsSearch**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisioneventssearch) | **POST** /workstream_pattern_engine/processors/vision/data/events/search | /workstream_pattern_engine/processors/vision/data/events/search [POST] |
| [**WorkstreamPatternEngineProcessorsVisionEventsSnapshot**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisioneventssnapshot) | **GET** /workstream_pattern_engine/processors/vision/data/events | /workstream_pattern_engine/processors/vision/data/events [GET] |
| [**WorkstreamPatternEngineProcessorsVisionEventsSpecificSnapshot**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisioneventsspecificsnapshot) | **GET** /workstream_pattern_engine/processors/vision/data/events/{vision_event} | /workstream_pattern_engine/processors/vision/data/events/{vision_event} [GET] |
| [**WorkstreamPatternEngineProcessorsVisionMetadata**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisionmetadata) | **GET** /workstream_pattern_engine/processors/vision/metadata | /workstream_pattern_engine/processors/vision/metadata [GET] |
| [**WorkstreamPatternEngineProcessorsVisionStatus**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisionstatus) | **GET** /workstream_pattern_engine/processors/vision/status | /workstream_pattern_engine/processors/vision/status [GET] |
| [**WorkstreamPatternEngineProcessorsVisionStatusStream**](WorkstreamPatternEngineApi.md#workstreampatternengineprocessorsvisionstatusstream) | **GET** /workstream_pattern_engine/processors/vision/status/stream | /workstream_pattern_engine/processors/vision/status/stream [WS] |

<a id="workstreampatternenginecreateingestion"></a>
# **WorkstreamPatternEngineCreateIngestion**
> WorkstreamIngestion WorkstreamPatternEngineCreateIngestion (SeededWorkstreamIngestion seededWorkstreamIngestion = null)

/workstream_pattern_engine/ingestions/create [POST]

This will take in events from plugins that will be used to drive data to be displayed in the feed.  This is not guaranteed to display information that is taken into this endpoint in the feed.  We take a subset of the information provided in this endpoint + information from the WPE to curated a highly relevant Heads up display of useful materials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineCreateIngestionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);
            var seededWorkstreamIngestion = new SeededWorkstreamIngestion(); // SeededWorkstreamIngestion |  (optional) 

            try
            {
                // /workstream_pattern_engine/ingestions/create [POST]
                WorkstreamIngestion result = apiInstance.WorkstreamPatternEngineCreateIngestion(seededWorkstreamIngestion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineCreateIngestion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineCreateIngestionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/ingestions/create [POST]
    ApiResponse<WorkstreamIngestion> response = apiInstance.WorkstreamPatternEngineCreateIngestionWithHttpInfo(seededWorkstreamIngestion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineCreateIngestionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededWorkstreamIngestion** | [**SeededWorkstreamIngestion**](SeededWorkstreamIngestion.md) |  | [optional]  |

### Return type

[**WorkstreamIngestion**](WorkstreamIngestion.md)

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

<a id="workstreampatternengineprocessorssources"></a>
# **WorkstreamPatternEngineProcessorsSources**
> WorkstreamPatternEngineSources WorkstreamPatternEngineProcessorsSources ()

/workstream_pattern_engine/processors/sources [GET]

This will return all of the applications(focused windows) that have events saved within WPE qdrant collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);

            try
            {
                // /workstream_pattern_engine/processors/sources [GET]
                WorkstreamPatternEngineSources result = apiInstance.WorkstreamPatternEngineProcessorsSources();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/sources [GET]
    ApiResponse<WorkstreamPatternEngineSources> response = apiInstance.WorkstreamPatternEngineProcessorsSourcesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkstreamPatternEngineSources**](WorkstreamPatternEngineSources.md)

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

<a id="workstreampatternengineprocessorsvisionactivate"></a>
# **WorkstreamPatternEngineProcessorsVisionActivate**
> WorkstreamPatternEngineStatus WorkstreamPatternEngineProcessorsVisionActivate (WorkstreamPatternEngineStatus workstreamPatternEngineStatus = null)

/workstream_pattern_engine/processors/vision/activate [POST]

This will activate your Workstream Pattern Engine. This is used to aggregate information on your user's desktop, specifically recording the application in focus and aggregating relevant context that will then be used to ground the copilot conversations, as well as the feed.  Note: required to be a beta user to use this feature until this is live(roughly mid to late April)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionActivateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);
            var workstreamPatternEngineStatus = new WorkstreamPatternEngineStatus(); // WorkstreamPatternEngineStatus |  (optional) 

            try
            {
                // /workstream_pattern_engine/processors/vision/activate [POST]
                WorkstreamPatternEngineStatus result = apiInstance.WorkstreamPatternEngineProcessorsVisionActivate(workstreamPatternEngineStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionActivate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionActivateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/activate [POST]
    ApiResponse<WorkstreamPatternEngineStatus> response = apiInstance.WorkstreamPatternEngineProcessorsVisionActivateWithHttpInfo(workstreamPatternEngineStatus);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionActivateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamPatternEngineStatus** | [**WorkstreamPatternEngineStatus**](WorkstreamPatternEngineStatus.md) |  | [optional]  |

### Return type

[**WorkstreamPatternEngineStatus**](WorkstreamPatternEngineStatus.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden, this is not available for non-beta used until mid to late April. |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workstreampatternengineprocessorsvisioncalibrationcapture"></a>
# **WorkstreamPatternEngineProcessorsVisionCalibrationCapture**
> WorkstreamPatternEngineVisionCalibration WorkstreamPatternEngineProcessorsVisionCalibrationCapture ()

/workstream_pattern_engine/processors/vision/calibration/capture [POST]

This will attempt to capture the copilot/feed/xyz dimensions of current focused window  note: in the future we can make a differentiation of the dimensions based on the type of qrCode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionCalibrationCaptureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);

            try
            {
                // /workstream_pattern_engine/processors/vision/calibration/capture [POST]
                WorkstreamPatternEngineVisionCalibration result = apiInstance.WorkstreamPatternEngineProcessorsVisionCalibrationCapture();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionCalibrationCapture: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionCalibrationCaptureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/calibration/capture [POST]
    ApiResponse<WorkstreamPatternEngineVisionCalibration> response = apiInstance.WorkstreamPatternEngineProcessorsVisionCalibrationCaptureWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionCalibrationCaptureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkstreamPatternEngineVisionCalibration**](WorkstreamPatternEngineVisionCalibration.md)

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

<a id="workstreampatternengineprocessorsvisioncalibrationsfocused"></a>
# **WorkstreamPatternEngineProcessorsVisionCalibrationsFocused**
> WorkstreamPatternEngineVisionCalibration WorkstreamPatternEngineProcessorsVisionCalibrationsFocused ()

/workstream_pattern_engine/processors/vision/calibrations/focused [GET]

This will get the copilot/feed/xyz dimensions of the focused window.  This endpoint will attempt to do the following: 1. get the focus window 2. we will do a lookup to see if we have the copilot/feed/xyz dimension for this window if not we will return null if so we will return the dimensions as well as when the dimensions were taken  note: in the future we can make a differentiation of the dimensions based on the type of qrCode. note: no need to pass in the window name: b/c we will just get the focused window note: we will also return the window name in the returnable so the dev can verify this is the window of the plugin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionCalibrationsFocusedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);

            try
            {
                // /workstream_pattern_engine/processors/vision/calibrations/focused [GET]
                WorkstreamPatternEngineVisionCalibration result = apiInstance.WorkstreamPatternEngineProcessorsVisionCalibrationsFocused();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionCalibrationsFocused: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionCalibrationsFocusedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/calibrations/focused [GET]
    ApiResponse<WorkstreamPatternEngineVisionCalibration> response = apiInstance.WorkstreamPatternEngineProcessorsVisionCalibrationsFocusedWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionCalibrationsFocusedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkstreamPatternEngineVisionCalibration**](WorkstreamPatternEngineVisionCalibration.md)

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

<a id="workstreampatternengineprocessorsvisioncalibrationssnapshot"></a>
# **WorkstreamPatternEngineProcessorsVisionCalibrationsSnapshot**
> WorkstreamPatternEngineVisionCalibrations WorkstreamPatternEngineProcessorsVisionCalibrationsSnapshot ()

/workstream_pattern_engine/processors/vision/calibrations [GET]

This will return a snapshot of all of our captured copilot window Dimensions   note: this will return many captures note: will want to add type of calibration for this specific dimension(ie copilot/feed/xyz) note: in the future we can make a differentiation of the dimensions based on the type of qrCode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionCalibrationsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);

            try
            {
                // /workstream_pattern_engine/processors/vision/calibrations [GET]
                WorkstreamPatternEngineVisionCalibrations result = apiInstance.WorkstreamPatternEngineProcessorsVisionCalibrationsSnapshot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionCalibrationsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionCalibrationsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/calibrations [GET]
    ApiResponse<WorkstreamPatternEngineVisionCalibrations> response = apiInstance.WorkstreamPatternEngineProcessorsVisionCalibrationsSnapshotWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionCalibrationsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkstreamPatternEngineVisionCalibrations**](WorkstreamPatternEngineVisionCalibrations.md)

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

<a id="workstreampatternengineprocessorsvisiondataclear"></a>
# **WorkstreamPatternEngineProcessorsVisionDataClear**
> void WorkstreamPatternEngineProcessorsVisionDataClear (WorkstreamPatternEngineDataCleanupRequest workstreamPatternEngineDataCleanupRequest = null)

/workstream_pattern_engine/processors/vision/data/clear [POST]

This will clear the data for the Workstream Pattern Engine, specifically for our vision data.  This boy will accept ranges of time that the user wants to remove the processing from.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionDataClearExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);
            var workstreamPatternEngineDataCleanupRequest = new WorkstreamPatternEngineDataCleanupRequest(); // WorkstreamPatternEngineDataCleanupRequest |  (optional) 

            try
            {
                // /workstream_pattern_engine/processors/vision/data/clear [POST]
                apiInstance.WorkstreamPatternEngineProcessorsVisionDataClear(workstreamPatternEngineDataCleanupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionDataClear: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionDataClearWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/data/clear [POST]
    apiInstance.WorkstreamPatternEngineProcessorsVisionDataClearWithHttpInfo(workstreamPatternEngineDataCleanupRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionDataClearWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamPatternEngineDataCleanupRequest** | [**WorkstreamPatternEngineDataCleanupRequest**](WorkstreamPatternEngineDataCleanupRequest.md) |  | [optional]  |

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
| **403** | Forbidden, this is not available for non-beta used until mid to late April. |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workstreampatternengineprocessorsvisiondeactivate"></a>
# **WorkstreamPatternEngineProcessorsVisionDeactivate**
> WorkstreamPatternEngineStatus WorkstreamPatternEngineProcessorsVisionDeactivate (WorkstreamPatternEngineStatus workstreamPatternEngineStatus = null)

/workstream_pattern_engine/processors/vision/deactivate [POST]

This will deactivate your Workstream Pattern Engine. This is used to aggregate information on your user's desktop, specifically recording the application in focus and aggregating relevant context that will then be used to ground the copilot conversations, as well as the feed.  Note: required to be a beta user to use this feature until this is live(roughly mid to late April)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionDeactivateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);
            var workstreamPatternEngineStatus = new WorkstreamPatternEngineStatus(); // WorkstreamPatternEngineStatus |  (optional) 

            try
            {
                // /workstream_pattern_engine/processors/vision/deactivate [POST]
                WorkstreamPatternEngineStatus result = apiInstance.WorkstreamPatternEngineProcessorsVisionDeactivate(workstreamPatternEngineStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionDeactivate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionDeactivateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/deactivate [POST]
    ApiResponse<WorkstreamPatternEngineStatus> response = apiInstance.WorkstreamPatternEngineProcessorsVisionDeactivateWithHttpInfo(workstreamPatternEngineStatus);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionDeactivateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamPatternEngineStatus** | [**WorkstreamPatternEngineStatus**](WorkstreamPatternEngineStatus.md) |  | [optional]  |

### Return type

[**WorkstreamPatternEngineStatus**](WorkstreamPatternEngineStatus.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden, this is not available for non-beta used until mid to late April. |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workstreampatternengineprocessorsvisioneventdeletespecificvisionevent"></a>
# **WorkstreamPatternEngineProcessorsVisionEventDeleteSpecificVisionEvent**
> void WorkstreamPatternEngineProcessorsVisionEventDeleteSpecificVisionEvent (string visionEvent)

/workstream_pattern_engine/processors/vision/events/{vision_event}/delete [POST]

This will delete a single event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionEventDeleteSpecificVisionEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);
            var visionEvent = "visionEvent_example";  // string | This is a identifier that is used to identify a specific WPE_vision event.

            try
            {
                // /workstream_pattern_engine/processors/vision/events/{vision_event}/delete [POST]
                apiInstance.WorkstreamPatternEngineProcessorsVisionEventDeleteSpecificVisionEvent(visionEvent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionEventDeleteSpecificVisionEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionEventDeleteSpecificVisionEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/events/{vision_event}/delete [POST]
    apiInstance.WorkstreamPatternEngineProcessorsVisionEventDeleteSpecificVisionEventWithHttpInfo(visionEvent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionEventDeleteSpecificVisionEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visionEvent** | **string** | This is a identifier that is used to identify a specific WPE_vision event. |  |

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

<a id="workstreampatternengineprocessorsvisioneventsscopeddelete"></a>
# **WorkstreamPatternEngineProcessorsVisionEventsScopedDelete**
> FlattenedWorkstreamPatternEngineVisionEvents WorkstreamPatternEngineProcessorsVisionEventsScopedDelete (WorkstreamPatternEngineVisionEventDeletions workstreamPatternEngineVisionEventDeletions = null)

/workstream_pattern_engine/processors/vision/events/scoped_delete [POST]

This will remove the UUIDs that were removed from the qdrant event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionEventsScopedDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);
            var workstreamPatternEngineVisionEventDeletions = new WorkstreamPatternEngineVisionEventDeletions(); // WorkstreamPatternEngineVisionEventDeletions |  (optional) 

            try
            {
                // /workstream_pattern_engine/processors/vision/events/scoped_delete [POST]
                FlattenedWorkstreamPatternEngineVisionEvents result = apiInstance.WorkstreamPatternEngineProcessorsVisionEventsScopedDelete(workstreamPatternEngineVisionEventDeletions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionEventsScopedDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionEventsScopedDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/events/scoped_delete [POST]
    ApiResponse<FlattenedWorkstreamPatternEngineVisionEvents> response = apiInstance.WorkstreamPatternEngineProcessorsVisionEventsScopedDeleteWithHttpInfo(workstreamPatternEngineVisionEventDeletions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionEventsScopedDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamPatternEngineVisionEventDeletions** | [**WorkstreamPatternEngineVisionEventDeletions**](WorkstreamPatternEngineVisionEventDeletions.md) |  | [optional]  |

### Return type

[**FlattenedWorkstreamPatternEngineVisionEvents**](FlattenedWorkstreamPatternEngineVisionEvents.md)

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

<a id="workstreampatternengineprocessorsvisioneventssearch"></a>
# **WorkstreamPatternEngineProcessorsVisionEventsSearch**
> SearchedWorkstreamPatternEngineVisionEvents WorkstreamPatternEngineProcessorsVisionEventsSearch (bool? transferables = null, SearchInput searchInput = null)

/workstream_pattern_engine/processors/vision/data/events/search [POST]

This will search your WPE events and will return a list of events that match the query/timestamp range/list of applications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionEventsSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var searchInput = new SearchInput(); // SearchInput |  (optional) 

            try
            {
                // /workstream_pattern_engine/processors/vision/data/events/search [POST]
                SearchedWorkstreamPatternEngineVisionEvents result = apiInstance.WorkstreamPatternEngineProcessorsVisionEventsSearch(transferables, searchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionEventsSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionEventsSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/data/events/search [POST]
    ApiResponse<SearchedWorkstreamPatternEngineVisionEvents> response = apiInstance.WorkstreamPatternEngineProcessorsVisionEventsSearchWithHttpInfo(transferables, searchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionEventsSearchWithHttpInfo: " + e.Message);
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

[**SearchedWorkstreamPatternEngineVisionEvents**](SearchedWorkstreamPatternEngineVisionEvents.md)

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

<a id="workstreampatternengineprocessorsvisioneventssnapshot"></a>
# **WorkstreamPatternEngineProcessorsVisionEventsSnapshot**
> WorkstreamPatternEngineVisionEvents WorkstreamPatternEngineProcessorsVisionEventsSnapshot (bool? transferables = null)

/workstream_pattern_engine/processors/vision/data/events [GET]

This will return a snapshot of all of the WPE qdrant events  note: if the transferables: are true then we will provide values for each of our events otherwise       we will just provide basic metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionEventsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /workstream_pattern_engine/processors/vision/data/events [GET]
                WorkstreamPatternEngineVisionEvents result = apiInstance.WorkstreamPatternEngineProcessorsVisionEventsSnapshot(transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionEventsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionEventsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/data/events [GET]
    ApiResponse<WorkstreamPatternEngineVisionEvents> response = apiInstance.WorkstreamPatternEngineProcessorsVisionEventsSnapshotWithHttpInfo(transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionEventsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**WorkstreamPatternEngineVisionEvents**](WorkstreamPatternEngineVisionEvents.md)

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

<a id="workstreampatternengineprocessorsvisioneventsspecificsnapshot"></a>
# **WorkstreamPatternEngineProcessorsVisionEventsSpecificSnapshot**
> WorkstreamPatternEngineVisionEvent WorkstreamPatternEngineProcessorsVisionEventsSpecificSnapshot (string visionEvent, bool? transferables = null)

/workstream_pattern_engine/processors/vision/data/events/{vision_event} [GET]

This will return a specific event from the WPE.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionEventsSpecificSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);
            var visionEvent = "visionEvent_example";  // string | This is a identifier that is used to identify a specific WPE_vision event.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /workstream_pattern_engine/processors/vision/data/events/{vision_event} [GET]
                WorkstreamPatternEngineVisionEvent result = apiInstance.WorkstreamPatternEngineProcessorsVisionEventsSpecificSnapshot(visionEvent, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionEventsSpecificSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionEventsSpecificSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/data/events/{vision_event} [GET]
    ApiResponse<WorkstreamPatternEngineVisionEvent> response = apiInstance.WorkstreamPatternEngineProcessorsVisionEventsSpecificSnapshotWithHttpInfo(visionEvent, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionEventsSpecificSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visionEvent** | **string** | This is a identifier that is used to identify a specific WPE_vision event. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**WorkstreamPatternEngineVisionEvent**](WorkstreamPatternEngineVisionEvent.md)

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

<a id="workstreampatternengineprocessorsvisionmetadata"></a>
# **WorkstreamPatternEngineProcessorsVisionMetadata**
> WorkstreamPatternEngineVisionMetadata WorkstreamPatternEngineProcessorsVisionMetadata ()

/workstream_pattern_engine/processors/vision/metadata [GET]

This is an endpoint that will return the metadata of the vision data (WPE qdrant size)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);

            try
            {
                // /workstream_pattern_engine/processors/vision/metadata [GET]
                WorkstreamPatternEngineVisionMetadata result = apiInstance.WorkstreamPatternEngineProcessorsVisionMetadata();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/metadata [GET]
    ApiResponse<WorkstreamPatternEngineVisionMetadata> response = apiInstance.WorkstreamPatternEngineProcessorsVisionMetadataWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkstreamPatternEngineVisionMetadata**](WorkstreamPatternEngineVisionMetadata.md)

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

<a id="workstreampatternengineprocessorsvisionstatus"></a>
# **WorkstreamPatternEngineProcessorsVisionStatus**
> WorkstreamPatternEngineStatus WorkstreamPatternEngineProcessorsVisionStatus ()

/workstream_pattern_engine/processors/vision/status [GET]

This will get a snapshot of the status your Workstream Pattern Engine. This is used to aggregate information on your user's desktop, specifically recording the application in focus and aggregating relevant context that will then be used to ground the copilot conversations, as well as the feed.  Note: required to be a beta user to use this feature until this is live(roughly mid to late April)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);

            try
            {
                // /workstream_pattern_engine/processors/vision/status [GET]
                WorkstreamPatternEngineStatus result = apiInstance.WorkstreamPatternEngineProcessorsVisionStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/status [GET]
    ApiResponse<WorkstreamPatternEngineStatus> response = apiInstance.WorkstreamPatternEngineProcessorsVisionStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkstreamPatternEngineStatus**](WorkstreamPatternEngineStatus.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden, this is not available for non-beta used until mid to late April. |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workstreampatternengineprocessorsvisionstatusstream"></a>
# **WorkstreamPatternEngineProcessorsVisionStatusStream**
> WorkstreamPatternEngineStatus WorkstreamPatternEngineProcessorsVisionStatusStream ()

/workstream_pattern_engine/processors/vision/status/stream [WS]

This is a websocket for the status of the workstream pattern engine for vision.  This will emit an event when this is first connected to, and will emit an event when every this value changes  This will emit a \"WorkstreamPatternEngineStatus\" Model.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamPatternEngineProcessorsVisionStatusStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamPatternEngineApi(config);

            try
            {
                // /workstream_pattern_engine/processors/vision/status/stream [WS]
                WorkstreamPatternEngineStatus result = apiInstance.WorkstreamPatternEngineProcessorsVisionStatusStream();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionStatusStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamPatternEngineProcessorsVisionStatusStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_pattern_engine/processors/vision/status/stream [WS]
    ApiResponse<WorkstreamPatternEngineStatus> response = apiInstance.WorkstreamPatternEngineProcessorsVisionStatusStreamWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamPatternEngineApi.WorkstreamPatternEngineProcessorsVisionStatusStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkstreamPatternEngineStatus**](WorkstreamPatternEngineStatus.md)

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

