# Pieces.Os.Core.Api.DiscoveryApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiscoveryDiscoverAssets**](DiscoveryApi.md#discoverydiscoverassets) | **POST** /discovery/discover/assets | /discovery/discover/assets [POST] |
| [**DiscoveryDiscoverAssetsHtml**](DiscoveryApi.md#discoverydiscoverassetshtml) | **POST** /discovery/discover/assets/html | /discovery/discover/assets/html[POST] |
| [**DiscoveryDiscoverSensitives**](DiscoveryApi.md#discoverydiscoversensitives) | **POST** /discovery/discover/sensitives | /discovery/discover/sensitives [POST] |
| [**DiscoveryDiscoverTagsRelated**](DiscoveryApi.md#discoverydiscovertagsrelated) | **POST** /discovery/discover/tags/related | /discovery/discover/tags/related [POST] |

<a id="discoverydiscoverassets"></a>
# **DiscoveryDiscoverAssets**
> DiscoveredAssets DiscoveryDiscoverAssets (bool? automatic = null, SeededDiscoverableAssets seededDiscoverableAssets = null)

/discovery/discover/assets [POST]

This is the endpoint used for bulk import. In both cases of the bulk import flow, fragments or files. When we already have \"snippets\" or fragments to discover and now our job is to check if they are actually valid snippets(clustering). Otherwise, we should have a file to parse && snippitize and then run through the clustering.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DiscoveryDiscoverAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new DiscoveryApi(config);
            var automatic = true;  // bool? | For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional)  (default to true)
            var seededDiscoverableAssets = new SeededDiscoverableAssets(); // SeededDiscoverableAssets | The discovery/discover/assets endpoint will accept seededDiscoverableAssets, that represetns an iterable of multiple fragments or files. (optional) 

            try
            {
                // /discovery/discover/assets [POST]
                DiscoveredAssets result = apiInstance.DiscoveryDiscoverAssets(automatic, seededDiscoverableAssets);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApi.DiscoveryDiscoverAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscoveryDiscoverAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /discovery/discover/assets [POST]
    ApiResponse<DiscoveredAssets> response = apiInstance.DiscoveryDiscoverAssetsWithHttpInfo(automatic, seededDiscoverableAssets);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscoveryApi.DiscoveryDiscoverAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **automatic** | **bool?** | For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. | [optional] [default to true] |
| **seededDiscoverableAssets** | [**SeededDiscoverableAssets**](SeededDiscoverableAssets.md) | The discovery/discover/assets endpoint will accept seededDiscoverableAssets, that represetns an iterable of multiple fragments or files. | [optional]  |

### Return type

[**DiscoveredAssets**](DiscoveredAssets.md)

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

<a id="discoverydiscoverassetshtml"></a>
# **DiscoveryDiscoverAssetsHtml**
> DiscoveredHtmlWebpages DiscoveryDiscoverAssetsHtml (bool? automatic = null, SeededDiscoverableHtmlWebpages seededDiscoverableHtmlWebpages = null)

/discovery/discover/assets/html[POST]

This is the discover discover assets html endpoint. The goal of this endpoint is to either take an iterable of urls and pages(an html string) and extract all the assets from the iterable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DiscoveryDiscoverAssetsHtmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new DiscoveryApi(config);
            var automatic = true;  // bool? | For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional)  (default to true)
            var seededDiscoverableHtmlWebpages = new SeededDiscoverableHtmlWebpages(); // SeededDiscoverableHtmlWebpages |  (optional) 

            try
            {
                // /discovery/discover/assets/html[POST]
                DiscoveredHtmlWebpages result = apiInstance.DiscoveryDiscoverAssetsHtml(automatic, seededDiscoverableHtmlWebpages);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApi.DiscoveryDiscoverAssetsHtml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscoveryDiscoverAssetsHtmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /discovery/discover/assets/html[POST]
    ApiResponse<DiscoveredHtmlWebpages> response = apiInstance.DiscoveryDiscoverAssetsHtmlWithHttpInfo(automatic, seededDiscoverableHtmlWebpages);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscoveryApi.DiscoveryDiscoverAssetsHtmlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **automatic** | **bool?** | For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. | [optional] [default to true] |
| **seededDiscoverableHtmlWebpages** | [**SeededDiscoverableHtmlWebpages**](SeededDiscoverableHtmlWebpages.md) |  | [optional]  |

### Return type

[**DiscoveredHtmlWebpages**](DiscoveredHtmlWebpages.md)

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

<a id="discoverydiscoversensitives"></a>
# **DiscoveryDiscoverSensitives**
> DiscoveredSensitives DiscoveryDiscoverSensitives (bool? automatic = null, SeededDiscoverableSensitives seededDiscoverableSensitives = null)

/discovery/discover/sensitives [POST]

This endpoint will accept an array of text values, and attampt to extract sensitive data out of it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DiscoveryDiscoverSensitivesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new DiscoveryApi(config);
            var automatic = true;  // bool? | For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional)  (default to true)
            var seededDiscoverableSensitives = new SeededDiscoverableSensitives(); // SeededDiscoverableSensitives |  (optional) 

            try
            {
                // /discovery/discover/sensitives [POST]
                DiscoveredSensitives result = apiInstance.DiscoveryDiscoverSensitives(automatic, seededDiscoverableSensitives);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApi.DiscoveryDiscoverSensitives: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscoveryDiscoverSensitivesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /discovery/discover/sensitives [POST]
    ApiResponse<DiscoveredSensitives> response = apiInstance.DiscoveryDiscoverSensitivesWithHttpInfo(automatic, seededDiscoverableSensitives);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscoveryApi.DiscoveryDiscoverSensitivesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **automatic** | **bool?** | For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. | [optional] [default to true] |
| **seededDiscoverableSensitives** | [**SeededDiscoverableSensitives**](SeededDiscoverableSensitives.md) |  | [optional]  |

### Return type

[**DiscoveredSensitives**](DiscoveredSensitives.md)

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

<a id="discoverydiscovertagsrelated"></a>
# **DiscoveryDiscoverTagsRelated**
> DiscoveredRelatedTags DiscoveryDiscoverTagsRelated (bool? automatic = null, SeededDiscoverableRelatedTags seededDiscoverableRelatedTags = null)

/discovery/discover/tags/related [POST]

This will take in a tag or multiple tags and return all the tags that are related to the tag or tag provide in the body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DiscoveryDiscoverTagsRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new DiscoveryApi(config);
            var automatic = true;  // bool? | For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional)  (default to true)
            var seededDiscoverableRelatedTags = new SeededDiscoverableRelatedTags(); // SeededDiscoverableRelatedTags |  (optional) 

            try
            {
                // /discovery/discover/tags/related [POST]
                DiscoveredRelatedTags result = apiInstance.DiscoveryDiscoverTagsRelated(automatic, seededDiscoverableRelatedTags);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApi.DiscoveryDiscoverTagsRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscoveryDiscoverTagsRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /discovery/discover/tags/related [POST]
    ApiResponse<DiscoveredRelatedTags> response = apiInstance.DiscoveryDiscoverTagsRelatedWithHttpInfo(automatic, seededDiscoverableRelatedTags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscoveryApi.DiscoveryDiscoverTagsRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **automatic** | **bool?** | For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. | [optional] [default to true] |
| **seededDiscoverableRelatedTags** | [**SeededDiscoverableRelatedTags**](SeededDiscoverableRelatedTags.md) |  | [optional]  |

### Return type

[**DiscoveredRelatedTags**](DiscoveredRelatedTags.md)

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

