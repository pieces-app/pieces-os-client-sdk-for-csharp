# Pieces.Os.Core.Api.SearchApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FullTextSearch**](SearchApi.md#fulltextsearch) | **GET** /search/full_text | /search/full_text [GET] |
| [**NeuralCodeSearch**](SearchApi.md#neuralcodesearch) | **GET** /search/neural_code | /search/neural_code [GET] |
| [**TagBasedSearch**](SearchApi.md#tagbasedsearch) | **POST** /search/tag_based | /search/tag_based [POST] |

<a id="fulltextsearch"></a>
# **FullTextSearch**
> SearchedAssets FullTextSearch (string query = null, bool? pseudo = null)

/search/full_text [GET]

This will run FTS for exact search, and will NOT run fuzzy matching. This will only search the content within the 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class FullTextSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new SearchApi(config);
            var query = "query_example";  // string | This is a string that you can use to search your assets. (optional) 
            var pseudo = true;  // bool? | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. (optional) 

            try
            {
                // /search/full_text [GET]
                SearchedAssets result = apiInstance.FullTextSearch(query, pseudo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.FullTextSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FullTextSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /search/full_text [GET]
    ApiResponse<SearchedAssets> response = apiInstance.FullTextSearchWithHttpInfo(query, pseudo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.FullTextSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | This is a string that you can use to search your assets. | [optional]  |
| **pseudo** | **bool?** | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. | [optional]  |

### Return type

[**SearchedAssets**](SearchedAssets.md)

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

<a id="neuralcodesearch"></a>
# **NeuralCodeSearch**
> SearchedAssets NeuralCodeSearch (string query = null, bool? pseudo = null)

/search/neural_code [GET]

This will run ncs on your assets. This will simply return FlattenedAssets, but will just be the assetuuids that match.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class NeuralCodeSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new SearchApi(config);
            var query = "query_example";  // string | This is a string that you can use to search your assets. (optional) 
            var pseudo = true;  // bool? | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. (optional) 

            try
            {
                // /search/neural_code [GET]
                SearchedAssets result = apiInstance.NeuralCodeSearch(query, pseudo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.NeuralCodeSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NeuralCodeSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /search/neural_code [GET]
    ApiResponse<SearchedAssets> response = apiInstance.NeuralCodeSearchWithHttpInfo(query, pseudo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.NeuralCodeSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | This is a string that you can use to search your assets. | [optional]  |
| **pseudo** | **bool?** | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. | [optional]  |

### Return type

[**SearchedAssets**](SearchedAssets.md)

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

<a id="tagbasedsearch"></a>
# **TagBasedSearch**
> SearchedAssets TagBasedSearch (bool? pseudo = null, SeededAssetTags seededAssetTags = null)

/search/tag_based [POST]

This will run our tag based search, and return the assets that best match your passed in tags. This will simply return FlattenedAssets, but will just be the assetuuids that match.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class TagBasedSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new SearchApi(config);
            var pseudo = true;  // bool? | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. (optional) 
            var seededAssetTags = new SeededAssetTags(); // SeededAssetTags |  (optional) 

            try
            {
                // /search/tag_based [POST]
                SearchedAssets result = apiInstance.TagBasedSearch(pseudo, seededAssetTags);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.TagBasedSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagBasedSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /search/tag_based [POST]
    ApiResponse<SearchedAssets> response = apiInstance.TagBasedSearchWithHttpInfo(pseudo, seededAssetTags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.TagBasedSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pseudo** | **bool?** | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. | [optional]  |
| **seededAssetTags** | [**SeededAssetTags**](SeededAssetTags.md) |  | [optional]  |

### Return type

[**SearchedAssets**](SearchedAssets.md)

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

