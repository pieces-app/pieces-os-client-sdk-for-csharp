# Pieces.Os.Core.Api.AssetApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssetAssociateAnchor**](AssetApi.md#assetassociateanchor) | **POST** /asset/{asset}/anchors/associate/{anchor} | /asset/{asset}/persons/associate/{anchor} [POST] |
| [**AssetAssociateConversation**](AssetApi.md#assetassociateconversation) | **POST** /asset/{asset}/conversations/associate/{conversation} | /asset/{asset}/conversations/associate/{conversation} [POST] |
| [**AssetAssociateHint**](AssetApi.md#assetassociatehint) | **POST** /asset/{asset}/hints/associate/{hint} | /asset/{asset}/hints/associate/{hint} [POST] |
| [**AssetAssociatePerson**](AssetApi.md#assetassociateperson) | **POST** /asset/{asset}/persons/associate/{person} | /asset/{asset}/persons/associate/{person} [POST] |
| [**AssetAssociateTag**](AssetApi.md#assetassociatetag) | **POST** /asset/{asset}/tags/associate/{tag} | /asset/{asset}/tags/associate/{tag} [POST] |
| [**AssetAssociateWebsite**](AssetApi.md#assetassociatewebsite) | **POST** /asset/{asset}/websites/associate/{website} | /asset/{asset}/websites/associate/{website} [POST] |
| [**AssetAssociateWorkstreamSummary**](AssetApi.md#assetassociateworkstreamsummary) | **POST** /asset/{asset}/workstream_summaries/associate/{workstream_summary} | /asset/{asset}/workstream_summaries/associate/{workstream_summary} [POST] |
| [**AssetDisassociateAnchor**](AssetApi.md#assetdisassociateanchor) | **POST** /asset/{asset}/anchors/disassociate/{anchor} | /asset/{asset}/anchors/disassociate/{anchor} [POST] |
| [**AssetDisassociateConversation**](AssetApi.md#assetdisassociateconversation) | **POST** /asset/{asset}/conversations/disassociate/{conversation} | /asset/{asset}/conversations/disassociate/{conversation} [POST] |
| [**AssetDisassociateHint**](AssetApi.md#assetdisassociatehint) | **POST** /asset/{asset}/hints/disassociate/{hint} | /asset/{asset}/hints/disassociate/{hint} [POST] |
| [**AssetDisassociatePerson**](AssetApi.md#assetdisassociateperson) | **POST** /asset/{asset}/persons/disassociate/{person} | /asset/{asset}/persons/disassociate/{person} [POST] |
| [**AssetDisassociateTag**](AssetApi.md#assetdisassociatetag) | **POST** /asset/{asset}/tags/disassociate/{tag} | /asset/{asset}/tags/disassociate/{tag} [POST] |
| [**AssetDisassociateWebsite**](AssetApi.md#assetdisassociatewebsite) | **POST** /asset/{asset}/websites/disassociate/{website} | /asset/{asset}/websites/disassociate/{website} [POST] |
| [**AssetDisassociateWorkstreamSummary**](AssetApi.md#assetdisassociateworkstreamsummary) | **POST** /asset/{asset}/workstream_summaries/disassociate/{workstream_summary} | /asset/{asset}/workstream_summaries/disassociate/{workstream_summary} [POST] |
| [**AssetFormats**](AssetApi.md#assetformats) | **GET** /asset/{asset}/formats | /asset/{asset}/formats [GET] Scoped To Asset |
| [**AssetReclassify**](AssetApi.md#assetreclassify) | **POST** /asset/reclassify | /asset/reclassify [POST] |
| [**AssetScoresIncrement**](AssetApi.md#assetscoresincrement) | **POST** /asset/{asset}/scores/increment | /asset/{asset}/scores/increment [POST] |
| [**AssetSnapshot**](AssetApi.md#assetsnapshot) | **GET** /asset/{asset} | /asset/{asset} [GET] Scoped To Asset |
| [**AssetSnapshotPost**](AssetApi.md#assetsnapshotpost) | **POST** /asset/{asset} | /asset/{asset} [POST] Scoped to an Asset |
| [**AssetSpecificAssetActivities**](AssetApi.md#assetspecificassetactivities) | **GET** /asset/{asset}/activities | /asset/{asset}/activities [GET] |
| [**AssetSpecificAssetConversations**](AssetApi.md#assetspecificassetconversations) | **GET** /asset/{asset}/conversations | /asset/{asset}/conversations [GET] |
| [**AssetSpecificAssetExport**](AssetApi.md#assetspecificassetexport) | **GET** /asset/{asset}/export | /asset/{asset}/export [GET] |
| [**AssetUpdate**](AssetApi.md#assetupdate) | **POST** /asset/update | /asset/update [POST] Scoped to Asset |

<a id="assetassociateanchor"></a>
# **AssetAssociateAnchor**
> void AssetAssociateAnchor (Guid asset, string anchor)

/asset/{asset}/persons/associate/{anchor} [POST]

associates an anchor and an asset. It performs the same action as the anchor equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetAssociateAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /asset/{asset}/persons/associate/{anchor} [POST]
                apiInstance.AssetAssociateAnchor(asset, anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetAssociateAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetAssociateAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/persons/associate/{anchor} [POST]
    apiInstance.AssetAssociateAnchorWithHttpInfo(asset, anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetAssociateAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **anchor** | **string** | This is the specific uuid of an anchor. |  |

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

<a id="assetassociateconversation"></a>
# **AssetAssociateConversation**
> void AssetAssociateConversation (Guid asset, string conversation)

/asset/{asset}/conversations/associate/{conversation} [POST]

associates a conversation and an asset. It performs the same action as the conversation equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetAssociateConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.

            try
            {
                // /asset/{asset}/conversations/associate/{conversation} [POST]
                apiInstance.AssetAssociateConversation(asset, conversation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetAssociateConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetAssociateConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/conversations/associate/{conversation} [POST]
    apiInstance.AssetAssociateConversationWithHttpInfo(asset, conversation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetAssociateConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **conversation** | **string** | This is the uuid of a conversation. |  |

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

<a id="assetassociatehint"></a>
# **AssetAssociateHint**
> void AssetAssociateHint (Guid asset, string hint)

/asset/{asset}/hints/associate/{hint} [POST]

associates an asset and a hint. It performs the same action as the hint equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetAssociateHintExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var hint = "hint_example";  // string | This is a specific hint uuid

            try
            {
                // /asset/{asset}/hints/associate/{hint} [POST]
                apiInstance.AssetAssociateHint(asset, hint);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetAssociateHint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetAssociateHintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/hints/associate/{hint} [POST]
    apiInstance.AssetAssociateHintWithHttpInfo(asset, hint);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetAssociateHintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **hint** | **string** | This is a specific hint uuid |  |

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

<a id="assetassociateperson"></a>
# **AssetAssociatePerson**
> void AssetAssociatePerson (Guid asset, string person)

/asset/{asset}/persons/associate/{person} [POST]

associates a person and an asset. It performs the same action as the person equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetAssociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /asset/{asset}/persons/associate/{person} [POST]
                apiInstance.AssetAssociatePerson(asset, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetAssociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetAssociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/persons/associate/{person} [POST]
    apiInstance.AssetAssociatePersonWithHttpInfo(asset, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetAssociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
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

<a id="assetassociatetag"></a>
# **AssetAssociateTag**
> void AssetAssociateTag (Guid asset, string tag)

/asset/{asset}/tags/associate/{tag} [POST]

Associates a tag with a specified asset. It performs the same action as the tag equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetAssociateTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var tag = "tag_example";  // string | tag id

            try
            {
                // /asset/{asset}/tags/associate/{tag} [POST]
                apiInstance.AssetAssociateTag(asset, tag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetAssociateTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetAssociateTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/tags/associate/{tag} [POST]
    apiInstance.AssetAssociateTagWithHttpInfo(asset, tag);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetAssociateTagWithHttpInfo: " + e.Message);
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

<a id="assetassociatewebsite"></a>
# **AssetAssociateWebsite**
> void AssetAssociateWebsite (Guid asset, string website)

/asset/{asset}/websites/associate/{website} [POST]

Associates a website with an asset. It performs the same action as its website equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetAssociateWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var website = "website_example";  // string | website id

            try
            {
                // /asset/{asset}/websites/associate/{website} [POST]
                apiInstance.AssetAssociateWebsite(asset, website);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetAssociateWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetAssociateWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/websites/associate/{website} [POST]
    apiInstance.AssetAssociateWebsiteWithHttpInfo(asset, website);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetAssociateWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **website** | **string** | website id |  |

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

<a id="assetassociateworkstreamsummary"></a>
# **AssetAssociateWorkstreamSummary**
> void AssetAssociateWorkstreamSummary (Guid asset, string workstreamSummary)

/asset/{asset}/workstream_summaries/associate/{workstream_summary} [POST]

This will associate a asset with a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetAssociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /asset/{asset}/workstream_summaries/associate/{workstream_summary} [POST]
                apiInstance.AssetAssociateWorkstreamSummary(asset, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetAssociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetAssociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/workstream_summaries/associate/{workstream_summary} [POST]
    apiInstance.AssetAssociateWorkstreamSummaryWithHttpInfo(asset, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetAssociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |

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

<a id="assetdisassociateanchor"></a>
# **AssetDisassociateAnchor**
> void AssetDisassociateAnchor (Guid asset, string anchor)

/asset/{asset}/anchors/disassociate/{anchor} [POST]

Disassociates a anchor from an asset. It performs the same action as the anchor equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetDisassociateAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /asset/{asset}/anchors/disassociate/{anchor} [POST]
                apiInstance.AssetDisassociateAnchor(asset, anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetDisassociateAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetDisassociateAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/anchors/disassociate/{anchor} [POST]
    apiInstance.AssetDisassociateAnchorWithHttpInfo(asset, anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetDisassociateAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **anchor** | **string** | This is the specific uuid of an anchor. |  |

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

<a id="assetdisassociateconversation"></a>
# **AssetDisassociateConversation**
> void AssetDisassociateConversation (Guid asset, string conversation)

/asset/{asset}/conversations/disassociate/{conversation} [POST]

Disassociates a conversation from an asset. It performs the same action as the conversation equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetDisassociateConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.

            try
            {
                // /asset/{asset}/conversations/disassociate/{conversation} [POST]
                apiInstance.AssetDisassociateConversation(asset, conversation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetDisassociateConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetDisassociateConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/conversations/disassociate/{conversation} [POST]
    apiInstance.AssetDisassociateConversationWithHttpInfo(asset, conversation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetDisassociateConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **conversation** | **string** | This is the uuid of a conversation. |  |

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

<a id="assetdisassociatehint"></a>
# **AssetDisassociateHint**
> void AssetDisassociateHint (Guid asset, string hint)

/asset/{asset}/hints/disassociate/{hint} [POST]

Disassociates an asset from a hint. It performs the same action as the hint equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetDisassociateHintExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var hint = "hint_example";  // string | This is a specific hint uuid

            try
            {
                // /asset/{asset}/hints/disassociate/{hint} [POST]
                apiInstance.AssetDisassociateHint(asset, hint);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetDisassociateHint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetDisassociateHintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/hints/disassociate/{hint} [POST]
    apiInstance.AssetDisassociateHintWithHttpInfo(asset, hint);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetDisassociateHintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **hint** | **string** | This is a specific hint uuid |  |

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

<a id="assetdisassociateperson"></a>
# **AssetDisassociatePerson**
> void AssetDisassociatePerson (Guid asset, string person)

/asset/{asset}/persons/disassociate/{person} [POST]

Disassociates a person from an asset. It performs the same action as the person equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetDisassociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /asset/{asset}/persons/disassociate/{person} [POST]
                apiInstance.AssetDisassociatePerson(asset, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetDisassociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetDisassociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/persons/disassociate/{person} [POST]
    apiInstance.AssetDisassociatePersonWithHttpInfo(asset, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetDisassociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
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

<a id="assetdisassociatetag"></a>
# **AssetDisassociateTag**
> void AssetDisassociateTag (string tag, Guid asset)

/asset/{asset}/tags/disassociate/{tag} [POST]

Disassociates a tag from an asset. It performs the same action as the tag equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetDisassociateTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var tag = "tag_example";  // string | tag id
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /asset/{asset}/tags/disassociate/{tag} [POST]
                apiInstance.AssetDisassociateTag(tag, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetDisassociateTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetDisassociateTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/tags/disassociate/{tag} [POST]
    apiInstance.AssetDisassociateTagWithHttpInfo(tag, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetDisassociateTagWithHttpInfo: " + e.Message);
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

<a id="assetdisassociatewebsite"></a>
# **AssetDisassociateWebsite**
> void AssetDisassociateWebsite (string website, Guid asset)

/asset/{asset}/websites/disassociate/{website} [POST]

Disassociates a website from an asset. It performs the same action as the website equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetDisassociateWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var website = "website_example";  // string | website id
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /asset/{asset}/websites/disassociate/{website} [POST]
                apiInstance.AssetDisassociateWebsite(website, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetDisassociateWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetDisassociateWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/websites/disassociate/{website} [POST]
    apiInstance.AssetDisassociateWebsiteWithHttpInfo(website, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetDisassociateWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
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

<a id="assetdisassociateworkstreamsummary"></a>
# **AssetDisassociateWorkstreamSummary**
> void AssetDisassociateWorkstreamSummary (Guid asset, string workstreamSummary)

/asset/{asset}/workstream_summaries/disassociate/{workstream_summary} [POST]

This will enable us to disassociate an asset from a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetDisassociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /asset/{asset}/workstream_summaries/disassociate/{workstream_summary} [POST]
                apiInstance.AssetDisassociateWorkstreamSummary(asset, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetDisassociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetDisassociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/workstream_summaries/disassociate/{workstream_summary} [POST]
    apiInstance.AssetDisassociateWorkstreamSummaryWithHttpInfo(asset, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetDisassociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |

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

<a id="assetformats"></a>
# **AssetFormats**
> Formats AssetFormats (Guid asset, bool? transferables = null)

/asset/{asset}/formats [GET] Scoped To Asset

Retrieves the formats available for a specified asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetFormatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /asset/{asset}/formats [GET] Scoped To Asset
                Formats result = apiInstance.AssetFormats(asset, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetFormats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetFormatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/formats [GET] Scoped To Asset
    ApiResponse<Formats> response = apiInstance.AssetFormatsWithHttpInfo(asset, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetFormatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Formats**](Formats.md)

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

<a id="assetreclassify"></a>
# **AssetReclassify**
> Asset AssetReclassify (bool? transferables = null, AssetReclassification assetReclassification = null)

/asset/reclassify [POST]

Retrieves the formats available for a specified asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetReclassifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var assetReclassification = new AssetReclassification(); // AssetReclassification | This will accept a Reclassification that includeds and assetand a language that this assets needs to be reclassified to. We will just return an Asset that has been reclassified. (optional) 

            try
            {
                // /asset/reclassify [POST]
                Asset result = apiInstance.AssetReclassify(transferables, assetReclassification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetReclassify: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetReclassifyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/reclassify [POST]
    ApiResponse<Asset> response = apiInstance.AssetReclassifyWithHttpInfo(transferables, assetReclassification);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetReclassifyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **assetReclassification** | [**AssetReclassification**](AssetReclassification.md) | This will accept a Reclassification that includeds and assetand a language that this assets needs to be reclassified to. We will just return an Asset that has been reclassified. | [optional]  |

### Return type

[**Asset**](Asset.md)

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

<a id="assetscoresincrement"></a>
# **AssetScoresIncrement**
> void AssetScoresIncrement (Guid asset, SeededScoreIncrement seededScoreIncrement = null)

/asset/{asset}/scores/increment [POST]

Increments the scores associated with the specified asset based on the provided SeededScoreIncrement data in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // /asset/{asset}/scores/increment [POST]
                apiInstance.AssetScoresIncrement(asset, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/scores/increment [POST]
    apiInstance.AssetScoresIncrementWithHttpInfo(asset, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
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

<a id="assetsnapshot"></a>
# **AssetSnapshot**
> Asset AssetSnapshot (Guid asset, bool? transferables = null)

/asset/{asset} [GET] Scoped To Asset

Retrieves the snapshot of a specific asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /asset/{asset} [GET] Scoped To Asset
                Asset result = apiInstance.AssetSnapshot(asset, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset} [GET] Scoped To Asset
    ApiResponse<Asset> response = apiInstance.AssetSnapshotWithHttpInfo(asset, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Asset**](Asset.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | Asset no longer exists and is Gone. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsnapshotpost"></a>
# **AssetSnapshotPost**
> Asset AssetSnapshotPost (Guid asset, bool? transferables = null, SeededAccessor seededAccessor = null)

/asset/{asset} [POST] Scoped to an Asset

Retrieves a snapshot of a specific asset, along with the user requesting the snapshot.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetSnapshotPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seededAccessor = new SeededAccessor(); // SeededAccessor |  (optional) 

            try
            {
                // /asset/{asset} [POST] Scoped to an Asset
                Asset result = apiInstance.AssetSnapshotPost(asset, transferables, seededAccessor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetSnapshotPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetSnapshotPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset} [POST] Scoped to an Asset
    ApiResponse<Asset> response = apiInstance.AssetSnapshotPostWithHttpInfo(asset, transferables, seededAccessor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetSnapshotPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seededAccessor** | [**SeededAccessor**](SeededAccessor.md) |  | [optional]  |

### Return type

[**Asset**](Asset.md)

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

<a id="assetspecificassetactivities"></a>
# **AssetSpecificAssetActivities**
> Activities AssetSpecificAssetActivities (Guid asset, bool? transferables = null)

/asset/{asset}/activities [GET]

Retrieves activity events specific to the given asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetSpecificAssetActivitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /asset/{asset}/activities [GET]
                Activities result = apiInstance.AssetSpecificAssetActivities(asset, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetSpecificAssetActivities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetSpecificAssetActivitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/activities [GET]
    ApiResponse<Activities> response = apiInstance.AssetSpecificAssetActivitiesWithHttpInfo(asset, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetSpecificAssetActivitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Activities**](Activities.md)

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

<a id="assetspecificassetconversations"></a>
# **AssetSpecificAssetConversations**
> Conversations AssetSpecificAssetConversations (Guid asset, bool? transferables = null)

/asset/{asset}/conversations [GET]

Retrieves conversations specific to the given asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetSpecificAssetConversationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /asset/{asset}/conversations [GET]
                Conversations result = apiInstance.AssetSpecificAssetConversations(asset, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetSpecificAssetConversations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetSpecificAssetConversationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/conversations [GET]
    ApiResponse<Conversations> response = apiInstance.AssetSpecificAssetConversationsWithHttpInfo(asset, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetSpecificAssetConversationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Conversations**](Conversations.md)

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

<a id="assetspecificassetexport"></a>
# **AssetSpecificAssetExport**
> ExportedAsset AssetSpecificAssetExport (Guid asset, string exportType)

/asset/{asset}/export [GET]

Retrieves an export version of the specified asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetSpecificAssetExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var exportType = "HTML";  // string | This specifies the type of export the user wants.

            try
            {
                // /asset/{asset}/export [GET]
                ExportedAsset result = apiInstance.AssetSpecificAssetExport(asset, exportType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetSpecificAssetExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetSpecificAssetExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/{asset}/export [GET]
    ApiResponse<ExportedAsset> response = apiInstance.AssetSpecificAssetExportWithHttpInfo(asset, exportType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetSpecificAssetExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **exportType** | **string** | This specifies the type of export the user wants. |  |

### Return type

[**ExportedAsset**](ExportedAsset.md)

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

<a id="assetupdate"></a>
# **AssetUpdate**
> Asset AssetUpdate (bool? transferables = null, Asset asset = null)

/asset/update [POST] Scoped to Asset

Allows the user to update an existing Asset. It accepts the Asset object that needs updating and returns the fully updated Asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new AssetApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var asset = new Asset(); // Asset | This endpoint allows the user to update an existing Asset. It accepts the Asset object that needs updating and returns the fully updated Asset. (optional) 

            try
            {
                // /asset/update [POST] Scoped to Asset
                Asset result = apiInstance.AssetUpdate(transferables, asset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.AssetUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /asset/update [POST] Scoped to Asset
    ApiResponse<Asset> response = apiInstance.AssetUpdateWithHttpInfo(transferables, asset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.AssetUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **asset** | [**Asset**](Asset.md) | This endpoint allows the user to update an existing Asset. It accepts the Asset object that needs updating and returns the fully updated Asset. | [optional]  |

### Return type

[**Asset**](Asset.md)

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

