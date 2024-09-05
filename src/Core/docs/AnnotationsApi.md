# Pieces.Os.Core.Api.AnnotationsApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AnnotationsCreateNewAnnotation**](AnnotationsApi.md#annotationscreatenewannotation) | **POST** /annotations/create | /annotations/create [POST] |
| [**AnnotationsDeleteSpecificAnnotation**](AnnotationsApi.md#annotationsdeletespecificannotation) | **POST** /annotations/{annotation}/delete | /annotations/{annotation}/delete [POST] |
| [**AnnotationsSnapshot**](AnnotationsApi.md#annotationssnapshot) | **GET** /annotations | /annotations [GET] |
| [**AnnotationsStreamIdentifiers**](AnnotationsApi.md#annotationsstreamidentifiers) | **GET** /annotations/stream/identifiers | /annotations/stream/identifiers [WS] |
| [**SearchAnnotations**](AnnotationsApi.md#searchannotations) | **POST** /annotations/search | /annotations/search [POST] |

<a id="annotationscreatenewannotation"></a>
# **AnnotationsCreateNewAnnotation**
> Annotation AnnotationsCreateNewAnnotation (SeededAnnotation seededAnnotation = null)

/annotations/create [POST]

This will create an annotation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnnotationsCreateNewAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnnotationsApi(config);
            var seededAnnotation = new SeededAnnotation(); // SeededAnnotation |  (optional) 

            try
            {
                // /annotations/create [POST]
                Annotation result = apiInstance.AnnotationsCreateNewAnnotation(seededAnnotation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationsApi.AnnotationsCreateNewAnnotation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnnotationsCreateNewAnnotationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /annotations/create [POST]
    ApiResponse<Annotation> response = apiInstance.AnnotationsCreateNewAnnotationWithHttpInfo(seededAnnotation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnnotationsApi.AnnotationsCreateNewAnnotationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededAnnotation** | [**SeededAnnotation**](SeededAnnotation.md) |  | [optional]  |

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

<a id="annotationsdeletespecificannotation"></a>
# **AnnotationsDeleteSpecificAnnotation**
> void AnnotationsDeleteSpecificAnnotation (string annotation)

/annotations/{annotation}/delete [POST]

this will delete a specific annotation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnnotationsDeleteSpecificAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnnotationsApi(config);
            var annotation = "annotation_example";  // string | This is a specific annotation uuid.

            try
            {
                // /annotations/{annotation}/delete [POST]
                apiInstance.AnnotationsDeleteSpecificAnnotation(annotation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationsApi.AnnotationsDeleteSpecificAnnotation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnnotationsDeleteSpecificAnnotationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /annotations/{annotation}/delete [POST]
    apiInstance.AnnotationsDeleteSpecificAnnotationWithHttpInfo(annotation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnnotationsApi.AnnotationsDeleteSpecificAnnotationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **annotation** | **string** | This is a specific annotation uuid. |  |

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

<a id="annotationssnapshot"></a>
# **AnnotationsSnapshot**
> Annotations AnnotationsSnapshot (string annotationTypeFilter = null)

/annotations [GET]

This will get a snapshot of all the annotations.  This will take an optional filter as a query param.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnnotationsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnnotationsApi(config);
            var annotationTypeFilter = "DESCRIPTION";  // string | This is an AnnotationTypeEnum as a optional filter. (optional) 

            try
            {
                // /annotations [GET]
                Annotations result = apiInstance.AnnotationsSnapshot(annotationTypeFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationsApi.AnnotationsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnnotationsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /annotations [GET]
    ApiResponse<Annotations> response = apiInstance.AnnotationsSnapshotWithHttpInfo(annotationTypeFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnnotationsApi.AnnotationsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **annotationTypeFilter** | **string** | This is an AnnotationTypeEnum as a optional filter. | [optional]  |

### Return type

[**Annotations**](Annotations.md)

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

<a id="annotationsstreamidentifiers"></a>
# **AnnotationsStreamIdentifiers**
> StreamedIdentifiers AnnotationsStreamIdentifiers ()

/annotations/stream/identifiers [WS]

Provides a WebSocket connection that emits changes to your annotation identifiers (UUIDs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnnotationsStreamIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnnotationsApi(config);

            try
            {
                // /annotations/stream/identifiers [WS]
                StreamedIdentifiers result = apiInstance.AnnotationsStreamIdentifiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationsApi.AnnotationsStreamIdentifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnnotationsStreamIdentifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /annotations/stream/identifiers [WS]
    ApiResponse<StreamedIdentifiers> response = apiInstance.AnnotationsStreamIdentifiersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnnotationsApi.AnnotationsStreamIdentifiersWithHttpInfo: " + e.Message);
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

<a id="searchannotations"></a>
# **SearchAnnotations**
> SearchedAnnotations SearchAnnotations (bool? transferables = null, SearchInput searchInput = null)

/annotations/search [POST]

This will search your annotations for a specific annotation  note: we will just search the annotation value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SearchAnnotationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnnotationsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var searchInput = new SearchInput(); // SearchInput |  (optional) 

            try
            {
                // /annotations/search [POST]
                SearchedAnnotations result = apiInstance.SearchAnnotations(transferables, searchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationsApi.SearchAnnotations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchAnnotationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /annotations/search [POST]
    ApiResponse<SearchedAnnotations> response = apiInstance.SearchAnnotationsWithHttpInfo(transferables, searchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnnotationsApi.SearchAnnotationsWithHttpInfo: " + e.Message);
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

[**SearchedAnnotations**](SearchedAnnotations.md)

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

