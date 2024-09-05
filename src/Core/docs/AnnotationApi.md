# Pieces.Os.Core.Api.AnnotationApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AnnotationScoresIncrement**](AnnotationApi.md#annotationscoresincrement) | **POST** /annotation/{annotation}/scores/increment | &#39;/annotation/{annotation}/scores/increment&#39; [POST] |
| [**AnnotationSpecificAnnotationSnapshot**](AnnotationApi.md#annotationspecificannotationsnapshot) | **GET** /annotation/{annotation} | /annotation/{annotation} [GET] |
| [**AnnotationUpdate**](AnnotationApi.md#annotationupdate) | **POST** /annotation/update | /annotation/update [POST] |

<a id="annotationscoresincrement"></a>
# **AnnotationScoresIncrement**
> void AnnotationScoresIncrement (string annotation, SeededScoreIncrement seededScoreIncrement = null)

'/annotation/{annotation}/scores/increment' [POST]

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
    public class AnnotationScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnnotationApi(config);
            var annotation = "annotation_example";  // string | This is a specific annotation uuid.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/annotation/{annotation}/scores/increment' [POST]
                apiInstance.AnnotationScoresIncrement(annotation, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationApi.AnnotationScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnnotationScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/annotation/{annotation}/scores/increment' [POST]
    apiInstance.AnnotationScoresIncrementWithHttpInfo(annotation, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnnotationApi.AnnotationScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **annotation** | **string** | This is a specific annotation uuid. |  |
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

<a id="annotationspecificannotationsnapshot"></a>
# **AnnotationSpecificAnnotationSnapshot**
> Annotation AnnotationSpecificAnnotationSnapshot (string annotation)

/annotation/{annotation} [GET]

This will get a snapshot of a specific annotation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnnotationSpecificAnnotationSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnnotationApi(config);
            var annotation = "annotation_example";  // string | This is a specific annotation uuid.

            try
            {
                // /annotation/{annotation} [GET]
                Annotation result = apiInstance.AnnotationSpecificAnnotationSnapshot(annotation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationApi.AnnotationSpecificAnnotationSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnnotationSpecificAnnotationSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /annotation/{annotation} [GET]
    ApiResponse<Annotation> response = apiInstance.AnnotationSpecificAnnotationSnapshotWithHttpInfo(annotation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnnotationApi.AnnotationSpecificAnnotationSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **annotation** | **string** | This is a specific annotation uuid. |  |

### Return type

[**Annotation**](Annotation.md)

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

<a id="annotationupdate"></a>
# **AnnotationUpdate**
> Annotation AnnotationUpdate (Annotation annotation = null)

/annotation/update [POST]

This will update a specific annotation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnnotationUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnnotationApi(config);
            var annotation = new Annotation(); // Annotation |  (optional) 

            try
            {
                // /annotation/update [POST]
                Annotation result = apiInstance.AnnotationUpdate(annotation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationApi.AnnotationUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnnotationUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /annotation/update [POST]
    ApiResponse<Annotation> response = apiInstance.AnnotationUpdateWithHttpInfo(annotation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnnotationApi.AnnotationUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **annotation** | [**Annotation**](Annotation.md) |  | [optional]  |

### Return type

[**Annotation**](Annotation.md)

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

