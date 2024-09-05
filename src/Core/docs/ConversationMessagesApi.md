# Pieces.Os.Core.Api.ConversationMessagesApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConversationMessagesStreamIdentifiers**](ConversationMessagesApi.md#conversationmessagesstreamidentifiers) | **GET** /messages/stream/identifiers | /messages/stream/identifiers [WS] |
| [**MessagesCreateSpecificMessage**](ConversationMessagesApi.md#messagescreatespecificmessage) | **POST** /messages/create | /messages/create [POST] |
| [**MessagesDeleteSpecificMessage**](ConversationMessagesApi.md#messagesdeletespecificmessage) | **POST** /messages/{message}/delete | /messages/{message}/delete [POST] |
| [**MessagesSnapshot**](ConversationMessagesApi.md#messagessnapshot) | **GET** /messages | /messages [GET] |
| [**SearchMessages**](ConversationMessagesApi.md#searchmessages) | **POST** /messages/search | /messages/search [POST] |

<a id="conversationmessagesstreamidentifiers"></a>
# **ConversationMessagesStreamIdentifiers**
> StreamedIdentifiers ConversationMessagesStreamIdentifiers ()

/messages/stream/identifiers [WS]

Provides a WebSocket connection that emits changes to your conversation messages identifiers (UUIDs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConversationMessagesStreamIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConversationMessagesApi(config);

            try
            {
                // /messages/stream/identifiers [WS]
                StreamedIdentifiers result = apiInstance.ConversationMessagesStreamIdentifiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessagesApi.ConversationMessagesStreamIdentifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConversationMessagesStreamIdentifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /messages/stream/identifiers [WS]
    ApiResponse<StreamedIdentifiers> response = apiInstance.ConversationMessagesStreamIdentifiersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessagesApi.ConversationMessagesStreamIdentifiersWithHttpInfo: " + e.Message);
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

<a id="messagescreatespecificmessage"></a>
# **MessagesCreateSpecificMessage**
> ConversationMessage MessagesCreateSpecificMessage (bool? transferables = null, SeededConversationMessage seededConversationMessage = null)

/messages/create [POST]

This will create a Message on a specific conversation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessagesCreateSpecificMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConversationMessagesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seededConversationMessage = new SeededConversationMessage(); // SeededConversationMessage |  (optional) 

            try
            {
                // /messages/create [POST]
                ConversationMessage result = apiInstance.MessagesCreateSpecificMessage(transferables, seededConversationMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessagesApi.MessagesCreateSpecificMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesCreateSpecificMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /messages/create [POST]
    ApiResponse<ConversationMessage> response = apiInstance.MessagesCreateSpecificMessageWithHttpInfo(transferables, seededConversationMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessagesApi.MessagesCreateSpecificMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seededConversationMessage** | [**SeededConversationMessage**](SeededConversationMessage.md) |  | [optional]  |

### Return type

[**ConversationMessage**](ConversationMessage.md)

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

<a id="messagesdeletespecificmessage"></a>
# **MessagesDeleteSpecificMessage**
> void MessagesDeleteSpecificMessage (string message)

/messages/{message}/delete [POST]

This will delete a specific message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessagesDeleteSpecificMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConversationMessagesApi(config);
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /messages/{message}/delete [POST]
                apiInstance.MessagesDeleteSpecificMessage(message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessagesApi.MessagesDeleteSpecificMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesDeleteSpecificMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /messages/{message}/delete [POST]
    apiInstance.MessagesDeleteSpecificMessageWithHttpInfo(message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessagesApi.MessagesDeleteSpecificMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="messagessnapshot"></a>
# **MessagesSnapshot**
> ConversationMessages MessagesSnapshot (bool? transferables = null)

/messages [GET]

This will get all the messages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class MessagesSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConversationMessagesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /messages [GET]
                ConversationMessages result = apiInstance.MessagesSnapshot(transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessagesApi.MessagesSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /messages [GET]
    ApiResponse<ConversationMessages> response = apiInstance.MessagesSnapshotWithHttpInfo(transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessagesApi.MessagesSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**ConversationMessages**](ConversationMessages.md)

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

<a id="searchmessages"></a>
# **SearchMessages**
> SearchedConversationMessages SearchMessages (bool? transferables = null, SearchInput searchInput = null)

/messages/search [POST]

This will search your conversationMessages for a specific conversation_message  note: we will just search the conversation message values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SearchMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConversationMessagesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var searchInput = new SearchInput(); // SearchInput |  (optional) 

            try
            {
                // /messages/search [POST]
                SearchedConversationMessages result = apiInstance.SearchMessages(transferables, searchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationMessagesApi.SearchMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /messages/search [POST]
    ApiResponse<SearchedConversationMessages> response = apiInstance.SearchMessagesWithHttpInfo(transferables, searchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationMessagesApi.SearchMessagesWithHttpInfo: " + e.Message);
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

[**SearchedConversationMessages**](SearchedConversationMessages.md)

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

