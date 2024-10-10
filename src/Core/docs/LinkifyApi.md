# Pieces.Os.Core.Api.LinkifyApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Linkify**](LinkifyApi.md#linkify) | **POST** /linkify | /linkify [POST] |
| [**LinkifyMultiple**](LinkifyApi.md#linkifymultiple) | **POST** /linkify/multiple | /linkify/multiple [POST] |
| [**LinkifyShareRevoke**](LinkifyApi.md#linkifysharerevoke) | **POST** /linkify/{share}/revoke | [POST} /linkify/{share}/revoke |

<a id="linkify"></a>
# **Linkify**
> Shares Linkify (Linkify linkify = null)

/linkify [POST]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class LinkifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new LinkifyApi(config);
            var linkify = new Linkify(); // Linkify |  (optional) 

            try
            {
                // /linkify [POST]
                Shares result = apiInstance.Linkify(linkify);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkifyApi.Linkify: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkifyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /linkify [POST]
    ApiResponse<Shares> response = apiInstance.LinkifyWithHttpInfo(linkify);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkifyApi.LinkifyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linkify** | [**Linkify**](Linkify.md) |  | [optional]  |

### Return type

[**Shares**](Shares.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **412** | This means that Github Account has not been connected to this user yet. |  -  |
| **413** | Request Entity Too Large |  -  |
| **505** | HTTP Version Not Supported, This means that your user need to update their local os, and they cannot create a shareable link. |  -  |
| **511** | Network Authentication Required, This means that you user needs to be authenticated with OS inorder to create shareable links. The User also need to be connected to their cloud to create shareable links.(If either of the 2 are not connected we will return a 511)  TODO thinking about returning a more comprehensive value for digestion on the recieving side. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="linkifymultiple"></a>
# **LinkifyMultiple**
> Shares LinkifyMultiple (LinkifyMultiple linkifyMultiple = null)

/linkify/multiple [POST]

- assumption that you have already backed up the asset's that you are sending to this endpoint.(b/c the assets are ids.)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class LinkifyMultipleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new LinkifyApi(config);
            var linkifyMultiple = new LinkifyMultiple(); // LinkifyMultiple |  (optional) 

            try
            {
                // /linkify/multiple [POST]
                Shares result = apiInstance.LinkifyMultiple(linkifyMultiple);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkifyApi.LinkifyMultiple: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkifyMultipleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /linkify/multiple [POST]
    ApiResponse<Shares> response = apiInstance.LinkifyMultipleWithHttpInfo(linkifyMultiple);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkifyApi.LinkifyMultipleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linkifyMultiple** | [**LinkifyMultiple**](LinkifyMultiple.md) |  | [optional]  |

### Return type

[**Shares**](Shares.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **409** | If a name is passed in as an optional property, and the name is already take we will not be able to assign the name. |  -  |
| **413** | Request Entity Too Large |  -  |
| **417** | Expectation Failed, if this status is return that means that you did not fully upload all your assets that you are attempting to add to a collection. |  -  |
| **505** | HTTP Version Not Supported, This means that your user need to update their local os, and they cannot create a shareable link. |  -  |
| **511** | Network Authentication Required, This means that you user needs to be authenticated with OS inorder to create shareable links. The User also need to be connected to their cloud to create shareable links.(If either of the 2 are not connected we will return a 511)  TODO thinking about returning a more comprehensive value for digestion on the recieving side. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="linkifysharerevoke"></a>
# **LinkifyShareRevoke**
> string LinkifyShareRevoke (string share)

[POST} /linkify/{share}/revoke

This will revoke a link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class LinkifyShareRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new LinkifyApi(config);
            var share = "share_example";  // string | 

            try
            {
                // [POST} /linkify/{share}/revoke
                string result = apiInstance.LinkifyShareRevoke(share);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkifyApi.LinkifyShareRevoke: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkifyShareRevokeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [POST} /linkify/{share}/revoke
    ApiResponse<string> response = apiInstance.LinkifyShareRevokeWithHttpInfo(share);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinkifyApi.LinkifyShareRevokeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **share** | **string** |  |  |

### Return type

**string**

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK, this is the uuid of the share that was revoked. |  -  |
| **505** | HTTP Version Not Supported, This means that your user need to update their local os, and they cannot revoke a shareable link. |  -  |
| **511** | Network Authentication Required, This means that you user needs to be authenticated with OS inorder to create shareable links. The User also need to be connected to their cloud to create shareable links.(If either of the 2 are not connected we will return a 511)  TODO thinking about returning a more comprehensive value for digestion on the recieving side. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

