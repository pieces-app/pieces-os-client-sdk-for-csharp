# Pieces.Os.Core.Api.ConversationMessageApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MessageAssociateAnchor**](ConversationMessageApi.md#messageassociateanchor) | **POST** /message/{message}/anchors/associate/{anchor} | /message/{message}/anchors/associate/{anchor} [POST] |
| [**MessageAssociateAnnotation**](ConversationMessageApi.md#messageassociateannotation) | **POST** /message/{message}/annotations/associate/{annotation} | /message/{message}/annotations/associate/{annotation} [POST] |
| [**MessageAssociatePerson**](ConversationMessageApi.md#messageassociateperson) | **POST** /message/{message}/persons/associate/{person} | /message/{message}/persons/associate/{person} [POST] |
| [**MessageAssociateWebsite**](ConversationMessageApi.md#messageassociatewebsite) | **POST** /message/{message}/websites/associate/{website} | Associate a message with a website |
| [**MessageDisassociateAnchor**](ConversationMessageApi.md#messagedisassociateanchor) | **POST** /message/{message}/anchors/disassociate/{anchor} | /message/{message}/anchors/disassociate/{anchor} [POST] |
| [**MessageDisassociateAnnotation**](ConversationMessageApi.md#messagedisassociateannotation) | **POST** /message/{message}/annotations/disassociate/{annotation} | /message/{message}/annotations/disassociate/{annotation} [POST] |
| [**MessageDisassociatePerson**](ConversationMessageApi.md#messagedisassociateperson) | **POST** /message/{message}/persons/disassociate/{person} | /message/{message}/persons/disassociate/{person} [POST] |
| [**MessageDisassociateWebsite**](ConversationMessageApi.md#messagedisassociatewebsite) | **POST** /message/{message}/websites/disassociate/{website} | /message/{message}/websites/disassociate/{website} [POST] |
| [**MessageScoresIncrement**](ConversationMessageApi.md#messagescoresincrement) | **POST** /message/{message}/scores/increment | &#39;/message/{message}/scores/increment&#39; [POST] |
| [**MessageSpecificMessageSnapshot**](ConversationMessageApi.md#messagespecificmessagesnapshot) | **GET** /message/{message} | /message/{message} [GET] |
| [**MessageSpecificMessageUpdate**](ConversationMessageApi.md#messagespecificmessageupdate) | **POST** /message/update | /message/update [GET] |
| [**MessageUpdateValue**](ConversationMessageApi.md#messageupdatevalue) | **POST** /message/update/value | /message/update/value [POST] |

<a id="messageassociateanchor"></a>
# **MessageAssociateAnchor**
> void MessageAssociateAnchor (string message, string anchor)

/message/{message}/anchors/associate/{anchor} [POST]

This will associate a message with an anchor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageAssociateAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var message = "message_example";  // string | This is the uuid of a message.
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /message/{message}/anchors/associate/{anchor} [POST]
                apiInstance.MessageAssociateAnchor(message, anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageAssociateAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageAssociateAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /message/{message}/anchors/associate/{anchor} [POST]
    apiInstance.MessageAssociateAnchorWithHttpInfo(message, anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageAssociateAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | **string** | This is the uuid of a message. |  |
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

<a id="messageassociateannotation"></a>
# **MessageAssociateAnnotation**
> void MessageAssociateAnnotation (string annotation, string message)

/message/{message}/annotations/associate/{annotation} [POST]

This will associate a message with an annotation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageAssociateAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var annotation = "annotation_example";  // string | This is a specific annotation uuid.
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /message/{message}/annotations/associate/{annotation} [POST]
                apiInstance.MessageAssociateAnnotation(annotation, message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageAssociateAnnotation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageAssociateAnnotationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /message/{message}/annotations/associate/{annotation} [POST]
    apiInstance.MessageAssociateAnnotationWithHttpInfo(annotation, message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageAssociateAnnotationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **annotation** | **string** | This is a specific annotation uuid. |  |
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

<a id="messageassociateperson"></a>
# **MessageAssociatePerson**
> void MessageAssociatePerson (string message, string person)

/message/{message}/persons/associate/{person} [POST]

This will associate a message with a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageAssociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var message = "message_example";  // string | This is the uuid of a message.
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /message/{message}/persons/associate/{person} [POST]
                apiInstance.MessageAssociatePerson(message, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageAssociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageAssociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /message/{message}/persons/associate/{person} [POST]
    apiInstance.MessageAssociatePersonWithHttpInfo(message, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageAssociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | **string** | This is the uuid of a message. |  |
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

<a id="messageassociatewebsite"></a>
# **MessageAssociateWebsite**
> void MessageAssociateWebsite (string message, string website)

Associate a message with a website

This will associate a message with a website.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageAssociateWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var message = "message_example";  // string | This is the uuid of a message.
            var website = "website_example";  // string | website id

            try
            {
                // Associate a message with a website
                apiInstance.MessageAssociateWebsite(message, website);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageAssociateWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageAssociateWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Associate a message with a website
    apiInstance.MessageAssociateWebsiteWithHttpInfo(message, website);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageAssociateWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | **string** | This is the uuid of a message. |  |
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

<a id="messagedisassociateanchor"></a>
# **MessageDisassociateAnchor**
> void MessageDisassociateAnchor (string message, string anchor)

/message/{message}/anchors/disassociate/{anchor} [POST]

This will enable us to disassociate a message from an anchor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageDisassociateAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var message = "message_example";  // string | This is the uuid of a message.
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /message/{message}/anchors/disassociate/{anchor} [POST]
                apiInstance.MessageDisassociateAnchor(message, anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageDisassociateAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageDisassociateAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /message/{message}/anchors/disassociate/{anchor} [POST]
    apiInstance.MessageDisassociateAnchorWithHttpInfo(message, anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageDisassociateAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | **string** | This is the uuid of a message. |  |
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

<a id="messagedisassociateannotation"></a>
# **MessageDisassociateAnnotation**
> void MessageDisassociateAnnotation (string annotation, string message)

/message/{message}/annotations/disassociate/{annotation} [POST]

This will enable us to dissassociate a message from an annotation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageDisassociateAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var annotation = "annotation_example";  // string | This is a specific annotation uuid.
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /message/{message}/annotations/disassociate/{annotation} [POST]
                apiInstance.MessageDisassociateAnnotation(annotation, message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageDisassociateAnnotation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageDisassociateAnnotationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /message/{message}/annotations/disassociate/{annotation} [POST]
    apiInstance.MessageDisassociateAnnotationWithHttpInfo(annotation, message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageDisassociateAnnotationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **annotation** | **string** | This is a specific annotation uuid. |  |
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

<a id="messagedisassociateperson"></a>
# **MessageDisassociatePerson**
> void MessageDisassociatePerson (string message, string person)

/message/{message}/persons/disassociate/{person} [POST]

This will enable us to disassociate a message from a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageDisassociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var message = "message_example";  // string | This is the uuid of a message.
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /message/{message}/persons/disassociate/{person} [POST]
                apiInstance.MessageDisassociatePerson(message, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageDisassociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageDisassociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /message/{message}/persons/disassociate/{person} [POST]
    apiInstance.MessageDisassociatePersonWithHttpInfo(message, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageDisassociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | **string** | This is the uuid of a message. |  |
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

<a id="messagedisassociatewebsite"></a>
# **MessageDisassociateWebsite**
> void MessageDisassociateWebsite (string message, string website)

/message/{message}/websites/disassociate/{website} [POST]

This will enable us to disassociate a message from a website.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageDisassociateWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var message = "message_example";  // string | This is the uuid of a message.
            var website = "website_example";  // string | website id

            try
            {
                // /message/{message}/websites/disassociate/{website} [POST]
                apiInstance.MessageDisassociateWebsite(message, website);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageDisassociateWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageDisassociateWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /message/{message}/websites/disassociate/{website} [POST]
    apiInstance.MessageDisassociateWebsiteWithHttpInfo(message, website);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageDisassociateWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | **string** | This is the uuid of a message. |  |
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

<a id="messagescoresincrement"></a>
# **MessageScoresIncrement**
> void MessageScoresIncrement (string message, SeededScoreIncrement seededScoreIncrement = null)

'/message/{message}/scores/increment' [POST]

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
    public class MessageScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var message = "message_example";  // string | This is the uuid of a message.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/message/{message}/scores/increment' [POST]
                apiInstance.MessageScoresIncrement(message, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/message/{message}/scores/increment' [POST]
    apiInstance.MessageScoresIncrementWithHttpInfo(message, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | **string** | This is the uuid of a message. |  |
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

<a id="messagespecificmessagesnapshot"></a>
# **MessageSpecificMessageSnapshot**
> ConversationMessage MessageSpecificMessageSnapshot (string message, bool? transferables = null)

/message/{message} [GET]

This will get a specific snapshot of a message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageSpecificMessageSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var message = "message_example";  // string | This is the uuid of a message.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /message/{message} [GET]
                ConversationMessage result = apiInstance.MessageSpecificMessageSnapshot(message, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageSpecificMessageSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageSpecificMessageSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /message/{message} [GET]
    ApiResponse<ConversationMessage> response = apiInstance.MessageSpecificMessageSnapshotWithHttpInfo(message, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageSpecificMessageSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | **string** | This is the uuid of a message. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**ConversationMessage**](ConversationMessage.md)

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

<a id="messagespecificmessageupdate"></a>
# **MessageSpecificMessageUpdate**
> ConversationMessage MessageSpecificMessageUpdate (bool? transferables = null, ConversationMessage conversationMessage = null)

/message/update [GET]

This will update a conversation message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageSpecificMessageUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var conversationMessage = new ConversationMessage(); // ConversationMessage |  (optional) 

            try
            {
                // /message/update [GET]
                ConversationMessage result = apiInstance.MessageSpecificMessageUpdate(transferables, conversationMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageSpecificMessageUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageSpecificMessageUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /message/update [GET]
    ApiResponse<ConversationMessage> response = apiInstance.MessageSpecificMessageUpdateWithHttpInfo(transferables, conversationMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageSpecificMessageUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **conversationMessage** | [**ConversationMessage**](ConversationMessage.md) |  | [optional]  |

### Return type

[**ConversationMessage**](ConversationMessage.md)

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

<a id="messageupdatevalue"></a>
# **MessageUpdateValue**
> ConversationMessage MessageUpdateValue (bool? transferables = null, ConversationMessage conversationMessage = null)

/message/update/value [POST]

This will update the value of a conversation message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessageUpdateValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new ConversationMessageApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var conversationMessage = new ConversationMessage(); // ConversationMessage |  (optional) 

            try
            {
                // /message/update/value [POST]
                ConversationMessage result = apiInstance.MessageUpdateValue(transferables, conversationMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessageApi.MessageUpdateValue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageUpdateValueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /message/update/value [POST]
    ApiResponse<ConversationMessage> response = apiInstance.MessageUpdateValueWithHttpInfo(transferables, conversationMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessageApi.MessageUpdateValueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **conversationMessage** | [**ConversationMessage**](ConversationMessage.md) |  | [optional]  |

### Return type

[**ConversationMessage**](ConversationMessage.md)

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

