# Pieces.Os.Core.Api.RangeApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RangeAssociateConversationGroundingTemporalRangeWorkstreams**](RangeApi.md#rangeassociateconversationgroundingtemporalrangeworkstreams) | **POST** /range/{range}/conversations/grounding/temporal_range/workstreams/associate/{conversation} | /range/{range}/conversations/grounding/temporal_range/workstreams/associate/{conversation} [POST] |
| [**RangeAssociateWorkstreamSummary**](RangeApi.md#rangeassociateworkstreamsummary) | **POST** /range/{range}/workstream_summaries/associate/{workstream_summary} | /range/{range}/workstream_summaries/associate/{workstream_summary} [POST] |
| [**RangeDisassociateConversationGroundingTemporalRangeWorkstreams**](RangeApi.md#rangedisassociateconversationgroundingtemporalrangeworkstreams) | **POST** /range/{range}/conversations/grounding/temporal_range/workstreams/disassociate/{conversation} | /range/{range}/conversations/grounding/temporal_range/workstreams/disassociate/{conversation} [POST] |
| [**RangeDisassociateWorkstreamSummary**](RangeApi.md#rangedisassociateworkstreamsummary) | **POST** /range/{range}/workstream_summaries/disassociate/{workstream_summary} | /range/{range}/workstream_summaries/disassociate/{workstream_summary} [POST] |
| [**RangeScoresIncrement**](RangeApi.md#rangescoresincrement) | **POST** /range/{range}/scores/increment | &#39;/range/{range}/scores/increment&#39; [POST] |
| [**RangeUpdate**](RangeApi.md#rangeupdate) | **POST** /range/update | /range/update [POST] |
| [**RangesSpecificRangeSnapshot**](RangeApi.md#rangesspecificrangesnapshot) | **GET** /range/{range} | /range/{range} [GET] |

<a id="rangeassociateconversationgroundingtemporalrangeworkstreams"></a>
# **RangeAssociateConversationGroundingTemporalRangeWorkstreams**
> void RangeAssociateConversationGroundingTemporalRangeWorkstreams (string range, string conversation)

/range/{range}/conversations/grounding/temporal_range/workstreams/associate/{conversation} [POST]

This will associate a range with a conversation(grounding.temporal.workstreams). This will do the same thing as the conversation equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class RangeAssociateConversationGroundingTemporalRangeWorkstreamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new RangeApi(config);
            var range = "range_example";  // string | This is a identifier that is used to identify a specific range.
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.

            try
            {
                // /range/{range}/conversations/grounding/temporal_range/workstreams/associate/{conversation} [POST]
                apiInstance.RangeAssociateConversationGroundingTemporalRangeWorkstreams(range, conversation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RangeApi.RangeAssociateConversationGroundingTemporalRangeWorkstreams: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RangeAssociateConversationGroundingTemporalRangeWorkstreamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /range/{range}/conversations/grounding/temporal_range/workstreams/associate/{conversation} [POST]
    apiInstance.RangeAssociateConversationGroundingTemporalRangeWorkstreamsWithHttpInfo(range, conversation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RangeApi.RangeAssociateConversationGroundingTemporalRangeWorkstreamsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **range** | **string** | This is a identifier that is used to identify a specific range. |  |
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

<a id="rangeassociateworkstreamsummary"></a>
# **RangeAssociateWorkstreamSummary**
> void RangeAssociateWorkstreamSummary (string range, string workstreamSummary)

/range/{range}/workstream_summaries/associate/{workstream_summary} [POST]

This will associate a range with a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class RangeAssociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new RangeApi(config);
            var range = "range_example";  // string | This is a identifier that is used to identify a specific range.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /range/{range}/workstream_summaries/associate/{workstream_summary} [POST]
                apiInstance.RangeAssociateWorkstreamSummary(range, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RangeApi.RangeAssociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RangeAssociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /range/{range}/workstream_summaries/associate/{workstream_summary} [POST]
    apiInstance.RangeAssociateWorkstreamSummaryWithHttpInfo(range, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RangeApi.RangeAssociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **range** | **string** | This is a identifier that is used to identify a specific range. |  |
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

<a id="rangedisassociateconversationgroundingtemporalrangeworkstreams"></a>
# **RangeDisassociateConversationGroundingTemporalRangeWorkstreams**
> void RangeDisassociateConversationGroundingTemporalRangeWorkstreams (string range, string conversation)

/range/{range}/conversations/grounding/temporal_range/workstreams/disassociate/{conversation} [POST]

This will enable us to disassociate a range from a conversation(grounding.temporal.workstreams). This will do the same thing as the conversation equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class RangeDisassociateConversationGroundingTemporalRangeWorkstreamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new RangeApi(config);
            var range = "range_example";  // string | This is a identifier that is used to identify a specific range.
            var conversation = "conversation_example";  // string | This is the uuid of a conversation.

            try
            {
                // /range/{range}/conversations/grounding/temporal_range/workstreams/disassociate/{conversation} [POST]
                apiInstance.RangeDisassociateConversationGroundingTemporalRangeWorkstreams(range, conversation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RangeApi.RangeDisassociateConversationGroundingTemporalRangeWorkstreams: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RangeDisassociateConversationGroundingTemporalRangeWorkstreamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /range/{range}/conversations/grounding/temporal_range/workstreams/disassociate/{conversation} [POST]
    apiInstance.RangeDisassociateConversationGroundingTemporalRangeWorkstreamsWithHttpInfo(range, conversation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RangeApi.RangeDisassociateConversationGroundingTemporalRangeWorkstreamsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **range** | **string** | This is a identifier that is used to identify a specific range. |  |
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

<a id="rangedisassociateworkstreamsummary"></a>
# **RangeDisassociateWorkstreamSummary**
> void RangeDisassociateWorkstreamSummary (string range, string workstreamSummary)

/range/{range}/workstream_summaries/disassociate/{workstream_summary} [POST]

This will enable us to disassociate a range from a workstream summary. This will do the same thing as the workstreamSummary equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class RangeDisassociateWorkstreamSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new RangeApi(config);
            var range = "range_example";  // string | This is a identifier that is used to identify a specific range.
            var workstreamSummary = "workstreamSummary_example";  // string | This is a identifier that is used to identify a specific workstream_summary.

            try
            {
                // /range/{range}/workstream_summaries/disassociate/{workstream_summary} [POST]
                apiInstance.RangeDisassociateWorkstreamSummary(range, workstreamSummary);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RangeApi.RangeDisassociateWorkstreamSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RangeDisassociateWorkstreamSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /range/{range}/workstream_summaries/disassociate/{workstream_summary} [POST]
    apiInstance.RangeDisassociateWorkstreamSummaryWithHttpInfo(range, workstreamSummary);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RangeApi.RangeDisassociateWorkstreamSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **range** | **string** | This is a identifier that is used to identify a specific range. |  |
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

<a id="rangescoresincrement"></a>
# **RangeScoresIncrement**
> void RangeScoresIncrement (string range, SeededScoreIncrement seededScoreIncrement = null)

'/range/{range}/scores/increment' [POST]

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
    public class RangeScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new RangeApi(config);
            var range = "range_example";  // string | This is a identifier that is used to identify a specific range.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/range/{range}/scores/increment' [POST]
                apiInstance.RangeScoresIncrement(range, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RangeApi.RangeScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RangeScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/range/{range}/scores/increment' [POST]
    apiInstance.RangeScoresIncrementWithHttpInfo(range, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RangeApi.RangeScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **range** | **string** | This is a identifier that is used to identify a specific range. |  |
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

<a id="rangeupdate"></a>
# **RangeUpdate**
> Range RangeUpdate (Range range = null)

/range/update [POST]

This will update a specific range.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class RangeUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new RangeApi(config);
            var range = new Range(); // Range |  (optional) 

            try
            {
                // /range/update [POST]
                Range result = apiInstance.RangeUpdate(range);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RangeApi.RangeUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RangeUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /range/update [POST]
    ApiResponse<Range> response = apiInstance.RangeUpdateWithHttpInfo(range);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RangeApi.RangeUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **range** | [**Range**](Range.md) |  | [optional]  |

### Return type

[**Range**](Range.md)

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

<a id="rangesspecificrangesnapshot"></a>
# **RangesSpecificRangeSnapshot**
> Range RangesSpecificRangeSnapshot (string range)

/range/{range} [GET]

This will get a snapshot of a single range.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class RangesSpecificRangeSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new RangeApi(config);
            var range = "range_example";  // string | This is a identifier that is used to identify a specific range.

            try
            {
                // /range/{range} [GET]
                Range result = apiInstance.RangesSpecificRangeSnapshot(range);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RangeApi.RangesSpecificRangeSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RangesSpecificRangeSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /range/{range} [GET]
    ApiResponse<Range> response = apiInstance.RangesSpecificRangeSnapshotWithHttpInfo(range);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RangeApi.RangesSpecificRangeSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **range** | **string** | This is a identifier that is used to identify a specific range. |  |

### Return type

[**Range**](Range.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **410** | Range not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

