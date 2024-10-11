# Pieces.Os.Core.Api.HintsApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HintsCreateNewHint**](HintsApi.md#hintscreatenewhint) | **POST** /hints/create | /hints/create [POST] |
| [**HintsDeleteSpecificHint**](HintsApi.md#hintsdeletespecifichint) | **POST** /hints/{hint}/delete | /hints/{hint}/delete [POST] |
| [**HintsSnapshot**](HintsApi.md#hintssnapshot) | **GET** /hints | /hints [GET] |
| [**HintsStreamIdentifiers**](HintsApi.md#hintsstreamidentifiers) | **GET** /hints/stream/identifiers | /hints/stream/identifiers [WS] |
| [**SearchHints**](HintsApi.md#searchhints) | **POST** /hints/search | /hints/search [POST] |

<a id="hintscreatenewhint"></a>
# **HintsCreateNewHint**
> Hint HintsCreateNewHint (SeededHint seededHint = null)

/hints/create [POST]

This will create a hint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class HintsCreateNewHintExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new HintsApi(config);
            var seededHint = new SeededHint(); // SeededHint |  (optional) 

            try
            {
                // /hints/create [POST]
                Hint result = apiInstance.HintsCreateNewHint(seededHint);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HintsApi.HintsCreateNewHint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HintsCreateNewHintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /hints/create [POST]
    ApiResponse<Hint> response = apiInstance.HintsCreateNewHintWithHttpInfo(seededHint);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HintsApi.HintsCreateNewHintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededHint** | [**SeededHint**](SeededHint.md) |  | [optional]  |

### Return type

[**Hint**](Hint.md)

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

<a id="hintsdeletespecifichint"></a>
# **HintsDeleteSpecificHint**
> void HintsDeleteSpecificHint (string hint)

/hints/{hint}/delete [POST]

This will delete a specific hint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class HintsDeleteSpecificHintExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new HintsApi(config);
            var hint = "hint_example";  // string | This is a specific hint uuid

            try
            {
                // /hints/{hint}/delete [POST]
                apiInstance.HintsDeleteSpecificHint(hint);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HintsApi.HintsDeleteSpecificHint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HintsDeleteSpecificHintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /hints/{hint}/delete [POST]
    apiInstance.HintsDeleteSpecificHintWithHttpInfo(hint);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HintsApi.HintsDeleteSpecificHintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hint** | **string** | This is a specific hint uuid |  |

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

<a id="hintssnapshot"></a>
# **HintsSnapshot**
> Hints HintsSnapshot ()

/hints [GET]

This will get a snapshot of all of the hints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class HintsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new HintsApi(config);

            try
            {
                // /hints [GET]
                Hints result = apiInstance.HintsSnapshot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HintsApi.HintsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HintsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /hints [GET]
    ApiResponse<Hints> response = apiInstance.HintsSnapshotWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HintsApi.HintsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Hints**](Hints.md)

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

<a id="hintsstreamidentifiers"></a>
# **HintsStreamIdentifiers**
> StreamedIdentifiers HintsStreamIdentifiers ()

/hints/stream/identifiers [WS]

Provides a WebSocket connection that emits changes to your hint identifiers (UUIDs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class HintsStreamIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new HintsApi(config);

            try
            {
                // /hints/stream/identifiers [WS]
                StreamedIdentifiers result = apiInstance.HintsStreamIdentifiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HintsApi.HintsStreamIdentifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HintsStreamIdentifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /hints/stream/identifiers [WS]
    ApiResponse<StreamedIdentifiers> response = apiInstance.HintsStreamIdentifiersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HintsApi.HintsStreamIdentifiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**StreamedIdentifiers**](StreamedIdentifiers.md)

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

<a id="searchhints"></a>
# **SearchHints**
> SearchedHints SearchHints (bool? transferables = null, SearchInput searchInput = null)

/hints/search [POST]

This will search your hints for a specific hint  note: we will just search the hint value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SearchHintsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new HintsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var searchInput = new SearchInput(); // SearchInput |  (optional) 

            try
            {
                // /hints/search [POST]
                SearchedHints result = apiInstance.SearchHints(transferables, searchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HintsApi.SearchHints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchHintsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /hints/search [POST]
    ApiResponse<SearchedHints> response = apiInstance.SearchHintsWithHttpInfo(transferables, searchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HintsApi.SearchHintsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **searchInput** | [**SearchInput**](SearchInput.md) |  | [optional]  |

### Return type

[**SearchedHints**](SearchedHints.md)

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

