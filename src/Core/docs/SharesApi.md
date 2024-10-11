# Pieces.Os.Core.Api.SharesApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SharesCreateNewShare**](SharesApi.md#sharescreatenewshare) | **POST** /shares/create | /shares/create [POST] |
| [**SharesDeleteShare**](SharesApi.md#sharesdeleteshare) | **POST** /shares/{share}/delete | /shares/{share}/delete [POST] |
| [**SharesSnapshot**](SharesApi.md#sharessnapshot) | **GET** /shares | /shares [GET] |
| [**SharesSpecificShareSnapshot**](SharesApi.md#sharesspecificsharesnapshot) | **GET** /shares/{share} | /shares/{share} [GET] |

<a id="sharescreatenewshare"></a>
# **SharesCreateNewShare**
> Shares SharesCreateNewShare (bool? transferables = null, SeededShare seededShare = null)

/shares/create [POST]

This endpoint will accept an asset. Response here will be a Share that was created.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SharesCreateNewShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new SharesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seededShare = new SeededShare(); // SeededShare |  (optional) 

            try
            {
                // /shares/create [POST]
                Shares result = apiInstance.SharesCreateNewShare(transferables, seededShare);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharesApi.SharesCreateNewShare: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SharesCreateNewShareWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /shares/create [POST]
    ApiResponse<Shares> response = apiInstance.SharesCreateNewShareWithHttpInfo(transferables, seededShare);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharesApi.SharesCreateNewShareWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seededShare** | [**SeededShare**](SeededShare.md) |  | [optional]  |

### Return type

[**Shares**](Shares.md)

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

<a id="sharesdeleteshare"></a>
# **SharesDeleteShare**
> string SharesDeleteShare (string share)

/shares/{share}/delete [POST]

This endpoint will just take a share id(as a url param) to delete out of the shares table, will return the share id that was deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SharesDeleteShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new SharesApi(config);
            var share = "share_example";  // string | Share id

            try
            {
                // /shares/{share}/delete [POST]
                string result = apiInstance.SharesDeleteShare(share);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharesApi.SharesDeleteShare: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SharesDeleteShareWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /shares/{share}/delete [POST]
    ApiResponse<string> response = apiInstance.SharesDeleteShareWithHttpInfo(share);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharesApi.SharesDeleteShareWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **share** | **string** | Share id |  |

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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sharessnapshot"></a>
# **SharesSnapshot**
> Shares SharesSnapshot (bool? transferables = null)

/shares [GET]

This will return all of your shares. A Share is an asset that you as a user decided to share with another user via link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SharesSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new SharesApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /shares [GET]
                Shares result = apiInstance.SharesSnapshot(transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharesApi.SharesSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SharesSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /shares [GET]
    ApiResponse<Shares> response = apiInstance.SharesSnapshotWithHttpInfo(transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharesApi.SharesSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Shares**](Shares.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sharesspecificsharesnapshot"></a>
# **SharesSpecificShareSnapshot**
> Share SharesSpecificShareSnapshot (string share, bool? transferables = null)

/shares/{share} [GET]

This is an endpoint to enable a client to access a specific share through a provided share id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SharesSpecificShareSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new SharesApi(config);
            var share = "share_example";  // string | Share id
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /shares/{share} [GET]
                Share result = apiInstance.SharesSpecificShareSnapshot(share, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharesApi.SharesSpecificShareSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SharesSpecificShareSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /shares/{share} [GET]
    ApiResponse<Share> response = apiInstance.SharesSpecificShareSnapshotWithHttpInfo(share, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharesApi.SharesSpecificShareSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **share** | **string** | Share id |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Share**](Share.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific share per the provided share id. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

