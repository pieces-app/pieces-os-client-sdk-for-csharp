# Pieces.Os.Core.Api.UltraSuiteApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssetsCreateUltraSuiteAsset**](UltraSuiteApi.md#assetscreateultrasuiteasset) | **POST** /ultra_suite/assets/create | /ultra_suite/assets/create [POST] |

<a id="assetscreateultrasuiteasset"></a>
# **AssetsCreateUltraSuiteAsset**
> Asset AssetsCreateUltraSuiteAsset (SeededUltraSuiteAsset seededUltraSuiteAsset = null)

/ultra_suite/assets/create [POST]

This Endpoint will create an Asset that is sent from UltraSuite.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsCreateUltraSuiteAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new UltraSuiteApi(config);
            var seededUltraSuiteAsset = new SeededUltraSuiteAsset(); // SeededUltraSuiteAsset |  (optional) 

            try
            {
                // /ultra_suite/assets/create [POST]
                Asset result = apiInstance.AssetsCreateUltraSuiteAsset(seededUltraSuiteAsset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UltraSuiteApi.AssetsCreateUltraSuiteAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsCreateUltraSuiteAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /ultra_suite/assets/create [POST]
    ApiResponse<Asset> response = apiInstance.AssetsCreateUltraSuiteAssetWithHttpInfo(seededUltraSuiteAsset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UltraSuiteApi.AssetsCreateUltraSuiteAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededUltraSuiteAsset** | [**SeededUltraSuiteAsset**](SeededUltraSuiteAsset.md) |  | [optional]  |

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

