# Pieces.Os.Core.Api.TagApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TagAssociateAsset**](TagApi.md#tagassociateasset) | **POST** /tag/{tag}/assets/associate/{asset} | /tag/{tag}/assets/associate/{asset} [POST] |
| [**TagAssociatePerson**](TagApi.md#tagassociateperson) | **POST** /tag/{tag}/persons/associate/{person} | /tag/{tag}/persons/associate/{person} [POST] |
| [**TagDisassociateAsset**](TagApi.md#tagdisassociateasset) | **POST** /tag/{tag}/assets/disassociate/{asset} | /tag/{tag}/assets/disassociate/{asset} [POST] |
| [**TagDisassociatePerson**](TagApi.md#tagdisassociateperson) | **POST** /tag/{tag}/persons/disassociate/{person} | /tag/{tag}/persons/disassociate/{person} [POST] |
| [**TagScoresIncrement**](TagApi.md#tagscoresincrement) | **POST** /tag/{tag}/scores/increment | &#39;/tag/{tag}/scores/increment&#39; [POST] |
| [**TagUpdate**](TagApi.md#tagupdate) | **POST** /tag/update | /tag/update [POST] |
| [**TagsSpecificTagSnapshot**](TagApi.md#tagsspecifictagsnapshot) | **GET** /tag/{tag} | /tag/{tag} [GET] |

<a id="tagassociateasset"></a>
# **TagAssociateAsset**
> void TagAssociateAsset (Guid asset, string tag)

/tag/{tag}/assets/associate/{asset} [POST]

This will associate a tag with a asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class TagAssociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new TagApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var tag = "tag_example";  // string | tag id

            try
            {
                // /tag/{tag}/assets/associate/{asset} [POST]
                apiInstance.TagAssociateAsset(asset, tag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagApi.TagAssociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagAssociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /tag/{tag}/assets/associate/{asset} [POST]
    apiInstance.TagAssociateAssetWithHttpInfo(asset, tag);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagApi.TagAssociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **tag** | **string** | tag id |  |

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

<a id="tagassociateperson"></a>
# **TagAssociatePerson**
> void TagAssociatePerson (string tag, string person)

/tag/{tag}/persons/associate/{person} [POST]

This will associate a tag with a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class TagAssociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new TagApi(config);
            var tag = "tag_example";  // string | tag id
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /tag/{tag}/persons/associate/{person} [POST]
                apiInstance.TagAssociatePerson(tag, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagApi.TagAssociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagAssociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /tag/{tag}/persons/associate/{person} [POST]
    apiInstance.TagAssociatePersonWithHttpInfo(tag, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagApi.TagAssociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tag** | **string** | tag id |  |
| **person** | **string** | This is a uuid that represents a person. |  |

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

<a id="tagdisassociateasset"></a>
# **TagDisassociateAsset**
> void TagDisassociateAsset (string tag, Guid asset)

/tag/{tag}/assets/disassociate/{asset} [POST]

This will enable us to dissassociate a tag from a asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class TagDisassociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new TagApi(config);
            var tag = "tag_example";  // string | tag id
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /tag/{tag}/assets/disassociate/{asset} [POST]
                apiInstance.TagDisassociateAsset(tag, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagApi.TagDisassociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagDisassociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /tag/{tag}/assets/disassociate/{asset} [POST]
    apiInstance.TagDisassociateAssetWithHttpInfo(tag, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagApi.TagDisassociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tag** | **string** | tag id |  |
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |

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

<a id="tagdisassociateperson"></a>
# **TagDisassociatePerson**
> void TagDisassociatePerson (string tag, string person)

/tag/{tag}/persons/disassociate/{person} [POST]

This will enable us to dissassociate a tag from a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class TagDisassociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new TagApi(config);
            var tag = "tag_example";  // string | tag id
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /tag/{tag}/persons/disassociate/{person} [POST]
                apiInstance.TagDisassociatePerson(tag, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagApi.TagDisassociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagDisassociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /tag/{tag}/persons/disassociate/{person} [POST]
    apiInstance.TagDisassociatePersonWithHttpInfo(tag, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagApi.TagDisassociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tag** | **string** | tag id |  |
| **person** | **string** | This is a uuid that represents a person. |  |

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

<a id="tagscoresincrement"></a>
# **TagScoresIncrement**
> void TagScoresIncrement (string tag, SeededScoreIncrement seededScoreIncrement = null)

'/tag/{tag}/scores/increment' [POST]

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
    public class TagScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new TagApi(config);
            var tag = "tag_example";  // string | tag id
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/tag/{tag}/scores/increment' [POST]
                apiInstance.TagScoresIncrement(tag, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagApi.TagScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/tag/{tag}/scores/increment' [POST]
    apiInstance.TagScoresIncrementWithHttpInfo(tag, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagApi.TagScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tag** | **string** | tag id |  |
| **seededScoreIncrement** | [**SeededScoreIncrement**](SeededScoreIncrement.md) |  | [optional]  |

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tagupdate"></a>
# **TagUpdate**
> Tag TagUpdate (bool? transferables = null, Tag tag = null)

/tag/update [POST]

This will update a specific tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class TagUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new TagApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var tag = new Tag(); // Tag |  (optional) 

            try
            {
                // /tag/update [POST]
                Tag result = apiInstance.TagUpdate(transferables, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagApi.TagUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /tag/update [POST]
    ApiResponse<Tag> response = apiInstance.TagUpdateWithHttpInfo(transferables, tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagApi.TagUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **tag** | [**Tag**](Tag.md) |  | [optional]  |

### Return type

[**Tag**](Tag.md)

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

<a id="tagsspecifictagsnapshot"></a>
# **TagsSpecificTagSnapshot**
> Tag TagsSpecificTagSnapshot (string tag, bool? transferables = null)

/tag/{tag} [GET]

This will get a specific tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class TagsSpecificTagSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new TagApi(config);
            var tag = "tag_example";  // string | tag id
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /tag/{tag} [GET]
                Tag result = apiInstance.TagsSpecificTagSnapshot(tag, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagApi.TagsSpecificTagSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagsSpecificTagSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /tag/{tag} [GET]
    ApiResponse<Tag> response = apiInstance.TagsSpecificTagSnapshotWithHttpInfo(tag, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagApi.TagsSpecificTagSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tag** | **string** | tag id |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Tag**](Tag.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | Tag was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

