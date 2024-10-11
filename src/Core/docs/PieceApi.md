# Pieces.Os.Core.Api.PieceApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HtmlShare**](PieceApi.md#htmlshare) | **GET** / | / [GET] |

<a id="htmlshare"></a>
# **HtmlShare**
> string HtmlShare (string p)

/ [GET]

This is a cloud only Api. This will get a preview of your publically accessble Piece.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class HtmlShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new PieceApi(config);
            var p = "p_example";  // string | this is the a query param, that a shortened version of the share.

            try
            {
                // / [GET]
                string result = apiInstance.HtmlShare(p);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PieceApi.HtmlShare: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HtmlShareWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // / [GET]
    ApiResponse<string> response = apiInstance.HtmlShareWithHttpInfo(p);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PieceApi.HtmlShareWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **p** | **string** | this is the a query param, that a shortened version of the share. |  |

### Return type

**string**

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

