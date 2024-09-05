# Pieces.Os.Core.Api.AssetsApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssetsCreateNewAsset**](AssetsApi.md#assetscreatenewasset) | **POST** /assets/create | /assets/create [POST] Scoped to Asset |
| [**AssetsDeleteAsset**](AssetsApi.md#assetsdeleteasset) | **POST** /assets/{asset}/delete | /assets/{asset}/delete [POST] Scoped to Asset |
| [**AssetsDraft**](AssetsApi.md#assetsdraft) | **POST** /assets/draft | /assets/draft [POST] |
| [**AssetsGetRecommendedAssets**](AssetsApi.md#assetsgetrecommendedassets) | **GET** /assets/recommended | Your GET endpoint |
| [**AssetsGetRelatedAssets**](AssetsApi.md#assetsgetrelatedassets) | **GET** /assets/related | /assets/related [GET] |
| [**AssetsIdentifiersSnapshot**](AssetsApi.md#assetsidentifierssnapshot) | **GET** /assets/identifiers | /assets/identifiers [GET] |
| [**AssetsPseudoSnapshot**](AssetsApi.md#assetspseudosnapshot) | **GET** /assets/pseudo | /assets/pseudo [GET] |
| [**AssetsSearchWithFilters**](AssetsApi.md#assetssearchwithfilters) | **POST** /assets/search | /assets/search [POST] |
| [**AssetsSnapshot**](AssetsApi.md#assetssnapshot) | **GET** /assets | /assets [GET] Scoped to Assets |
| [**AssetsSpecificAssetFormatsSnapshot**](AssetsApi.md#assetsspecificassetformatssnapshot) | **GET** /assets/{asset}/formats | /assets/{asset}/formats [GET] Scoped To Assets |
| [**AssetsSpecificAssetSnapshot**](AssetsApi.md#assetsspecificassetsnapshot) | **GET** /assets/{asset} | /assets/{asset} [GET] Scoped to Assets |
| [**AssetsStreamIdentifiers**](AssetsApi.md#assetsstreamidentifiers) | **GET** /assets/stream/identifiers | /assets/stream/identifiers [WS] |
| [**GetAssetsStreamTransferables**](AssetsApi.md#getassetsstreamtransferables) | **GET** /assets/stream/transferables | /assets/stream/transferables [WS] |
| [**SearchAssets**](AssetsApi.md#searchassets) | **GET** /assets/search | /assets/search?query&#x3D;string [GET] |
| [**StreamAssets**](AssetsApi.md#streamassets) | **GET** /assets/stream | /assets/stream [WS] |

<a id="assetscreatenewasset"></a>
# **AssetsCreateNewAsset**
> Asset AssetsCreateNewAsset (bool? transferables = null, Seed seed = null)

/assets/create [POST] Scoped to Asset

Accepts a seeded (a structure that comes before an asset, and will be used in creation) asset and uploads it to Pieces. The response will be the newly created Asset object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsCreateNewAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seed = new Seed(); // Seed |  (optional) 

            try
            {
                // /assets/create [POST] Scoped to Asset
                Asset result = apiInstance.AssetsCreateNewAsset(transferables, seed);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsCreateNewAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsCreateNewAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/create [POST] Scoped to Asset
    ApiResponse<Asset> response = apiInstance.AssetsCreateNewAssetWithHttpInfo(transferables, seed);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsCreateNewAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seed** | [**Seed**](Seed.md) |  | [optional]  |

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

<a id="assetsdeleteasset"></a>
# **AssetsDeleteAsset**
> string AssetsDeleteAsset (Guid asset)

/assets/{asset}/delete [POST] Scoped to Asset

Deletes a specific asset from the system by providing its unique identifier (UID). Upon successful deletion, it returns the UID of the deleted asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsDeleteAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /assets/{asset}/delete [POST] Scoped to Asset
                string result = apiInstance.AssetsDeleteAsset(asset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsDeleteAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsDeleteAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/{asset}/delete [POST] Scoped to Asset
    ApiResponse<string> response = apiInstance.AssetsDeleteAssetWithHttpInfo(asset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsDeleteAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsdraft"></a>
# **AssetsDraft**
> Seed AssetsDraft (bool? transferables = null, Seed seed = null)

/assets/draft [POST]

Allows developers to input a Seed and receive a drafted asset with preprocessed information. No data is persisted; this is solely an input/output endpoint.  For images, it returns the original Seed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seed = new Seed(); // Seed |  (optional) 

            try
            {
                // /assets/draft [POST]
                Seed result = apiInstance.AssetsDraft(transferables, seed);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/draft [POST]
    ApiResponse<Seed> response = apiInstance.AssetsDraftWithHttpInfo(transferables, seed);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seed** | [**Seed**](Seed.md) |  | [optional]  |

### Return type

[**Seed**](Seed.md)

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

<a id="assetsgetrecommendedassets"></a>
# **AssetsGetRecommendedAssets**
> Assets AssetsGetRecommendedAssets (SeededAssetsRecommendation seededAssetsRecommendation = null)

Your GET endpoint

Expects a SeededAssetsRecommendation Model in the request body, containing assets and interactions. Returns an Assets Model suitable for UI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsGetRecommendedAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var seededAssetsRecommendation = new SeededAssetsRecommendation(); // SeededAssetsRecommendation | The body of the request will be an SeededAssetsRecommendation Model with interaction meta data included at body.interactions.iterable and then the corrresponding index-paired body.assets.iterable with a fully populated assets array with fully sub-populated formats. (optional) 

            try
            {
                // Your GET endpoint
                Assets result = apiInstance.AssetsGetRecommendedAssets(seededAssetsRecommendation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetRecommendedAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetRecommendedAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Your GET endpoint
    ApiResponse<Assets> response = apiInstance.AssetsGetRecommendedAssetsWithHttpInfo(seededAssetsRecommendation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetRecommendedAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededAssetsRecommendation** | [**SeededAssetsRecommendation**](SeededAssetsRecommendation.md) | The body of the request will be an SeededAssetsRecommendation Model with interaction meta data included at body.interactions.iterable and then the corrresponding index-paired body.assets.iterable with a fully populated assets array with fully sub-populated formats. | [optional]  |

### Return type

[**Assets**](Assets.md)

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

<a id="assetsgetrelatedassets"></a>
# **AssetsGetRelatedAssets**
> Assets AssetsGetRelatedAssets (Assets assets = null)

/assets/related [GET]

Retrieves one or more related assets when provided with one or more input assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsGetRelatedAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var assets = new Assets(); // Assets | The body of the request is an object (Assets Model) with iterable internally. (optional) 

            try
            {
                // /assets/related [GET]
                Assets result = apiInstance.AssetsGetRelatedAssets(assets);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetRelatedAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetRelatedAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/related [GET]
    ApiResponse<Assets> response = apiInstance.AssetsGetRelatedAssetsWithHttpInfo(assets);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetRelatedAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assets** | [**Assets**](Assets.md) | The body of the request is an object (Assets Model) with iterable internally. | [optional]  |

### Return type

[**Assets**](Assets.md)

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

<a id="assetsidentifierssnapshot"></a>
# **AssetsIdentifiersSnapshot**
> FlattenedAssets AssetsIdentifiersSnapshot (bool? pseudo = null)

/assets/identifiers [GET]

Retrieves all asset IDs associated with your account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsIdentifiersSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var pseudo = true;  // bool? | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. (optional) 

            try
            {
                // /assets/identifiers [GET]
                FlattenedAssets result = apiInstance.AssetsIdentifiersSnapshot(pseudo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsIdentifiersSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsIdentifiersSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/identifiers [GET]
    ApiResponse<FlattenedAssets> response = apiInstance.AssetsIdentifiersSnapshotWithHttpInfo(pseudo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsIdentifiersSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pseudo** | **bool?** | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. | [optional]  |

### Return type

[**FlattenedAssets**](FlattenedAssets.md)

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

<a id="assetspseudosnapshot"></a>
# **AssetsPseudoSnapshot**
> PseudoAssets AssetsPseudoSnapshot ()

/assets/pseudo [GET]

Retrieves a snapshot exclusively containing pseudo Assets from your Pieces drive.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsPseudoSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);

            try
            {
                // /assets/pseudo [GET]
                PseudoAssets result = apiInstance.AssetsPseudoSnapshot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsPseudoSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsPseudoSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/pseudo [GET]
    ApiResponse<PseudoAssets> response = apiInstance.AssetsPseudoSnapshotWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsPseudoSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PseudoAssets**](PseudoAssets.md)

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

<a id="assetssearchwithfilters"></a>
# **AssetsSearchWithFilters**
> AssetsSearchWithFiltersOutput AssetsSearchWithFilters (bool? transferables = null, bool? pseudo = null, AssetsSearchWithFiltersInput assetsSearchWithFiltersInput = null)

/assets/search [POST]

Enables searching through your pieces and returns Assets (the results) based on your query.  When sending a query in the request body, fuzzy search is applied.  Additionally, the request body can include a search space, currently as a list of UUIDs (and potentially Seeds in the future). Optional filters can also be included in the request body, represented as an iterable of filters, all of which are combined using AND operations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsSearchWithFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var pseudo = true;  // bool? | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. (optional) 
            var assetsSearchWithFiltersInput = new AssetsSearchWithFiltersInput(); // AssetsSearchWithFiltersInput |  (optional) 

            try
            {
                // /assets/search [POST]
                AssetsSearchWithFiltersOutput result = apiInstance.AssetsSearchWithFilters(transferables, pseudo, assetsSearchWithFiltersInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsSearchWithFilters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsSearchWithFiltersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/search [POST]
    ApiResponse<AssetsSearchWithFiltersOutput> response = apiInstance.AssetsSearchWithFiltersWithHttpInfo(transferables, pseudo, assetsSearchWithFiltersInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsSearchWithFiltersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **pseudo** | **bool?** | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. | [optional]  |
| **assetsSearchWithFiltersInput** | [**AssetsSearchWithFiltersInput**](AssetsSearchWithFiltersInput.md) |  | [optional]  |

### Return type

[**AssetsSearchWithFiltersOutput**](AssetsSearchWithFiltersOutput.md)

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

<a id="assetssnapshot"></a>
# **AssetsSnapshot**
> Assets AssetsSnapshot (bool? transferables = null, bool? suggested = null, bool? pseudo = null)

/assets [GET] Scoped to Assets

Get all of the users Assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var suggested = true;  // bool? | This will let us know if a developer, wants a snapshot related to suggested content or normal content (optional) 
            var pseudo = true;  // bool? | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. (optional) 

            try
            {
                // /assets [GET] Scoped to Assets
                Assets result = apiInstance.AssetsSnapshot(transferables, suggested, pseudo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets [GET] Scoped to Assets
    ApiResponse<Assets> response = apiInstance.AssetsSnapshotWithHttpInfo(transferables, suggested, pseudo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **suggested** | **bool?** | This will let us know if a developer, wants a snapshot related to suggested content or normal content | [optional]  |
| **pseudo** | **bool?** | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. | [optional]  |

### Return type

[**Assets**](Assets.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsspecificassetformatssnapshot"></a>
# **AssetsSpecificAssetFormatsSnapshot**
> Formats AssetsSpecificAssetFormatsSnapshot (Guid asset, bool? transferables = null)

/assets/{asset}/formats [GET] Scoped To Assets

Retrieves the available formats for a specific asset identified by its ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsSpecificAssetFormatsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /assets/{asset}/formats [GET] Scoped To Assets
                Formats result = apiInstance.AssetsSpecificAssetFormatsSnapshot(asset, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsSpecificAssetFormatsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsSpecificAssetFormatsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/{asset}/formats [GET] Scoped To Assets
    ApiResponse<Formats> response = apiInstance.AssetsSpecificAssetFormatsSnapshotWithHttpInfo(asset, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsSpecificAssetFormatsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Formats**](Formats.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsspecificassetsnapshot"></a>
# **AssetsSpecificAssetSnapshot**
> Asset AssetsSpecificAssetSnapshot (Guid asset, bool? transferables = null)

/assets/{asset} [GET] Scoped to Assets

Allows clients to retrieve details of a specific asset by providing its UUID in the path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsSpecificAssetSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /assets/{asset} [GET] Scoped to Assets
                Asset result = apiInstance.AssetsSpecificAssetSnapshot(asset, transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsSpecificAssetSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsSpecificAssetSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/{asset} [GET] Scoped to Assets
    ApiResponse<Asset> response = apiInstance.AssetsSpecificAssetSnapshotWithHttpInfo(asset, transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsSpecificAssetSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific asset per the provided asset id. |  -  |
| **410** | Asset no longer exists and is Gone. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsstreamidentifiers"></a>
# **AssetsStreamIdentifiers**
> StreamedIdentifiers AssetsStreamIdentifiers ()

/assets/stream/identifiers [WS]

Provides a WebSocket connection that emits changes to your asset's identifiers (UUIDs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AssetsStreamIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);

            try
            {
                // /assets/stream/identifiers [WS]
                StreamedIdentifiers result = apiInstance.AssetsStreamIdentifiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsStreamIdentifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsStreamIdentifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/stream/identifiers [WS]
    ApiResponse<StreamedIdentifiers> response = apiInstance.AssetsStreamIdentifiersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsStreamIdentifiersWithHttpInfo: " + e.Message);
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getassetsstreamtransferables"></a>
# **GetAssetsStreamTransferables**
> Assets GetAssetsStreamTransferables ()

/assets/stream/transferables [WS]

Provides a WebSocket connection that emits changes to your assets, including their transferable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class GetAssetsStreamTransferablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);

            try
            {
                // /assets/stream/transferables [WS]
                Assets result = apiInstance.GetAssetsStreamTransferables();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetAssetsStreamTransferables: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssetsStreamTransferablesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/stream/transferables [WS]
    ApiResponse<Assets> response = apiInstance.GetAssetsStreamTransferablesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.GetAssetsStreamTransferablesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Assets**](Assets.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchassets"></a>
# **SearchAssets**
> SearchedAssets SearchAssets (string query = null, bool? transferables = null, string searchableTags = null, bool? pseudo = null)

/assets/search?query=string [GET]

Performs a search across your pieces and returns Assets (the results) based on your query. Presently, it only requires your query to be sent in the body. It is mandatory to include searchable_tags (comma-separated values of tags) or a query string.  If a query is provided, a fuzzy search will be conducted. If searchable tags are provided, a tag-based search will be executed.  If neither are included, a 500 error will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SearchAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);
            var query = "query_example";  // string | This is a string that you can use to search your assets. (optional) 
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var searchableTags = "searchableTags_example";  // string | This is a comma separated value of tags used for search. (optional) 
            var pseudo = true;  // bool? | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. (optional) 

            try
            {
                // /assets/search?query=string [GET]
                SearchedAssets result = apiInstance.SearchAssets(query, transferables, searchableTags, pseudo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.SearchAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/search?query=string [GET]
    ApiResponse<SearchedAssets> response = apiInstance.SearchAssetsWithHttpInfo(query, transferables, searchableTags, pseudo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.SearchAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | This is a string that you can use to search your assets. | [optional]  |
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **searchableTags** | **string** | This is a comma separated value of tags used for search. | [optional]  |
| **pseudo** | **bool?** | This is helper boolean that will give you the ability to also include your pseudo assets, we will always default to false. | [optional]  |

### Return type

[**SearchedAssets**](SearchedAssets.md)

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

<a id="streamassets"></a>
# **StreamAssets**
> Assets StreamAssets ()

/assets/stream [WS]

Provides a WebSocket connection that emits changes to your assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class StreamAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AssetsApi(config);

            try
            {
                // /assets/stream [WS]
                Assets result = apiInstance.StreamAssets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.StreamAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StreamAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /assets/stream [WS]
    ApiResponse<Assets> response = apiInstance.StreamAssetsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.StreamAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Assets**](Assets.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

