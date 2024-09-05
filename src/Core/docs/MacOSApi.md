# Pieces.Os.Core.Api.MacOSApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssetsCreateNewAssetFromMacos**](MacOSApi.md#assetscreatenewassetfrommacos) | **POST** /macos/assets/create | /macos/assets/create [Post] |

<a id="assetscreatenewassetfrommacos"></a>
# **AssetsCreateNewAssetFromMacos**
> Asset AssetsCreateNewAssetFromMacos (SeededMacOSAsset seededMacOSAsset = null)

/macos/assets/create [Post]

Exposes an endpoint for the MacOS Services plugin to send over MacOS Specific Data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsCreateNewAssetFromMacosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new MacOSApi(config);
            var seededMacOSAsset = new SeededMacOSAsset(); // SeededMacOSAsset | A SeededMacosApplication which contains the value and an Application Instance (optional) 

            try
            {
                // /macos/assets/create [Post]
                Asset result = apiInstance.AssetsCreateNewAssetFromMacos(seededMacOSAsset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacOSApi.AssetsCreateNewAssetFromMacos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsCreateNewAssetFromMacosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /macos/assets/create [Post]
    ApiResponse<Asset> response = apiInstance.AssetsCreateNewAssetFromMacosWithHttpInfo(seededMacOSAsset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacOSApi.AssetsCreateNewAssetFromMacosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededMacOSAsset** | [**SeededMacOSAsset**](SeededMacOSAsset.md) | A SeededMacosApplication which contains the value and an Application Instance | [optional]  |

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

