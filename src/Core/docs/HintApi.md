# Pieces.Os.Core.Api.HintApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HintAssociateAsset**](HintApi.md#hintassociateasset) | **POST** /hint/{hint}/assets/associate/{asset} | /hint/{hint}/assets/associate/{asset} [POST] |
| [**HintDisassociateAsset**](HintApi.md#hintdisassociateasset) | **POST** /hint/{hint}/assets/disassociate/{asset} | /hint/{hint}/assets/disassociate/{asset} [POST] |
| [**HintScoresIncrement**](HintApi.md#hintscoresincrement) | **POST** /hint/{hint}/scores/increment | &#39;/hint/{hint}/scores/increment&#39; [POST] |
| [**HintSpecificHintSnapshot**](HintApi.md#hintspecifichintsnapshot) | **GET** /hint/{hint} | /hint/{hint} [POST] |
| [**HintUpdate**](HintApi.md#hintupdate) | **POST** /hint/update | /hint/update [POST] |

<a id="hintassociateasset"></a>
# **HintAssociateAsset**
> void HintAssociateAsset (string hint, Guid asset)

/hint/{hint}/assets/associate/{asset} [POST]

associates a hint and an asset. It performs the same action as the asset equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class HintAssociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new HintApi(config);
            var hint = "hint_example";  // string | This is a specific hint uuid
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /hint/{hint}/assets/associate/{asset} [POST]
                apiInstance.HintAssociateAsset(hint, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HintApi.HintAssociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HintAssociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /hint/{hint}/assets/associate/{asset} [POST]
    apiInstance.HintAssociateAssetWithHttpInfo(hint, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HintApi.HintAssociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hint** | **string** | This is a specific hint uuid |  |
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |

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

<a id="hintdisassociateasset"></a>
# **HintDisassociateAsset**
> void HintDisassociateAsset (string hint, Guid asset)

/hint/{hint}/assets/disassociate/{asset} [POST]

Disassociates a hint from an asset. It performs the same action as the asset equivalent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class HintDisassociateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new HintApi(config);
            var hint = "hint_example";  // string | This is a specific hint uuid
            var asset = 2254f2c8-5797-40e8-ac56-41166dc0e159;  // Guid | The id (uuid) of the asset that you are trying to access.

            try
            {
                // /hint/{hint}/assets/disassociate/{asset} [POST]
                apiInstance.HintDisassociateAsset(hint, asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HintApi.HintDisassociateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HintDisassociateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /hint/{hint}/assets/disassociate/{asset} [POST]
    apiInstance.HintDisassociateAssetWithHttpInfo(hint, asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HintApi.HintDisassociateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hint** | **string** | This is a specific hint uuid |  |
| **asset** | **Guid** | The id (uuid) of the asset that you are trying to access. |  |

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

<a id="hintscoresincrement"></a>
# **HintScoresIncrement**
> void HintScoresIncrement (string hint, SeededScoreIncrement seededScoreIncrement = null)

'/hint/{hint}/scores/increment' [POST]

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
    public class HintScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new HintApi(config);
            var hint = "hint_example";  // string | This is a specific hint uuid
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/hint/{hint}/scores/increment' [POST]
                apiInstance.HintScoresIncrement(hint, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HintApi.HintScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HintScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/hint/{hint}/scores/increment' [POST]
    apiInstance.HintScoresIncrementWithHttpInfo(hint, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HintApi.HintScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hint** | **string** | This is a specific hint uuid |  |
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

<a id="hintspecifichintsnapshot"></a>
# **HintSpecificHintSnapshot**
> Hint HintSpecificHintSnapshot (string hint)

/hint/{hint} [POST]

This will get a snapshot of a specific hint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class HintSpecificHintSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new HintApi(config);
            var hint = "hint_example";  // string | This is a specific hint uuid

            try
            {
                // /hint/{hint} [POST]
                Hint result = apiInstance.HintSpecificHintSnapshot(hint);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HintApi.HintSpecificHintSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HintSpecificHintSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /hint/{hint} [POST]
    ApiResponse<Hint> response = apiInstance.HintSpecificHintSnapshotWithHttpInfo(hint);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HintApi.HintSpecificHintSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hint** | **string** | This is a specific hint uuid |  |

### Return type

[**Hint**](Hint.md)

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

<a id="hintupdate"></a>
# **HintUpdate**
> Hint HintUpdate (Hint hint = null)

/hint/update [POST]

This will update a specific hint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class HintUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new HintApi(config);
            var hint = new Hint(); // Hint |  (optional) 

            try
            {
                // /hint/update [POST]
                Hint result = apiInstance.HintUpdate(hint);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HintApi.HintUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HintUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /hint/update [POST]
    ApiResponse<Hint> response = apiInstance.HintUpdateWithHttpInfo(hint);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HintApi.HintUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hint** | [**Hint**](Hint.md) |  | [optional]  |

### Return type

[**Hint**](Hint.md)

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

