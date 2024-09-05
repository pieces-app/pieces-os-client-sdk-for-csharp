# Pieces.Os.Core.Api.AnchorApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AnchorAssociateAsset**](AnchorApi.md#anchorassociateasset) | **POST** /anchor/{anchor}/assets/associate/{asset} | /anchor/{anchor}/assets/associate/{asset} [POST] |
| [**AnchorAssociateConversation**](AnchorApi.md#anchorassociateconversation) | **POST** /anchor/{anchor}/conversations/associate/{conversation} | /anchor/{anchor}/conversations/associate/{conversation} [POST] |
| [**AnchorAssociateMessage**](AnchorApi.md#anchorassociatemessage) | **POST** /anchor/{anchor}/messages/associate/{message} | /anchor/{anchor}/messages/associate/{message} [POST] |
| [**AnchorAssociatePerson**](AnchorApi.md#anchorassociateperson) | **POST** /anchor/{anchor}/persons/associate/{person} | /anchor/{anchor}/persons/associate/{person} [POST] |
| [**AnchorAssociateWorkstreamSummary**](AnchorApi.md#anchorassociateworkstreamsummary) | **POST** /anchor/{anchor}/workstream_summaries/associate/{workstream_summary} | /anchor/{anchor}/workstream_summaries/associate/{workstream_summary} [POST] |
| [**AnchorDisassociateAsset**](AnchorApi.md#anchordisassociateasset) | **POST** /anchor/{anchor}/assets/disassociate/{asset} | /anchor/{anchor}/assets/disassociate/{asset} [POST] |
| [**AnchorDisassociateConversation**](AnchorApi.md#anchordisassociateconversation) | **POST** /anchor/{anchor}/conversations/disassociate/{conversation} | /anchor/{anchor}/conversations/disassociate/{conversation} [POST] |
| [**AnchorDisassociateMessage**](AnchorApi.md#anchordisassociatemessage) | **POST** /anchor/{anchor}/messages/disassociate/{message} | /anchor/{anchor}/messages/disassociate/{message} [POST] |
| [**AnchorDisassociatePerson**](AnchorApi.md#anchordisassociateperson) | **POST** /anchor/{anchor}/persons/disassociate/{person} | /anchor/{anchor}/persons/disassociate/{person} [POST] |
| [**AnchorDisassociateWorkstreamSummary**](AnchorApi.md#anchordisassociateworkstreamsummary) | **POST** /anchor/{anchor}/workstream_summaries/disassociate/{workstream_summary} | /anchor/{anchor}/workstream_summaries/disassociate/{workstream_summary} [POST] |
| [**AnchorRename**](AnchorApi.md#anchorrename) | **POST** /anchor/{anchor}/rename | /anchor/{anchor}/rename [POST] |
| [**AnchorScoresIncrement**](AnchorApi.md#anchorscoresincrement) | **POST** /anchor/{anchor}/scores/increment | &#39;/anchor/{anchor}/scores/increment&#39; [POST] |
| [**AnchorSpecificAnchorSnapshot**](AnchorApi.md#anchorspecificanchorsnapshot) | **GET** /anchor/{anchor} | /anchor/{anchor} [GET] |
| [**AnchorUpdate**](AnchorApi.md#anchorupdate) | **POST** /anchor/update | /anchor/update [POST] |

<a id="anchorassociateasset"></a>
# **AnchorAssociateAsset**
> void AnchorAssociateAsset (string anchor, Guid asset)

/anchor/{anchor}/assets/associate/{asset} [POST]

associates an anchor and an asset. It performs the same action as the asset equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorAssociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /anchor/{anchor}/assets/associate/{asset} [POST]
                apiInstance.AnchorAssociateAsset(anchor, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorAssociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorAssociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/assets/associate/{asset} [POST]
    apiInstance.AnchorAssociateAssetWithHttpInfo(anchor, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorAssociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |

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

<a id="anchorassociateconversation"></a>
# **AnchorAssociateConversation**
> void AnchorAssociateConversation (string anchor, string conversation)

/anchor/{anchor}/conversations/associate/{conversation} [POST]

associates an anchor and a conversation. It performs the same action as the conversation equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorAssociateConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.

            try
            {
                // /anchor/{anchor}/conversations/associate/{conversation} [POST]
                apiInstance.AnchorAssociateConversation(anchor, conversation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorAssociateConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorAssociateConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/conversations/associate/{conversation} [POST]
    apiInstance.AnchorAssociateConversationWithHttpInfo(anchor, conversation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorAssociateConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **conversation** | **string** | This is the uuid of a conversation. |  |

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

<a id="anchorassociatemessage"></a>
# **AnchorAssociateMessage**
> void AnchorAssociateMessage (string anchor, string message)

/anchor/{anchor}/messages/associate/{message} [POST]

This will associate a anchor with a message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorAssociateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /anchor/{anchor}/messages/associate/{message} [POST]
                apiInstance.AnchorAssociateMessage(anchor, message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorAssociateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorAssociateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/messages/associate/{message} [POST]
    apiInstance.AnchorAssociateMessageWithHttpInfo(anchor, message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorAssociateMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **message** | **string** | This is the uuid of a message. |  |

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

<a id="anchorassociateperson"></a>
# **AnchorAssociatePerson**
> void AnchorAssociatePerson (string anchor, string person)

/anchor/{anchor}/persons/associate/{person} [POST]

associates an anchor and a person. It performs the same action as the person equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorAssociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /anchor/{anchor}/persons/associate/{person} [POST]
                apiInstance.AnchorAssociatePerson(anchor, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorAssociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorAssociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/persons/associate/{person} [POST]
    apiInstance.AnchorAssociatePersonWithHttpInfo(anchor, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorAssociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **person** | **string** | This is a uuid that represents a person. |  |

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

<a id="anchorassociateworkstreamsummary"></a>
# **AnchorAssociateWorkstreamSummary**
> void AnchorAssociateWorkstreamSummary (string anchor, string workstreamSummary)

/anchor/{anchor}/workstream_summaries/associate/{workstream_summary} [POST]

This will associate a anchor with a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorAssociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /anchor/{anchor}/workstream_summaries/associate/{workstream_summary} [POST]
                apiInstance.AnchorAssociateWorkstreamSummary(anchor, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorAssociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorAssociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/workstream_summaries/associate/{workstream_summary} [POST]
    apiInstance.AnchorAssociateWorkstreamSummaryWithHttpInfo(anchor, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorAssociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |

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

<a id="anchordisassociateasset"></a>
# **AnchorDisassociateAsset**
> void AnchorDisassociateAsset (string anchor, Guid asset)

/anchor/{anchor}/assets/disassociate/{asset} [POST]

Disassociates an anchor from an asset. It performs the same action as the asset equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorDisassociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /anchor/{anchor}/assets/disassociate/{asset} [POST]
                apiInstance.AnchorDisassociateAsset(anchor, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorDisassociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorDisassociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/assets/disassociate/{asset} [POST]
    apiInstance.AnchorDisassociateAssetWithHttpInfo(anchor, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorDisassociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |

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

<a id="anchordisassociateconversation"></a>
# **AnchorDisassociateConversation**
> void AnchorDisassociateConversation (string anchor, string conversation)

/anchor/{anchor}/conversations/disassociate/{conversation} [POST]

Disassociates an anchor from a conversation. It performs the same action as the conversation equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorDisassociateConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.

            try
            {
                // /anchor/{anchor}/conversations/disassociate/{conversation} [POST]
                apiInstance.AnchorDisassociateConversation(anchor, conversation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorDisassociateConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorDisassociateConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/conversations/disassociate/{conversation} [POST]
    apiInstance.AnchorDisassociateConversationWithHttpInfo(anchor, conversation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorDisassociateConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **conversation** | **string** | This is the uuid of a conversation. |  |

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

<a id="anchordisassociatemessage"></a>
# **AnchorDisassociateMessage**
> void AnchorDisassociateMessage (string anchor, string message)

/anchor/{anchor}/messages/disassociate/{message} [POST]

This will enable us to disassociate a anchor from a message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorDisassociateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /anchor/{anchor}/messages/disassociate/{message} [POST]
                apiInstance.AnchorDisassociateMessage(anchor, message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorDisassociateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorDisassociateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/messages/disassociate/{message} [POST]
    apiInstance.AnchorDisassociateMessageWithHttpInfo(anchor, message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorDisassociateMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **message** | **string** | This is the uuid of a message. |  |

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

<a id="anchordisassociateperson"></a>
# **AnchorDisassociatePerson**
> void AnchorDisassociatePerson (string anchor, string person)

/anchor/{anchor}/persons/disassociate/{person} [POST]

Disassociates an anchor from a person. It performs the same action as the person equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorDisassociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /anchor/{anchor}/persons/disassociate/{person} [POST]
                apiInstance.AnchorDisassociatePerson(anchor, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorDisassociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorDisassociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/persons/disassociate/{person} [POST]
    apiInstance.AnchorDisassociatePersonWithHttpInfo(anchor, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorDisassociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **person** | **string** | This is a uuid that represents a person. |  |

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

<a id="anchordisassociateworkstreamsummary"></a>
# **AnchorDisassociateWorkstreamSummary**
> void AnchorDisassociateWorkstreamSummary (string anchor, string workstreamSummary)

/anchor/{anchor}/workstream_summaries/disassociate/{workstream_summary} [POST]

This will enable us to disassociate a anchor from a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorDisassociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /anchor/{anchor}/workstream_summaries/disassociate/{workstream_summary} [POST]
                apiInstance.AnchorDisassociateWorkstreamSummary(anchor, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorDisassociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorDisassociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/workstream_summaries/disassociate/{workstream_summary} [POST]
    apiInstance.AnchorDisassociateWorkstreamSummaryWithHttpInfo(anchor, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorDisassociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |

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

<a id="anchorrename"></a>
# **AnchorRename**
> Anchor AnchorRename (string anchor, bool? transferables = null)

/anchor/{anchor}/rename [POST]

This will rename a specific anchor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorRenameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /anchor/{anchor}/rename [POST]
                Anchor result = apiInstance.AnchorRename(anchor, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorRename: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorRenameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor}/rename [POST]
    ApiResponse<Anchor> response = apiInstance.AnchorRenameWithHttpInfo(anchor, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorRenameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Anchor**](Anchor.md)

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

<a id="anchorscoresincrement"></a>
# **AnchorScoresIncrement**
> void AnchorScoresIncrement (string anchor, SeededScoreIncrement seededScoreIncrement = null)

'/anchor/{anchor}/scores/increment' [POST]

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
    public class AnchorScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/anchor/{anchor}/scores/increment' [POST]
                apiInstance.AnchorScoresIncrement(anchor, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/anchor/{anchor}/scores/increment' [POST]
    apiInstance.AnchorScoresIncrementWithHttpInfo(anchor, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
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

<a id="anchorspecificanchorsnapshot"></a>
# **AnchorSpecificAnchorSnapshot**
> Anchor AnchorSpecificAnchorSnapshot (string anchor, bool? transferables = null)

/anchor/{anchor} [GET]

This will get a snapshot of a single anchor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorSpecificAnchorSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /anchor/{anchor} [GET]
                Anchor result = apiInstance.AnchorSpecificAnchorSnapshot(anchor, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorSpecificAnchorSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorSpecificAnchorSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/{anchor} [GET]
    ApiResponse<Anchor> response = apiInstance.AnchorSpecificAnchorSnapshotWithHttpInfo(anchor, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorSpecificAnchorSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Anchor**](Anchor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | Anchor not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="anchorupdate"></a>
# **AnchorUpdate**
> Anchor AnchorUpdate (bool? transferables = null, Anchor anchor = null)

/anchor/update [POST]

This will update a specific anchor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var anchor = new Anchor(); // Anchor |  (optional) 

            try
            {
                // /anchor/update [POST]
                Anchor result = apiInstance.AnchorUpdate(transferables, anchor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorApi.AnchorUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchor/update [POST]
    ApiResponse<Anchor> response = apiInstance.AnchorUpdateWithHttpInfo(transferables, anchor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorApi.AnchorUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **anchor** | [**Anchor**](Anchor.md) |  | [optional]  |

### Return type

[**Anchor**](Anchor.md)

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

