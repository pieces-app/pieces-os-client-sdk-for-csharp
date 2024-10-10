# Pieces.Os.Core.Api.PersonApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PersonAssociateAnchor**](PersonApi.md#personassociateanchor) | **POST** /person/{person}/anchors/associate/{anchor} | /person/{person}/anchors/associate/{anchor} [POST] |
| [**PersonAssociateAsset**](PersonApi.md#personassociateasset) | **POST** /person/{person}/assets/associate/{asset} | /person/{person}/assets/associate/{asset} [POST] |
| [**PersonAssociateMessage**](PersonApi.md#personassociatemessage) | **POST** /person/{person}/messages/associate/{message} | /person/{person}/messages/associate/{message} [POST] |
| [**PersonAssociateTag**](PersonApi.md#personassociatetag) | **POST** /person/{person}/tags/associate/{tag} | /person/{person}/tags/associate/{tag} [POST] |
| [**PersonAssociateWebsite**](PersonApi.md#personassociatewebsite) | **POST** /person/{person}/websites/associate/{website} | /person/{person}/websites/associate/{website} [POST] |
| [**PersonAssociateWorkstreamSummary**](PersonApi.md#personassociateworkstreamsummary) | **POST** /person/{person}/workstream_summaries/associate/{workstream_summary} | /person/{person}/workstream_summaries/associate/{workstream_summary} [POST] |
| [**PersonDisassociateAnchor**](PersonApi.md#persondisassociateanchor) | **POST** /person/{person}/anchors/disassociate/{anchor} | /person/{person}/anchors/disassociate/{anchor} [POST] |
| [**PersonDisassociateAsset**](PersonApi.md#persondisassociateasset) | **POST** /person/{person}/assets/disassociate/{asset} | /person/{person}/assets/disassociate/{asset} [POST] |
| [**PersonDisassociateMessage**](PersonApi.md#persondisassociatemessage) | **POST** /person/{person}/messages/disassociate/{message} | /person/{person}/messages/disassociate/{message} [POST] |
| [**PersonDisassociateTag**](PersonApi.md#persondisassociatetag) | **POST** /person/{person}/tags/disassociate/{tag} | /person/{person}/tags/disassociate/{tag} [POST] |
| [**PersonDisassociateWebsite**](PersonApi.md#persondisassociatewebsite) | **POST** /person/{person}/websites/disassociate/{website} | /person/{person}/websites/disassociate/{website} [POST] |
| [**PersonDisassociateWorkstreamSummary**](PersonApi.md#persondisassociateworkstreamsummary) | **POST** /person/{person}/workstream_summaries/disassociate/{workstream_summary} | /person/{person}/workstream_summaries/disassociate/{workstream_summary} [POST] |
| [**PersonScoresIncrement**](PersonApi.md#personscoresincrement) | **POST** /person/{person}/scores/increment | &#39;/person/{person}/scores/increment&#39; [POST] |
| [**PersonSnapshot**](PersonApi.md#personsnapshot) | **GET** /person/{person} | /person/{person} [GET] |
| [**UpdatePerson**](PersonApi.md#updateperson) | **POST** /person/update | /person/update [POST] |

<a id="personassociateanchor"></a>
# **PersonAssociateAnchor**
> void PersonAssociateAnchor (string person, string anchor)

/person/{person}/anchors/associate/{anchor} [POST]

associates a person and an anchor. It performs the same action as the anchor equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonAssociateAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /person/{person}/anchors/associate/{anchor} [POST]
                apiInstance.PersonAssociateAnchor(person, anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonAssociateAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonAssociateAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/anchors/associate/{anchor} [POST]
    apiInstance.PersonAssociateAnchorWithHttpInfo(person, anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonAssociateAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="personassociateasset"></a>
# **PersonAssociateAsset**
> void PersonAssociateAsset (string person, Guid asset)

/person/{person}/assets/associate/{asset} [POST]

associates a person and an asset. It performs the same action as the asset equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonAssociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /person/{person}/assets/associate/{asset} [POST]
                apiInstance.PersonAssociateAsset(person, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonAssociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonAssociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/assets/associate/{asset} [POST]
    apiInstance.PersonAssociateAssetWithHttpInfo(person, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonAssociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="personassociatemessage"></a>
# **PersonAssociateMessage**
> void PersonAssociateMessage (string person, string message)

/person/{person}/messages/associate/{message} [POST]

This will associate a person with a message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonAssociateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /person/{person}/messages/associate/{message} [POST]
                apiInstance.PersonAssociateMessage(person, message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonAssociateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonAssociateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/messages/associate/{message} [POST]
    apiInstance.PersonAssociateMessageWithHttpInfo(person, message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonAssociateMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="personassociatetag"></a>
# **PersonAssociateTag**
> void PersonAssociateTag (string person, string tag)

/person/{person}/tags/associate/{tag} [POST]

associates a tag and a person. It performs the same action as the tag equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonAssociateTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var tag = "tag_example";  // string | tag id

            try
            {
                // /person/{person}/tags/associate/{tag} [POST]
                apiInstance.PersonAssociateTag(person, tag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonAssociateTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonAssociateTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/tags/associate/{tag} [POST]
    apiInstance.PersonAssociateTagWithHttpInfo(person, tag);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonAssociateTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="personassociatewebsite"></a>
# **PersonAssociateWebsite**
> void PersonAssociateWebsite (string person, string website)

/person/{person}/websites/associate/{website} [POST]

associates a website and a person. It performs the same action as the website equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonAssociateWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var website = "website_example";  // string | website id

            try
            {
                // /person/{person}/websites/associate/{website} [POST]
                apiInstance.PersonAssociateWebsite(person, website);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonAssociateWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonAssociateWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/websites/associate/{website} [POST]
    apiInstance.PersonAssociateWebsiteWithHttpInfo(person, website);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonAssociateWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="personassociateworkstreamsummary"></a>
# **PersonAssociateWorkstreamSummary**
> void PersonAssociateWorkstreamSummary (string person, string workstreamSummary)

/person/{person}/workstream_summaries/associate/{workstream_summary} [POST]

This will associate a person with a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonAssociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /person/{person}/workstream_summaries/associate/{workstream_summary} [POST]
                apiInstance.PersonAssociateWorkstreamSummary(person, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonAssociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonAssociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/workstream_summaries/associate/{workstream_summary} [POST]
    apiInstance.PersonAssociateWorkstreamSummaryWithHttpInfo(person, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonAssociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="persondisassociateanchor"></a>
# **PersonDisassociateAnchor**
> void PersonDisassociateAnchor (string person, string anchor)

/person/{person}/anchors/disassociate/{anchor} [POST]

Disassociates a person from an achor. It performs the same action as the anchor equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonDisassociateAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /person/{person}/anchors/disassociate/{anchor} [POST]
                apiInstance.PersonDisassociateAnchor(person, anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonDisassociateAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonDisassociateAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/anchors/disassociate/{anchor} [POST]
    apiInstance.PersonDisassociateAnchorWithHttpInfo(person, anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonDisassociateAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="persondisassociateasset"></a>
# **PersonDisassociateAsset**
> void PersonDisassociateAsset (string person, Guid asset)

/person/{person}/assets/disassociate/{asset} [POST]

Disassociates a person from an asset. It performs the same action as the asset equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonDisassociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /person/{person}/assets/disassociate/{asset} [POST]
                apiInstance.PersonDisassociateAsset(person, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonDisassociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonDisassociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/assets/disassociate/{asset} [POST]
    apiInstance.PersonDisassociateAssetWithHttpInfo(person, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonDisassociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="persondisassociatemessage"></a>
# **PersonDisassociateMessage**
> void PersonDisassociateMessage (string person, string message)

/person/{person}/messages/disassociate/{message} [POST]

This will enable us to disassociate a person from a message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonDisassociateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var message = "message_example";  // string | This is the uuid of a message.

            try
            {
                // /person/{person}/messages/disassociate/{message} [POST]
                apiInstance.PersonDisassociateMessage(person, message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonDisassociateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonDisassociateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/messages/disassociate/{message} [POST]
    apiInstance.PersonDisassociateMessageWithHttpInfo(person, message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonDisassociateMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="persondisassociatetag"></a>
# **PersonDisassociateTag**
> void PersonDisassociateTag (string person, string tag)

/person/{person}/tags/disassociate/{tag} [POST]

Disassociates a person from a tag. It performs the same action as the tag equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonDisassociateTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var tag = "tag_example";  // string | tag id

            try
            {
                // /person/{person}/tags/disassociate/{tag} [POST]
                apiInstance.PersonDisassociateTag(person, tag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonDisassociateTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonDisassociateTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/tags/disassociate/{tag} [POST]
    apiInstance.PersonDisassociateTagWithHttpInfo(person, tag);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonDisassociateTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="persondisassociatewebsite"></a>
# **PersonDisassociateWebsite**
> void PersonDisassociateWebsite (string person, string website)

/person/{person}/websites/disassociate/{website} [POST]

Disassociates a person from a website. It performs the same action as the website equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonDisassociateWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var website = "website_example";  // string | website id

            try
            {
                // /person/{person}/websites/disassociate/{website} [POST]
                apiInstance.PersonDisassociateWebsite(person, website);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonDisassociateWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonDisassociateWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/websites/disassociate/{website} [POST]
    apiInstance.PersonDisassociateWebsiteWithHttpInfo(person, website);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonDisassociateWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="persondisassociateworkstreamsummary"></a>
# **PersonDisassociateWorkstreamSummary**
> void PersonDisassociateWorkstreamSummary (string person, string workstreamSummary)

/person/{person}/workstream_summaries/disassociate/{workstream_summary} [POST]

This will enable us to disassociate an person from a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonDisassociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /person/{person}/workstream_summaries/disassociate/{workstream_summary} [POST]
                apiInstance.PersonDisassociateWorkstreamSummary(person, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonDisassociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonDisassociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person}/workstream_summaries/disassociate/{workstream_summary} [POST]
    apiInstance.PersonDisassociateWorkstreamSummaryWithHttpInfo(person, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonDisassociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="personscoresincrement"></a>
# **PersonScoresIncrement**
> void PersonScoresIncrement (string person, SeededScoreIncrement seededScoreIncrement = null)

'/person/{person}/scores/increment' [POST]

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
    public class PersonScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/person/{person}/scores/increment' [POST]
                apiInstance.PersonScoresIncrement(person, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/person/{person}/scores/increment' [POST]
    apiInstance.PersonScoresIncrementWithHttpInfo(person, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
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

<a id="personsnapshot"></a>
# **PersonSnapshot**
> Person PersonSnapshot (string person, bool? transferables = null)

/person/{person} [GET]

This will get a snapshot of a specific person

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var person = "person_example";  // string | This is a uuid that represents a person.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /person/{person} [GET]
                Person result = apiInstance.PersonSnapshot(person, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.PersonSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/{person} [GET]
    ApiResponse<Person> response = apiInstance.PersonSnapshotWithHttpInfo(person, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.PersonSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **person** | **string** | This is a uuid that represents a person. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Person**](Person.md)

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

<a id="updateperson"></a>
# **UpdatePerson**
> Person UpdatePerson (bool? transferables = null, Person person = null)

/person/update [POST]

This will update a specific person

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class UpdatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PersonApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var person = new Person(); // Person |  (optional) 

            try
            {
                // /person/update [POST]
                Person result = apiInstance.UpdatePerson(transferables, person);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonApi.UpdatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /person/update [POST]
    ApiResponse<Person> response = apiInstance.UpdatePersonWithHttpInfo(transferables, person);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonApi.UpdatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **person** | [**Person**](Person.md) |  | [optional]  |

### Return type

[**Person**](Person.md)

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

