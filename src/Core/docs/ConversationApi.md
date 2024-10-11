# Pieces.Os.Core.Api.ConversationApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConversationAssociateAnchor**](ConversationApi.md#conversationassociateanchor) | **POST** /conversation/{conversation}/anchors/associate/{anchor} | /conversation/{conversation}/anchors/associate/{anchor} [POST] |
| [**ConversationAssociateAsset**](ConversationApi.md#conversationassociateasset) | **POST** /conversation/{conversation}/assets/associate/{asset} | /conversation/{conversation}/assets/associate/{asset} [POST] |
| [**ConversationAssociateGroundingTemporalRangeWorkstream**](ConversationApi.md#conversationassociategroundingtemporalrangeworkstream) | **POST** /conversation/{conversation}/grounding/temporal_range/workstreams/associate/{range} | /conversation/{conversation}/grounding/temporal/ranges/associate/{range} [POST] |
| [**ConversationAssociateWebsite**](ConversationApi.md#conversationassociatewebsite) | **POST** /conversation/{conversation}/websites/associate/{website} | /conversation/{conversation}/websites/associate/{website} [POST] |
| [**ConversationAssociateWorkstreamSummary**](ConversationApi.md#conversationassociateworkstreamsummary) | **POST** /conversation/{conversation}/workstream_summaries/associate/{workstream_summary} | /conversation/{conversation}/workstream_summaries/associate/{workstream_summary} [POST] |
| [**ConversationDisassociateAnchor**](ConversationApi.md#conversationdisassociateanchor) | **POST** /conversation/{conversation}/anchors/disassociate/{anchor} | /conversation/{conversation}/anchors/disassociate/{anchor} [POST] |
| [**ConversationDisassociateAsset**](ConversationApi.md#conversationdisassociateasset) | **POST** /conversation/{conversation}/assets/disassociate/{asset} | /conversation/{conversation}/assets/disassociate/{asset} [POST] |
| [**ConversationDisassociateGroundingTemporalRangeWorkstream**](ConversationApi.md#conversationdisassociategroundingtemporalrangeworkstream) | **POST** /conversation/{conversation}/grounding/temporal_range/workstreams/disassociate/{range} | /conversation/{conversation}/grounding/temporal_range/workstreams/disassociate/{range} [POST] |
| [**ConversationDisassociateWebsite**](ConversationApi.md#conversationdisassociatewebsite) | **POST** /conversation/{conversation}/websites/disassociate/{website} | /website/{website}/websites/disassociate/{website} [POST] |
| [**ConversationDisassociateWorkstreamSummary**](ConversationApi.md#conversationdisassociateworkstreamsummary) | **POST** /conversation/{conversation}/workstream_summaries/disassociate/{workstream_summary} | /conversation/{conversation}/workstream_summaries/disassociate/{workstream_summary} [POST] |
| [**ConversationGetSpecificConversation**](ConversationApi.md#conversationgetspecificconversation) | **GET** /conversation/{conversation} | /conversation/{conversation} [GET] |
| [**ConversationGroundingMessagesAssociateMessage**](ConversationApi.md#conversationgroundingmessagesassociatemessage) | **POST** /conversation/{conversation}/grounding/messages/associate/{message} | /conversation/{conversation}/grounding/messages/associate/{message} [POST] |
| [**ConversationGroundingMessagesDisassociateMessage**](ConversationApi.md#conversationgroundingmessagesdisassociatemessage) | **POST** /conversation/{conversation}/grounding/messages/disassociate/{message} | /conversation/{conversation}/grounding/messages/disassociate/{message} [POST] |
| [**ConversationScoresIncrement**](ConversationApi.md#conversationscoresincrement) | **POST** /conversation/{conversation}/scores/increment | /conversation/{conversation}/scores/increment [POST] |
| [**ConversationSpecificConversationMessages**](ConversationApi.md#conversationspecificconversationmessages) | **GET** /conversation/{conversation}/messages | /conversation/{conversation}/messages [GET] |
| [**ConversationSpecificConversationRename**](ConversationApi.md#conversationspecificconversationrename) | **POST** /conversation/{conversation}/rename | /conversation/{conversation}/rename [POST] |
| [**ConversationSummarize**](ConversationApi.md#conversationsummarize) | **POST** /conversation/{conversation}/summarize | /conversation/{conversation}/summarize [POST] |
| [**ConversationUpdate**](ConversationApi.md#conversationupdate) | **POST** /conversation/update | /conversation/update [POST] |
| [**SearchConversationSpecificMessages**](ConversationApi.md#searchconversationspecificmessages) | **POST** /conversation/{conversation}/search | /conversation/{conversation}/search [POST] |

<a id="conversationassociateanchor"></a>
# **ConversationAssociateAnchor**
> void ConversationAssociateAnchor (string conversation, string anchor)

/conversation/{conversation}/anchors/associate/{anchor} [POST]

Updates both the anchor and the conversation, associating them together.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationAssociateAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /conversation/{conversation}/anchors/associate/{anchor} [POST]
                apiInstance.ConversationAssociateAnchor(conversation, anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationAssociateAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationAssociateAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/anchors/associate/{anchor} [POST]
    apiInstance.ConversationAssociateAnchorWithHttpInfo(conversation, anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationAssociateAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
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

<a id="conversationassociateasset"></a>
# **ConversationAssociateAsset**
> void ConversationAssociateAsset (string conversation, Guid asset)

/conversation/{conversation}/assets/associate/{asset} [POST]

Updates both the asset and the conversation, associating the two together.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationAssociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /conversation/{conversation}/assets/associate/{asset} [POST]
                apiInstance.ConversationAssociateAsset(conversation, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationAssociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationAssociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/assets/associate/{asset} [POST]
    apiInstance.ConversationAssociateAssetWithHttpInfo(conversation, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationAssociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
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

<a id="conversationassociategroundingtemporalrangeworkstream"></a>
# **ConversationAssociateGroundingTemporalRangeWorkstream**
> void ConversationAssociateGroundingTemporalRangeWorkstream (string conversation, string range)

/conversation/{conversation}/grounding/temporal/ranges/associate/{range} [POST]

This will associate a workstream(range) with a conversation. This will do the same thing as the range equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationAssociateGroundingTemporalRangeWorkstreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var range = "range_example";  // string | This is a identifier that is used to identify a specific range.

            try
            {
                // /conversation/{conversation}/grounding/temporal/ranges/associate/{range} [POST]
                apiInstance.ConversationAssociateGroundingTemporalRangeWorkstream(conversation, range);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationAssociateGroundingTemporalRangeWorkstream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationAssociateGroundingTemporalRangeWorkstreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/grounding/temporal/ranges/associate/{range} [POST]
    apiInstance.ConversationAssociateGroundingTemporalRangeWorkstreamWithHttpInfo(conversation, range);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationAssociateGroundingTemporalRangeWorkstreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
| **range** | **string** | This is a identifier that is used to identify a specific range. |  |

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

<a id="conversationassociatewebsite"></a>
# **ConversationAssociateWebsite**
> void ConversationAssociateWebsite (string conversation, string website)

/conversation/{conversation}/websites/associate/{website} [POST]

Updates both the website and the conversation, and associate them together.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationAssociateWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var website = "website_example";  // string | website id

            try
            {
                // /conversation/{conversation}/websites/associate/{website} [POST]
                apiInstance.ConversationAssociateWebsite(conversation, website);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationAssociateWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationAssociateWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/websites/associate/{website} [POST]
    apiInstance.ConversationAssociateWebsiteWithHttpInfo(conversation, website);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationAssociateWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
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

<a id="conversationassociateworkstreamsummary"></a>
# **ConversationAssociateWorkstreamSummary**
> void ConversationAssociateWorkstreamSummary (string conversation, string workstreamSummary)

/conversation/{conversation}/workstream_summaries/associate/{workstream_summary} [POST]

This will associate a conversation with a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationAssociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /conversation/{conversation}/workstream_summaries/associate/{workstream_summary} [POST]
                apiInstance.ConversationAssociateWorkstreamSummary(conversation, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationAssociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationAssociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/workstream_summaries/associate/{workstream_summary} [POST]
    apiInstance.ConversationAssociateWorkstreamSummaryWithHttpInfo(conversation, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationAssociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
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

<a id="conversationdisassociateanchor"></a>
# **ConversationDisassociateAnchor**
> void ConversationDisassociateAnchor (string conversation, string anchor)

/conversation/{conversation}/anchors/disassociate/{anchor} [POST]

Updates both the anchor and the conversation, deleting (disassociating) them simultaneously.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationDisassociateAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /conversation/{conversation}/anchors/disassociate/{anchor} [POST]
                apiInstance.ConversationDisassociateAnchor(conversation, anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationDisassociateAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationDisassociateAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/anchors/disassociate/{anchor} [POST]
    apiInstance.ConversationDisassociateAnchorWithHttpInfo(conversation, anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationDisassociateAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
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

<a id="conversationdisassociateasset"></a>
# **ConversationDisassociateAsset**
> void ConversationDisassociateAsset (string conversation, Guid asset)

/conversation/{conversation}/assets/disassociate/{asset} [POST]

Updates both the asset and the conversation, effectively disassociating them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationDisassociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /conversation/{conversation}/assets/disassociate/{asset} [POST]
                apiInstance.ConversationDisassociateAsset(conversation, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationDisassociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationDisassociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/assets/disassociate/{asset} [POST]
    apiInstance.ConversationDisassociateAssetWithHttpInfo(conversation, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationDisassociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
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

<a id="conversationdisassociategroundingtemporalrangeworkstream"></a>
# **ConversationDisassociateGroundingTemporalRangeWorkstream**
> void ConversationDisassociateGroundingTemporalRangeWorkstream (string conversation, string range)

/conversation/{conversation}/grounding/temporal_range/workstreams/disassociate/{range} [POST]

This will enable us to disassociate a workstream(range) from a conversation. This will do the same thing as the range equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationDisassociateGroundingTemporalRangeWorkstreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var range = "range_example";  // string | This is a identifier that is used to identify a specific range.

            try
            {
                // /conversation/{conversation}/grounding/temporal_range/workstreams/disassociate/{range} [POST]
                apiInstance.ConversationDisassociateGroundingTemporalRangeWorkstream(conversation, range);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationDisassociateGroundingTemporalRangeWorkstream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationDisassociateGroundingTemporalRangeWorkstreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/grounding/temporal_range/workstreams/disassociate/{range} [POST]
    apiInstance.ConversationDisassociateGroundingTemporalRangeWorkstreamWithHttpInfo(conversation, range);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationDisassociateGroundingTemporalRangeWorkstreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
| **range** | **string** | This is a identifier that is used to identify a specific range. |  |

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

<a id="conversationdisassociatewebsite"></a>
# **ConversationDisassociateWebsite**
> void ConversationDisassociateWebsite (string conversation, string website)

/website/{website}/websites/disassociate/{website} [POST]

Allows us to disassociate a conversation from a specific website

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationDisassociateWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var website = "website_example";  // string | website id

            try
            {
                // /website/{website}/websites/disassociate/{website} [POST]
                apiInstance.ConversationDisassociateWebsite(conversation, website);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationDisassociateWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationDisassociateWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/websites/disassociate/{website} [POST]
    apiInstance.ConversationDisassociateWebsiteWithHttpInfo(conversation, website);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationDisassociateWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
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

<a id="conversationdisassociateworkstreamsummary"></a>
# **ConversationDisassociateWorkstreamSummary**
> void ConversationDisassociateWorkstreamSummary (string conversation, string workstreamSummary)

/conversation/{conversation}/workstream_summaries/disassociate/{workstream_summary} [POST]

This will enable us to disassociate an conversation from a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationDisassociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /conversation/{conversation}/workstream_summaries/disassociate/{workstream_summary} [POST]
                apiInstance.ConversationDisassociateWorkstreamSummary(conversation, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationDisassociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationDisassociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/workstream_summaries/disassociate/{workstream_summary} [POST]
    apiInstance.ConversationDisassociateWorkstreamSummaryWithHttpInfo(conversation, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationDisassociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
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

<a id="conversationgetspecificconversation"></a>
# **ConversationGetSpecificConversation**
> Conversation ConversationGetSpecificConversation (string conversation, bool? transferables = null)

/conversation/{conversation} [GET]

Retrieves a specific conversation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationGetSpecificConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /conversation/{conversation} [GET]
                Conversation result = apiInstance.ConversationGetSpecificConversation(conversation, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationGetSpecificConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationGetSpecificConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation} [GET]
    ApiResponse<Conversation> response = apiInstance.ConversationGetSpecificConversationWithHttpInfo(conversation, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationGetSpecificConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Conversation**](Conversation.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | Website not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="conversationgroundingmessagesassociatemessage"></a>
# **ConversationGroundingMessagesAssociateMessage**
> void ConversationGroundingMessagesAssociateMessage (string conversation, string message)

/conversation/{conversation}/grounding/messages/associate/{message} [POST]

Stores the grounding context for a conversation. It allows to associate a message with the conversation's grounding object, facilitating contextual understanding and management of the conversation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationGroundingMessagesAssociateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /conversation/{conversation}/grounding/messages/associate/{message} [POST]
                apiInstance.ConversationGroundingMessagesAssociateMessage(conversation, message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationGroundingMessagesAssociateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationGroundingMessagesAssociateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/grounding/messages/associate/{message} [POST]
    apiInstance.ConversationGroundingMessagesAssociateMessageWithHttpInfo(conversation, message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationGroundingMessagesAssociateMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
| **message** | **string** | This is the uuid of a message. |  |

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

<a id="conversationgroundingmessagesdisassociatemessage"></a>
# **ConversationGroundingMessagesDisassociateMessage**
> void ConversationGroundingMessagesDisassociateMessage (string conversation, string message)

/conversation/{conversation}/grounding/messages/disassociate/{message} [POST]

Removes a specific grounding context for a conversation, and allows us to disassociate a message from the conversation's grounding object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationGroundingMessagesDisassociateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /conversation/{conversation}/grounding/messages/disassociate/{message} [POST]
                apiInstance.ConversationGroundingMessagesDisassociateMessage(conversation, message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationGroundingMessagesDisassociateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationGroundingMessagesDisassociateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/grounding/messages/disassociate/{message} [POST]
    apiInstance.ConversationGroundingMessagesDisassociateMessageWithHttpInfo(conversation, message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationGroundingMessagesDisassociateMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
| **message** | **string** | This is the uuid of a message. |  |

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

<a id="conversationscoresincrement"></a>
# **ConversationScoresIncrement**
> void ConversationScoresIncrement (string conversation, SeededScoreIncrement seededScoreIncrement = null)

/conversation/{conversation}/scores/increment [POST]

Increment scores associated with a conversation. It accepts a SeededScoreIncrement object as input to adjust the scores accordingly based on the provided data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // /conversation/{conversation}/scores/increment [POST]
                apiInstance.ConversationScoresIncrement(conversation, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/scores/increment [POST]
    apiInstance.ConversationScoresIncrementWithHttpInfo(conversation, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
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

<a id="conversationspecificconversationmessages"></a>
# **ConversationSpecificConversationMessages**
> ConversationMessages ConversationSpecificConversationMessages (string conversation, bool? transferables = null)

/conversation/{conversation}/messages [GET]

Retrieves messages specific to a particular conversation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationSpecificConversationMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /conversation/{conversation}/messages [GET]
                ConversationMessages result = apiInstance.ConversationSpecificConversationMessages(conversation, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationSpecificConversationMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationSpecificConversationMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/messages [GET]
    ApiResponse<ConversationMessages> response = apiInstance.ConversationSpecificConversationMessagesWithHttpInfo(conversation, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationSpecificConversationMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**ConversationMessages**](ConversationMessages.md)

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

<a id="conversationspecificconversationrename"></a>
# **ConversationSpecificConversationRename**
> Conversation ConversationSpecificConversationRename (string conversation, bool? transferables = null)

/conversation/{conversation}/rename [POST]

Renames a specific conversation using machine learning (ML) techniques.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationSpecificConversationRenameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /conversation/{conversation}/rename [POST]
                Conversation result = apiInstance.ConversationSpecificConversationRename(conversation, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationSpecificConversationRename: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationSpecificConversationRenameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/rename [POST]
    ApiResponse<Conversation> response = apiInstance.ConversationSpecificConversationRenameWithHttpInfo(conversation, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationSpecificConversationRenameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Conversation**](Conversation.md)

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

<a id="conversationsummarize"></a>
# **ConversationSummarize**
> ConversationSummarizeOutput ConversationSummarize (string conversation, ConversationSummarizeInput conversationSummarizeInput = null)

/conversation/{conversation}/summarize [POST]

Generates a summary of a given conversation and saves it as an annotation associated with the conversation. It returns a reference to the annotation, which serves as the summary.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationSummarizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var conversationSummarizeInput = new ConversationSummarizeInput(); // ConversationSummarizeInput |  (optional) 

            try
            {
                // /conversation/{conversation}/summarize [POST]
                ConversationSummarizeOutput result = apiInstance.ConversationSummarize(conversation, conversationSummarizeInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationSummarize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationSummarizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/summarize [POST]
    ApiResponse<ConversationSummarizeOutput> response = apiInstance.ConversationSummarizeWithHttpInfo(conversation, conversationSummarizeInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationSummarizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
| **conversationSummarizeInput** | [**ConversationSummarizeInput**](ConversationSummarizeInput.md) |  | [optional]  |

### Return type

[**ConversationSummarizeOutput**](ConversationSummarizeOutput.md)

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

<a id="conversationupdate"></a>
# **ConversationUpdate**
> Conversation ConversationUpdate (bool? transferables = null, Conversation conversation = null)

/conversation/update [POST]

Updates a specific conversation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var conversation = new Conversation(); // Conversation |  (optional) 

            try
            {
                // /conversation/update [POST]
                Conversation result = apiInstance.ConversationUpdate(transferables, conversation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.ConversationUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/update [POST]
    ApiResponse<Conversation> response = apiInstance.ConversationUpdateWithHttpInfo(transferables, conversation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.ConversationUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **conversation** | [**Conversation**](Conversation.md) |  | [optional]  |

### Return type

[**Conversation**](Conversation.md)

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

<a id="searchconversationspecificmessages"></a>
# **SearchConversationSpecificMessages**
> SearchedConversationMessages SearchConversationSpecificMessages (string conversation, bool? transferables = null, SearchInput searchInput = null)

/conversation/{conversation}/search [POST]

This will search a specific conversation for a match  note: here we will only search the conversationMessages for this given Conversation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SearchConversationSpecificMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationApi(config);
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var searchInput = new SearchInput(); // SearchInput |  (optional) 

            try
            {
                // /conversation/{conversation}/search [POST]
                SearchedConversationMessages result = apiInstance.SearchConversationSpecificMessages(conversation, transferables, searchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationApi.SearchConversationSpecificMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchConversationSpecificMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /conversation/{conversation}/search [POST]
    ApiResponse<SearchedConversationMessages> response = apiInstance.SearchConversationSpecificMessagesWithHttpInfo(conversation, transferables, searchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationApi.SearchConversationSpecificMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversation** | **string** | This is the uuid of a conversation. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **searchInput** | [**SearchInput**](SearchInput.md) |  | [optional]  |

### Return type

[**SearchedConversationMessages**](SearchedConversationMessages.md)

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

