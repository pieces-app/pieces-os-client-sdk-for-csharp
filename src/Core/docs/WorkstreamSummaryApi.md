# Pieces.Os.Core.Api.WorkstreamSummaryApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkstreamSummariesSpecificWorkstreamSummarySnapshot**](WorkstreamSummaryApi.md#workstreamsummariesspecificworkstreamsummarysnapshot) | **GET** /workstream_summary/{workstream_summary} | /workstream_summary/{workstream_summary} [GET] |
| [**WorkstreamSummaryAssociateAnchor**](WorkstreamSummaryApi.md#workstreamsummaryassociateanchor) | **POST** /workstream_summary/{workstream_summary}/anchors/associate/{anchor} | /workstream_summary/{workstream_summary}/anchors/associate/{anchor} [POST] |
| [**WorkstreamSummaryAssociateAsset**](WorkstreamSummaryApi.md#workstreamsummaryassociateasset) | **POST** /workstream_summary/{workstream_summary}/assets/associate/{asset} | /workstream_summary/{workstream_summary}/assets/associate/{asset} [POST] |
| [**WorkstreamSummaryAssociateConversation**](WorkstreamSummaryApi.md#workstreamsummaryassociateconversation) | **POST** /workstream_summary/{workstream_summary}/conversations/associate/{conversation} | /workstream_summary/{workstream_summary}/conversations/associate/{conversation} [POST] |
| [**WorkstreamSummaryAssociatePerson**](WorkstreamSummaryApi.md#workstreamsummaryassociateperson) | **POST** /workstream_summary/{workstream_summary}/persons/associate/{person} | /workstream_summary/{workstream_summary}/persons/associate/{person} [POST] |
| [**WorkstreamSummaryAssociateRange**](WorkstreamSummaryApi.md#workstreamsummaryassociaterange) | **POST** /workstream_summary/{workstream_summary}/ranges/associate/{range} | /workstream_summary/{workstream_summary}/ranges/associate/{range} [POST] |
| [**WorkstreamSummaryAssociateWebsite**](WorkstreamSummaryApi.md#workstreamsummaryassociatewebsite) | **POST** /workstream_summary/{workstream_summary}/websites/associate/{website} | /workstream_summary/{workstream_summary}/websites/associate/{website} [POST] |
| [**WorkstreamSummaryAssociateWorkstreamEvent**](WorkstreamSummaryApi.md#workstreamsummaryassociateworkstreamevent) | **POST** /workstream_summary/{workstream_summary}/workstream_events/associate/{workstream_event} | /workstream_summary/{workstream_summary}/workstream_events/associate/{workstream_event} [POST] |
| [**WorkstreamSummaryDisassociateAnchor**](WorkstreamSummaryApi.md#workstreamsummarydisassociateanchor) | **POST** /workstream_summary/{workstream_summary}/anchors/disassociate/{anchor} | /workstream_summary/{workstream_summary}/anchors/disassociate/{anchor} [POST] |
| [**WorkstreamSummaryDisassociateAsset**](WorkstreamSummaryApi.md#workstreamsummarydisassociateasset) | **POST** /workstream_summary/{workstream_summary}/assets/disassociate/{asset} | /workstream_summary/{workstream_summary}/assets/disassociate/{asset} [POST] |
| [**WorkstreamSummaryDisassociateConversation**](WorkstreamSummaryApi.md#workstreamsummarydisassociateconversation) | **POST** /workstream_summary/{workstream_summary}/conversations/disassociate/{conversation} | /workstream_summary/{workstream_summary}/conversations/disassociate/{conversation} [POST] |
| [**WorkstreamSummaryDisassociatePerson**](WorkstreamSummaryApi.md#workstreamsummarydisassociateperson) | **POST** /workstream_summary/{workstream_summary}/persons/disassociate/{person} | /workstream_summary/{workstream_summary}/persons/disassociate/{person} [POST] |
| [**WorkstreamSummaryDisassociateRange**](WorkstreamSummaryApi.md#workstreamsummarydisassociaterange) | **POST** /workstream_summary/{workstream_summary}/ranges/disassociate/{range} | /workstream_summary/{workstream_summary}/ranges/disassociate/{range} [POST] |
| [**WorkstreamSummaryDisassociateWebsite**](WorkstreamSummaryApi.md#workstreamsummarydisassociatewebsite) | **POST** /workstream_summary/{workstream_summary}/websites/disassociate/{website} | /workstream_summary/{workstream_summary}/websites/disassociate/{website} [POST] |
| [**WorkstreamSummaryDisassociateWorkstreamEvent**](WorkstreamSummaryApi.md#workstreamsummarydisassociateworkstreamevent) | **POST** /workstream_summary/{workstream_summary}/workstream_events/disassociate/{workstream_event} | /workstream_summary/{workstream_summary}/workstream_events/disassociate/{workstream_event} [POST] |
| [**WorkstreamSummaryScoresIncrement**](WorkstreamSummaryApi.md#workstreamsummaryscoresincrement) | **POST** /workstream_summary/{workstream_summary}/scores/increment | &#39;/workstream_summary/{workstream_summary}/scores/increment&#39; [POST] |
| [**WorkstreamSummaryUpdate**](WorkstreamSummaryApi.md#workstreamsummaryupdate) | **POST** /workstream_summary/update | /workstream_summary/update [POST] |

<a id="workstreamsummariesspecificworkstreamsummarysnapshot"></a>
# **WorkstreamSummariesSpecificWorkstreamSummarySnapshot**
> WorkstreamSummary WorkstreamSummariesSpecificWorkstreamSummarySnapshot (string workstreamSummary, bool? transferables = null)

/workstream_summary/{workstream_summary} [GET]

This will get a snapshot of a single workstream_summary.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummariesSpecificWorkstreamSummarySnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /workstream_summary/{workstream_summary} [GET]
                WorkstreamSummary result = apiInstance.WorkstreamSummariesSpecificWorkstreamSummarySnapshot(workstreamSummary, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummariesSpecificWorkstreamSummarySnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummariesSpecificWorkstreamSummarySnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary} [GET]
    ApiResponse<WorkstreamSummary> response = apiInstance.WorkstreamSummariesSpecificWorkstreamSummarySnapshotWithHttpInfo(workstreamSummary, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummariesSpecificWorkstreamSummarySnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**WorkstreamSummary**](WorkstreamSummary.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | WorkstreamSummary not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workstreamsummaryassociateanchor"></a>
# **WorkstreamSummaryAssociateAnchor**
> void WorkstreamSummaryAssociateAnchor (string workstreamSummary, string anchor)

/workstream_summary/{workstream_summary}/anchors/associate/{anchor} [POST]

This will associate a anchor with a workstream_summary. This will do the same thing as the anchor equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryAssociateAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /workstream_summary/{workstream_summary}/anchors/associate/{anchor} [POST]
                apiInstance.WorkstreamSummaryAssociateAnchor(workstreamSummary, anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryAssociateAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/anchors/associate/{anchor} [POST]
    apiInstance.WorkstreamSummaryAssociateAnchorWithHttpInfo(workstreamSummary, anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummaryassociateasset"></a>
# **WorkstreamSummaryAssociateAsset**
> void WorkstreamSummaryAssociateAsset (string workstreamSummary, Guid asset)

/workstream_summary/{workstream_summary}/assets/associate/{asset} [POST]

This will associate an asset with a workstream_summary. This will do the same thing as the asset equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryAssociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /workstream_summary/{workstream_summary}/assets/associate/{asset} [POST]
                apiInstance.WorkstreamSummaryAssociateAsset(workstreamSummary, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryAssociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/assets/associate/{asset} [POST]
    apiInstance.WorkstreamSummaryAssociateAssetWithHttpInfo(workstreamSummary, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummaryassociateconversation"></a>
# **WorkstreamSummaryAssociateConversation**
> void WorkstreamSummaryAssociateConversation (string workstreamSummary, string conversation)

/workstream_summary/{workstream_summary}/conversations/associate/{conversation} [POST]

This will associate an conversation with a workstream_summary. This will do the same thing as the conversation equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryAssociateConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.

            try
            {
                // /workstream_summary/{workstream_summary}/conversations/associate/{conversation} [POST]
                apiInstance.WorkstreamSummaryAssociateConversation(workstreamSummary, conversation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryAssociateConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/conversations/associate/{conversation} [POST]
    apiInstance.WorkstreamSummaryAssociateConversationWithHttpInfo(workstreamSummary, conversation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummaryassociateperson"></a>
# **WorkstreamSummaryAssociatePerson**
> void WorkstreamSummaryAssociatePerson (string workstreamSummary, string person)

/workstream_summary/{workstream_summary}/persons/associate/{person} [POST]

This will associate an person with a workstream_summary. This will do the same thing as the person equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryAssociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /workstream_summary/{workstream_summary}/persons/associate/{person} [POST]
                apiInstance.WorkstreamSummaryAssociatePerson(workstreamSummary, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryAssociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/persons/associate/{person} [POST]
    apiInstance.WorkstreamSummaryAssociatePersonWithHttpInfo(workstreamSummary, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummaryassociaterange"></a>
# **WorkstreamSummaryAssociateRange**
> void WorkstreamSummaryAssociateRange (string workstreamSummary, string range)

/workstream_summary/{workstream_summary}/ranges/associate/{range} [POST]

This will associate a range with a workstream_summary. This will do the same thing as the range equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryAssociateRangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var range = "range_example";  // string | This is a identifier that is used to identify a specific range.

            try
            {
                // /workstream_summary/{workstream_summary}/ranges/associate/{range} [POST]
                apiInstance.WorkstreamSummaryAssociateRange(workstreamSummary, range);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateRange: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryAssociateRangeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/ranges/associate/{range} [POST]
    apiInstance.WorkstreamSummaryAssociateRangeWithHttpInfo(workstreamSummary, range);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateRangeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummaryassociatewebsite"></a>
# **WorkstreamSummaryAssociateWebsite**
> void WorkstreamSummaryAssociateWebsite (string workstreamSummary, string website)

/workstream_summary/{workstream_summary}/websites/associate/{website} [POST]

This will associate a website with a workstream_summary. This will do the same thing as the website equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryAssociateWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var website = "website_example";  // string | website id

            try
            {
                // /workstream_summary/{workstream_summary}/websites/associate/{website} [POST]
                apiInstance.WorkstreamSummaryAssociateWebsite(workstreamSummary, website);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryAssociateWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/websites/associate/{website} [POST]
    apiInstance.WorkstreamSummaryAssociateWebsiteWithHttpInfo(workstreamSummary, website);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummaryassociateworkstreamevent"></a>
# **WorkstreamSummaryAssociateWorkstreamEvent**
> void WorkstreamSummaryAssociateWorkstreamEvent (string workstreamSummary, string workstreamEvent)

/workstream_summary/{workstream_summary}/workstream_events/associate/{workstream_event} [POST]

This will associate a workstream_summary with a workstream_event. This will do the same thing as the workstream_event equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryAssociateWorkstreamEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var workstreamEvent = "workstreamEvent_example";  // string | This is a identifier that is used to identify a specific workstream_event.

            try
            {
                // /workstream_summary/{workstream_summary}/workstream_events/associate/{workstream_event} [POST]
                apiInstance.WorkstreamSummaryAssociateWorkstreamEvent(workstreamSummary, workstreamEvent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateWorkstreamEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryAssociateWorkstreamEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/workstream_events/associate/{workstream_event} [POST]
    apiInstance.WorkstreamSummaryAssociateWorkstreamEventWithHttpInfo(workstreamSummary, workstreamEvent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryAssociateWorkstreamEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
| **workstreamEvent** | **string** | This is a identifier that is used to identify a specific workstream_event. |  |

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

<a id="workstreamsummarydisassociateanchor"></a>
# **WorkstreamSummaryDisassociateAnchor**
> void WorkstreamSummaryDisassociateAnchor (string workstreamSummary, string anchor)

/workstream_summary/{workstream_summary}/anchors/disassociate/{anchor} [POST]

This will enable us to disassociate a anchor from a workstream_summary. This will do the same thing as the anchor equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryDisassociateAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /workstream_summary/{workstream_summary}/anchors/disassociate/{anchor} [POST]
                apiInstance.WorkstreamSummaryDisassociateAnchor(workstreamSummary, anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryDisassociateAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/anchors/disassociate/{anchor} [POST]
    apiInstance.WorkstreamSummaryDisassociateAnchorWithHttpInfo(workstreamSummary, anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummarydisassociateasset"></a>
# **WorkstreamSummaryDisassociateAsset**
> void WorkstreamSummaryDisassociateAsset (string workstreamSummary, Guid asset)

/workstream_summary/{workstream_summary}/assets/disassociate/{asset} [POST]

This will enable us to disassociate a asset from a workstream_summary. This will do the same thing as the asset equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryDisassociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /workstream_summary/{workstream_summary}/assets/disassociate/{asset} [POST]
                apiInstance.WorkstreamSummaryDisassociateAsset(workstreamSummary, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryDisassociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/assets/disassociate/{asset} [POST]
    apiInstance.WorkstreamSummaryDisassociateAssetWithHttpInfo(workstreamSummary, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummarydisassociateconversation"></a>
# **WorkstreamSummaryDisassociateConversation**
> void WorkstreamSummaryDisassociateConversation (string workstreamSummary, string conversation)

/workstream_summary/{workstream_summary}/conversations/disassociate/{conversation} [POST]

This will enable us to disassociate a conversation from a workstream_summary. This will do the same thing as the conversation equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryDisassociateConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.

            try
            {
                // /workstream_summary/{workstream_summary}/conversations/disassociate/{conversation} [POST]
                apiInstance.WorkstreamSummaryDisassociateConversation(workstreamSummary, conversation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryDisassociateConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/conversations/disassociate/{conversation} [POST]
    apiInstance.WorkstreamSummaryDisassociateConversationWithHttpInfo(workstreamSummary, conversation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummarydisassociateperson"></a>
# **WorkstreamSummaryDisassociatePerson**
> void WorkstreamSummaryDisassociatePerson (string workstreamSummary, string person)

/workstream_summary/{workstream_summary}/persons/disassociate/{person} [POST]

This will enable us to disassociate a person from a workstream_summary. This will do the same thing as the person equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryDisassociatePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var person = "person_example";  // string | This is a uuid that represents a person.

            try
            {
                // /workstream_summary/{workstream_summary}/persons/disassociate/{person} [POST]
                apiInstance.WorkstreamSummaryDisassociatePerson(workstreamSummary, person);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociatePerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryDisassociatePersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/persons/disassociate/{person} [POST]
    apiInstance.WorkstreamSummaryDisassociatePersonWithHttpInfo(workstreamSummary, person);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociatePersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummarydisassociaterange"></a>
# **WorkstreamSummaryDisassociateRange**
> void WorkstreamSummaryDisassociateRange (string workstreamSummary, string range)

/workstream_summary/{workstream_summary}/ranges/disassociate/{range} [POST]

This will enable us to disassociate a range from a workstream_summary. This will do the same thing as the range equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryDisassociateRangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var range = "range_example";  // string | This is a identifier that is used to identify a specific range.

            try
            {
                // /workstream_summary/{workstream_summary}/ranges/disassociate/{range} [POST]
                apiInstance.WorkstreamSummaryDisassociateRange(workstreamSummary, range);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateRange: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryDisassociateRangeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/ranges/disassociate/{range} [POST]
    apiInstance.WorkstreamSummaryDisassociateRangeWithHttpInfo(workstreamSummary, range);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateRangeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummarydisassociatewebsite"></a>
# **WorkstreamSummaryDisassociateWebsite**
> void WorkstreamSummaryDisassociateWebsite (string workstreamSummary, string website)

/workstream_summary/{workstream_summary}/websites/disassociate/{website} [POST]

This will enable us to disassociate a website from a workstream_summary. This will do the same thing as the website equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryDisassociateWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var website = "website_example";  // string | website id

            try
            {
                // /workstream_summary/{workstream_summary}/websites/disassociate/{website} [POST]
                apiInstance.WorkstreamSummaryDisassociateWebsite(workstreamSummary, website);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryDisassociateWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/websites/disassociate/{website} [POST]
    apiInstance.WorkstreamSummaryDisassociateWebsiteWithHttpInfo(workstreamSummary, website);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummarydisassociateworkstreamevent"></a>
# **WorkstreamSummaryDisassociateWorkstreamEvent**
> void WorkstreamSummaryDisassociateWorkstreamEvent (string workstreamSummary, string workstreamEvent)

/workstream_summary/{workstream_summary}/workstream_events/disassociate/{workstream_event} [POST]

This will enable us to disassociate a workstream_summary from a workstream_event. This will do the same thing as the workstream_event equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryDisassociateWorkstreamEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var workstreamEvent = "workstreamEvent_example";  // string | This is a identifier that is used to identify a specific workstream_event.

            try
            {
                // /workstream_summary/{workstream_summary}/workstream_events/disassociate/{workstream_event} [POST]
                apiInstance.WorkstreamSummaryDisassociateWorkstreamEvent(workstreamSummary, workstreamEvent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateWorkstreamEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryDisassociateWorkstreamEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/{workstream_summary}/workstream_events/disassociate/{workstream_event} [POST]
    apiInstance.WorkstreamSummaryDisassociateWorkstreamEventWithHttpInfo(workstreamSummary, workstreamEvent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryDisassociateWorkstreamEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
| **workstreamEvent** | **string** | This is a identifier that is used to identify a specific workstream_event. |  |

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

<a id="workstreamsummaryscoresincrement"></a>
# **WorkstreamSummaryScoresIncrement**
> void WorkstreamSummaryScoresIncrement (string workstreamSummary, SeededScoreIncrement seededScoreIncrement = null)

'/workstream_summary/{workstream_summary}/scores/increment' [POST]

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
    public class WorkstreamSummaryScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/workstream_summary/{workstream_summary}/scores/increment' [POST]
                apiInstance.WorkstreamSummaryScoresIncrement(workstreamSummary, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/workstream_summary/{workstream_summary}/scores/increment' [POST]
    apiInstance.WorkstreamSummaryScoresIncrementWithHttpInfo(workstreamSummary, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workstreamSummary** | **string** | This is a identifier that is used to identify a specific workstream_summary. |  |
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

<a id="workstreamsummaryupdate"></a>
# **WorkstreamSummaryUpdate**
> WorkstreamSummary WorkstreamSummaryUpdate (bool? transferables = null, WorkstreamSummary workstreamSummary = null)

/workstream_summary/update [POST]

This will update a specific workstream_summary.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class WorkstreamSummaryUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new WorkstreamSummaryApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var workstreamSummary = new WorkstreamSummary(); // WorkstreamSummary |  (optional) 

            try
            {
                // /workstream_summary/update [POST]
                WorkstreamSummary result = apiInstance.WorkstreamSummaryUpdate(transferables, workstreamSummary);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkstreamSummaryUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /workstream_summary/update [POST]
    ApiResponse<WorkstreamSummary> response = apiInstance.WorkstreamSummaryUpdateWithHttpInfo(transferables, workstreamSummary);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkstreamSummaryApi.WorkstreamSummaryUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **workstreamSummary** | [**WorkstreamSummary**](WorkstreamSummary.md) |  | [optional]  |

### Return type

[**WorkstreamSummary**](WorkstreamSummary.md)

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

