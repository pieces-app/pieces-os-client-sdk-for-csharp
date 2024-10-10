# Pieces.Os.Core.Api.SensitiveApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SensitiveScoresIncrement**](SensitiveApi.md#sensitivescoresincrement) | **POST** /sensitive/{sensitive}/scores/increment | &#39;/sensitive/{sensitive}/scores/increment&#39; [POST] |
| [**SensitiveSnapshot**](SensitiveApi.md#sensitivesnapshot) | **GET** /sensitive/{sensitive} | /sensitive/{sensitive} [GET] |
| [**UpdateSensitive**](SensitiveApi.md#updatesensitive) | **POST** /sensitive/update | /sensitive/update [POST] |

<a id="sensitivescoresincrement"></a>
# **SensitiveScoresIncrement**
> void SensitiveScoresIncrement (string sensitive, SeededScoreIncrement seededScoreIncrement = null)

'/sensitive/{sensitive}/scores/increment' [POST]

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
    public class SensitiveScoresIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new SensitiveApi(config);
            var sensitive = "sensitive_example";  // string | This is a uuid that represents a sensitive.
            var seededScoreIncrement = new SeededScoreIncrement(); // SeededScoreIncrement |  (optional) 

            try
            {
                // '/sensitive/{sensitive}/scores/increment' [POST]
                apiInstance.SensitiveScoresIncrement(sensitive, seededScoreIncrement);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SensitiveApi.SensitiveScoresIncrement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SensitiveScoresIncrementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // '/sensitive/{sensitive}/scores/increment' [POST]
    apiInstance.SensitiveScoresIncrementWithHttpInfo(sensitive, seededScoreIncrement);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SensitiveApi.SensitiveScoresIncrementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sensitive** | **string** | This is a uuid that represents a sensitive. |  |
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

<a id="sensitivesnapshot"></a>
# **SensitiveSnapshot**
> Sensitive SensitiveSnapshot (string sensitive)

/sensitive/{sensitive} [GET]

This will get a specific sensitive via the sensitive uuid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SensitiveSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new SensitiveApi(config);
            var sensitive = "sensitive_example";  // string | 

            try
            {
                // /sensitive/{sensitive} [GET]
                Sensitive result = apiInstance.SensitiveSnapshot(sensitive);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SensitiveApi.SensitiveSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SensitiveSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /sensitive/{sensitive} [GET]
    ApiResponse<Sensitive> response = apiInstance.SensitiveSnapshotWithHttpInfo(sensitive);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SensitiveApi.SensitiveSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sensitive** | **string** |  |  |

### Return type

[**Sensitive**](Sensitive.md)

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

<a id="updatesensitive"></a>
# **UpdateSensitive**
> Sensitive UpdateSensitive (Sensitive sensitive = null)

/sensitive/update [POST]

This will update a specific sensitive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class UpdateSensitiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new SensitiveApi(config);
            var sensitive = new Sensitive(); // Sensitive |  (optional) 

            try
            {
                // /sensitive/update [POST]
                Sensitive result = apiInstance.UpdateSensitive(sensitive);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SensitiveApi.UpdateSensitive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSensitiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /sensitive/update [POST]
    ApiResponse<Sensitive> response = apiInstance.UpdateSensitiveWithHttpInfo(sensitive);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SensitiveApi.UpdateSensitiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sensitive** | [**Sensitive**](Sensitive.md) |  | [optional]  |

### Return type

[**Sensitive**](Sensitive.md)

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

