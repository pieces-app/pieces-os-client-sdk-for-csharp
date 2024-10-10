# Pieces.Os.Core.Api.WebsiteApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebsiteAssociateAsset**](WebsiteApi.md#websiteassociateasset) | **POST** /website/{website}/assets/associate/{asset} | /website/{website}/assets/associate/{asset} [POST] |
| [**WebsiteAssociateConversation**](WebsiteApi.md#websiteassociateconversation) | **POST** /website/{website}/conversations/associate/{conversation} | /website/{website}/conversations/associate/{conversation} [POST] |
| [**WebsiteAssociateMessage**](WebsiteApi.md#websiteassociatemessage) | **POST** /website/{website}/messages/associate/{message} | /website/{website}/messages/associate/{message} [POST] |
| [**WebsiteAssociatePerson**](WebsiteApi.md#websiteassociateperson) | **POST** /website/{website}/persons/associate/{person} | /website/{website}/persons/associate/{person} [POST] |
| [**WebsiteAssociateWorkstreamSummary**](WebsiteApi.md#websiteassociateworkstreamsummary) | **POST** /website/{website}/workstream_summaries/associate/{workstream_summary} | /website/{website}/workstream_summaries/associate/{workstream_summary} [POST] |
| [**WebsiteDisassociateAsset**](WebsiteApi.md#websitedisassociateasset) | **POST** /website/{website}/assets/disassociate/{asset} | /website/{website}/assets/disassociate/{asset} [POST] |
| [**WebsiteDisassociateConversation**](WebsiteApi.md#websitedisassociateconversation) | **POST** /website/{website}/conversations/disassociate/{conversation} | /website/{website}/conversations/disassociate/{conversation} [POST] |
| [**WebsiteDisassociateMessage**](WebsiteApi.md#websitedisassociatemessage) | **POST** /website/{website}/messages/disassociate/{message} | /website/{website}/messages/disassociate/{message} [POST] |
| [**WebsiteDisassociatePerson**](WebsiteApi.md#websitedisassociateperson) | **POST** /website/{website}/persons/disassociate/{person} | /website/{website}/persons/disassociate/{person} [POST] |
| [**WebsiteDisassociateWorkstreamSummary**](WebsiteApi.md#websitedisassociateworkstreamsummary) | **POST** /website/{website}/workstream_summaries/disassociate/{workstream_summary} | /website/{website}/workstream_summaries/disassociate/{workstream_summary} [POST] |
| [**WebsiteScoresIncrement**](WebsiteApi.md#websitescoresincrement) | **POST** /website/{website}/scores/increment | &#39;/website/{website}/scores/increment&#39; [POST] |
| [**WebsiteUpdate**](WebsiteApi.md#websiteupdate) | **POST** /website/update | /website/update [POST] |
| [**WebsitesSpecificWebsiteSnapshot**](WebsiteApi.md#websitesspecificwebsitesnapshot) | **GET** /website/{website} | /website/{website} [GET] |

<a id="websiteassociateasset"></a>
# **WebsiteAssociateAsset**
> void WebsiteAssociateAsset (Guid asset, string website)

/website/{website}/assets/associate/{asset} [POST]

This will associate a website with a asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteAssociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var website = "website_example";  // string | website id

            try
            {
                // /website/{website}/assets/associate/{asset} [POST]
                apiInstance.WebsiteAssociateAsset(asset, website);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteAssociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteAssociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/assets/associate/{asset} [POST]
    apiInstance.WebsiteAssociateAssetWithHttpInfo(asset, website);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteAssociateAssetWithHttpInfo: " + e.Message);
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

<a id="websiteassociateconversation"></a>
# **WebsiteAssociateConversation**
> void WebsiteAssociateConversation (string website, string conversation)

/website/{website}/conversations/associate/{conversation} [POST]

This will associate a website with a conversation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteAssociateConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.

            try
            {
                // /website/{website}/conversations/associate/{conversation} [POST]
                apiInstance.WebsiteAssociateConversation(website, conversation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteAssociateConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteAssociateConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/conversations/associate/{conversation} [POST]
    apiInstance.WebsiteAssociateConversationWithHttpInfo(website, conversation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteAssociateConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
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

<a id="websiteassociatemessage"></a>
# **WebsiteAssociateMessage**
> void WebsiteAssociateMessage (string website, string message)

/website/{website}/messages/associate/{message} [POST]

This will associate a website with a message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteAssociateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /website/{website}/messages/associate/{message} [POST]
                apiInstance.WebsiteAssociateMessage(website, message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteAssociateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteAssociateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/messages/associate/{message} [POST]
    apiInstance.WebsiteAssociateMessageWithHttpInfo(website, message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteAssociateMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
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

<a id="websiteassociateperson"></a>
# **WebsiteAssociatePerson**
> void WebsiteAssociatePerson (string website, string person)

/website/{website}/persons/associate/{person} [POST]

This will associate a website with a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteAssociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /website/{website}/persons/associate/{person} [POST]
                apiInstance.WebsiteAssociatePerson(website, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteAssociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteAssociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/persons/associate/{person} [POST]
    apiInstance.WebsiteAssociatePersonWithHttpInfo(website, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteAssociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
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

<a id="websiteassociateworkstreamsummary"></a>
# **WebsiteAssociateWorkstreamSummary**
> void WebsiteAssociateWorkstreamSummary (string website, string workstreamSummary)

/website/{website}/workstream_summaries/associate/{workstream_summary} [POST]

This will associate a website with a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteAssociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /website/{website}/workstream_summaries/associate/{workstream_summary} [POST]
                apiInstance.WebsiteAssociateWorkstreamSummary(website, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteAssociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteAssociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/workstream_summaries/associate/{workstream_summary} [POST]
    apiInstance.WebsiteAssociateWorkstreamSummaryWithHttpInfo(website, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteAssociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
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

<a id="websitedisassociateasset"></a>
# **WebsiteDisassociateAsset**
> void WebsiteDisassociateAsset (string website, Guid asset)

/website/{website}/assets/disassociate/{asset} [POST]

This will enable us to dissassociate a website from a asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteDisassociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /website/{website}/assets/disassociate/{asset} [POST]
                apiInstance.WebsiteDisassociateAsset(website, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteDisassociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteDisassociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/assets/disassociate/{asset} [POST]
    apiInstance.WebsiteDisassociateAssetWithHttpInfo(website, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteDisassociateAssetWithHttpInfo: " + e.Message);
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

<a id="websitedisassociateconversation"></a>
# **WebsiteDisassociateConversation**
> void WebsiteDisassociateConversation (string website, string conversation)

/website/{website}/conversations/disassociate/{conversation} [POST]

This will enable us to dissassociate a website from a conversation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteDisassociateConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.

            try
            {
                // /website/{website}/conversations/disassociate/{conversation} [POST]
                apiInstance.WebsiteDisassociateConversation(website, conversation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteDisassociateConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteDisassociateConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/conversations/disassociate/{conversation} [POST]
    apiInstance.WebsiteDisassociateConversationWithHttpInfo(website, conversation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteDisassociateConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
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

<a id="websitedisassociatemessage"></a>
# **WebsiteDisassociateMessage**
> void WebsiteDisassociateMessage (string website, string message)

/website/{website}/messages/disassociate/{message} [POST]

This will enable us to disassociate a website from a message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteDisassociateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /website/{website}/messages/disassociate/{message} [POST]
                apiInstance.WebsiteDisassociateMessage(website, message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteDisassociateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteDisassociateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/messages/disassociate/{message} [POST]
    apiInstance.WebsiteDisassociateMessageWithHttpInfo(website, message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteDisassociateMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
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

<a id="websitedisassociateperson"></a>
# **WebsiteDisassociatePerson**
> void WebsiteDisassociatePerson (string website, string person)

/website/{website}/persons/disassociate/{person} [POST]

This will enable us to dissassociate a website from a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteDisassociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /website/{website}/persons/disassociate/{person} [POST]
                apiInstance.WebsiteDisassociatePerson(website, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteDisassociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteDisassociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/persons/disassociate/{person} [POST]
    apiInstance.WebsiteDisassociatePersonWithHttpInfo(website, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteDisassociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
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

<a id="websitedisassociateworkstreamsummary"></a>
# **WebsiteDisassociateWorkstreamSummary**
> void WebsiteDisassociateWorkstreamSummary (string website, string workstreamSummary)

/website/{website}/workstream_summaries/disassociate/{workstream_summary} [POST]

This will enable us to disassociate a website from a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteDisassociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /website/{website}/workstream_summaries/disassociate/{workstream_summary} [POST]
                apiInstance.WebsiteDisassociateWorkstreamSummary(website, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteDisassociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteDisassociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website}/workstream_summaries/disassociate/{workstream_summary} [POST]
    apiInstance.WebsiteDisassociateWorkstreamSummaryWithHttpInfo(website, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteDisassociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
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

<a id="websitescoresincrement"></a>
# **WebsiteScoresIncrement**
> void WebsiteScoresIncrement (string website, SeededScoreIncrement seededScoreIncrement = null)

'/website/{website}/scores/increment' [POST]

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
    public class WebsiteScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/website/{website}/scores/increment' [POST]
                apiInstance.WebsiteScoresIncrement(website, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/website/{website}/scores/increment' [POST]
    apiInstance.WebsiteScoresIncrementWithHttpInfo(website, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
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

<a id="websiteupdate"></a>
# **WebsiteUpdate**
> Website WebsiteUpdate (bool? transferables = null, Website website = null)

/website/update [POST]

This will update a specific website.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsiteUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var website = new Website(); // Website |  (optional) 

            try
            {
                // /website/update [POST]
                Website result = apiInstance.WebsiteUpdate(transferables, website);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/update [POST]
    ApiResponse<Website> response = apiInstance.WebsiteUpdateWithHttpInfo(transferables, website);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsiteUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **website** | [**Website**](Website.md) |  | [optional]  |

### Return type

[**Website**](Website.md)

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

<a id="websitesspecificwebsitesnapshot"></a>
# **WebsitesSpecificWebsiteSnapshot**
> Website WebsitesSpecificWebsiteSnapshot (string website, bool? transferables = null)

/website/{website} [GET]

This will get a snapshot of a single website.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WebsitesSpecificWebsiteSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WebsiteApi(config);
            var website = "website_example";  // string | website id
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /website/{website} [GET]
                Website result = apiInstance.WebsitesSpecificWebsiteSnapshot(website, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsitesSpecificWebsiteSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsitesSpecificWebsiteSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /website/{website} [GET]
    ApiResponse<Website> response = apiInstance.WebsitesSpecificWebsiteSnapshotWithHttpInfo(website, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteApi.WebsitesSpecificWebsiteSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **website** | **string** | website id |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Website**](Website.md)

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

