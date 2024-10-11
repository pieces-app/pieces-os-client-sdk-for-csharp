# Pieces.Os.Core.Api.FormatApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FormatAnalysis**](FormatApi.md#formatanalysis) | **GET** /format/{format}/analysis | /format/{format}/analysis [GET] |
| [**FormatReclassify**](FormatApi.md#formatreclassify) | **POST** /format/reclassify | /format/reclassify [POST] |
| [**FormatSnapshot**](FormatApi.md#formatsnapshot) | **GET** /format/{format} | /format/{format} [GET] Scoped to Format |
| [**FormatUpdateValue**](FormatApi.md#formatupdatevalue) | **POST** /format/update/value | [POST] /format/update/value |

<a id="formatanalysis"></a>
# **FormatAnalysis**
> Analysis FormatAnalysis (Guid format)

/format/{format}/analysis [GET]

This will get an analysis from a format's id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class FormatAnalysisExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new FormatApi(config);
            var format = 102ff265-fdfb-4142-8d94-4932d400199c;  // Guid | The id (uuid) for a specific format.

            try
            {
                // /format/{format}/analysis [GET]
                Analysis result = apiInstance.FormatAnalysis(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormatApi.FormatAnalysis: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FormatAnalysisWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /format/{format}/analysis [GET]
    ApiResponse<Analysis> response = apiInstance.FormatAnalysisWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FormatApi.FormatAnalysisWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **Guid** | The id (uuid) for a specific format. |  |

### Return type

[**Analysis**](Analysis.md)

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

<a id="formatreclassify"></a>
# **FormatReclassify**
> Format FormatReclassify (bool? transferable = null, FormatReclassification formatReclassification = null)

/format/reclassify [POST]

This endpoint will be used to reclassify a single Format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class FormatReclassifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new FormatApi(config);
            var transferable = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var formatReclassification = new FormatReclassification(); // FormatReclassification |  (optional) 

            try
            {
                // /format/reclassify [POST]
                Format result = apiInstance.FormatReclassify(transferable, formatReclassification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormatApi.FormatReclassify: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FormatReclassifyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /format/reclassify [POST]
    ApiResponse<Format> response = apiInstance.FormatReclassifyWithHttpInfo(transferable, formatReclassification);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FormatApi.FormatReclassifyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferable** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **formatReclassification** | [**FormatReclassification**](FormatReclassification.md) |  | [optional]  |

### Return type

[**Format**](Format.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="formatsnapshot"></a>
# **FormatSnapshot**
> Format FormatSnapshot (Guid format, bool? transferable = null)

/format/{format} [GET] Scoped to Format

Get a snapshot of a specific format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class FormatSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new FormatApi(config);
            var format = 102ff265-fdfb-4142-8d94-4932d400199c;  // Guid | The id (uuid) for a specific format.
            var transferable = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /format/{format} [GET] Scoped to Format
                Format result = apiInstance.FormatSnapshot(format, transferable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormatApi.FormatSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FormatSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /format/{format} [GET] Scoped to Format
    ApiResponse<Format> response = apiInstance.FormatSnapshotWithHttpInfo(format, transferable);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FormatApi.FormatSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **Guid** | The id (uuid) for a specific format. |  |
| **transferable** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Format**](Format.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="formatupdatevalue"></a>
# **FormatUpdateValue**
> Format FormatUpdateValue (bool? transferable = null, Format format = null)

[POST] /format/update/value

This will update a format's value, ie, a formats fragment or file depending on what is provided.  code/text fragment behavior: If this format is an asset.preview.base we will update the asset.original's value. if this format is an asset.preview.original we will update the asset.preview.base's value.  code/text file behavior: If the the format that is update is the asset.preview.base is a fragment and the asset.original is file then we will update the asset.original's value to be bytes or string respectively. This goes the same for orignal to preview but will be go the reverse order so if the original is a file we will update the preview base's fragment string.  image fragment/file: We will not modify preview -> orignal or original -> preview here. so there are zero side effects in this case, and will update as normal. (this will be the case for all other value updates.)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class FormatUpdateValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new FormatApi(config);
            var transferable = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var format = new Format(); // Format | This is the format that you want to update. (optional) 

            try
            {
                // [POST] /format/update/value
                Format result = apiInstance.FormatUpdateValue(transferable, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormatApi.FormatUpdateValue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FormatUpdateValueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [POST] /format/update/value
    ApiResponse<Format> response = apiInstance.FormatUpdateValueWithHttpInfo(transferable, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FormatApi.FormatUpdateValueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferable** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **format** | [**Format**](Format.md) | This is the format that you want to update. | [optional]  |

### Return type

[**Format**](Format.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK, you will get an updated format. |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

