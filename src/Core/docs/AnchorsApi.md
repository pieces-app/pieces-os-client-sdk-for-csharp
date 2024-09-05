# Pieces.Os.Core.Api.AnchorsApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AnchorsCreateNewAnchor**](AnchorsApi.md#anchorscreatenewanchor) | **POST** /anchors/create | /anchors/create [POST] |
| [**AnchorsDeleteSpecificAnchor**](AnchorsApi.md#anchorsdeletespecificanchor) | **POST** /anchors/{anchor}/delete | /anchors/{anchor}/delete [POST] |
| [**AnchorsSnapshot**](AnchorsApi.md#anchorssnapshot) | **GET** /anchors | /anchors [GET] |
| [**AnchorsStreamIdentifiers**](AnchorsApi.md#anchorsstreamidentifiers) | **GET** /anchors/stream/identifiers | /anchors/stream/identifiers [WS] |
| [**SearchAnchors**](AnchorsApi.md#searchanchors) | **POST** /anchors/search | /anchors/search [POST] |

<a id="anchorscreatenewanchor"></a>
# **AnchorsCreateNewAnchor**
> Anchor AnchorsCreateNewAnchor (bool? transferables = null, SeededAnchor seededAnchor = null)

/anchors/create [POST]

This will create a anchor and attach it to a specific asset(s) This will also ensure the anchor is normalized.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorsCreateNewAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var seededAnchor = new SeededAnchor(); // SeededAnchor |  (optional) 

            try
            {
                // /anchors/create [POST]
                Anchor result = apiInstance.AnchorsCreateNewAnchor(transferables, seededAnchor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorsApi.AnchorsCreateNewAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorsCreateNewAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchors/create [POST]
    ApiResponse<Anchor> response = apiInstance.AnchorsCreateNewAnchorWithHttpInfo(transferables, seededAnchor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorsApi.AnchorsCreateNewAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **seededAnchor** | [**SeededAnchor**](SeededAnchor.md) |  | [optional]  |

### Return type

[**Anchor**](Anchor.md)

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

<a id="anchorsdeletespecificanchor"></a>
# **AnchorsDeleteSpecificAnchor**
> void AnchorsDeleteSpecificAnchor (string anchor)

/anchors/{anchor}/delete [POST]

This will delete a specific anchor!

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorsDeleteSpecificAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorsApi(config);
            var anchor = "anchor_example";  // string | This is the specific uuid of an anchor.

            try
            {
                // /anchors/{anchor}/delete [POST]
                apiInstance.AnchorsDeleteSpecificAnchor(anchor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorsApi.AnchorsDeleteSpecificAnchor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorsDeleteSpecificAnchorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchors/{anchor}/delete [POST]
    apiInstance.AnchorsDeleteSpecificAnchorWithHttpInfo(anchor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorsApi.AnchorsDeleteSpecificAnchorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **anchor** | **string** | This is the specific uuid of an anchor. |  |

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

<a id="anchorssnapshot"></a>
# **AnchorsSnapshot**
> Anchors AnchorsSnapshot (bool? transferables = null)

/anchors [GET]

This will get a snapshot of all your anchors.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 

            try
            {
                // /anchors [GET]
                Anchors result = apiInstance.AnchorsSnapshot(transferables);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorsApi.AnchorsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchors [GET]
    ApiResponse<Anchors> response = apiInstance.AnchorsSnapshotWithHttpInfo(transferables);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorsApi.AnchorsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |

### Return type

[**Anchors**](Anchors.md)

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

<a id="anchorsstreamidentifiers"></a>
# **AnchorsStreamIdentifiers**
> StreamedIdentifiers AnchorsStreamIdentifiers ()

/anchors/stream/identifiers [WS]

Provides a WebSocket connection that emits changes to your anchor identifiers (UUIDs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AnchorsStreamIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorsApi(config);

            try
            {
                // /anchors/stream/identifiers [WS]
                StreamedIdentifiers result = apiInstance.AnchorsStreamIdentifiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorsApi.AnchorsStreamIdentifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnchorsStreamIdentifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchors/stream/identifiers [WS]
    ApiResponse<StreamedIdentifiers> response = apiInstance.AnchorsStreamIdentifiersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorsApi.AnchorsStreamIdentifiersWithHttpInfo: " + e.Message);
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
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchanchors"></a>
# **SearchAnchors**
> SearchedAnchors SearchAnchors (bool? transferables = null, SearchInput searchInput = null)

/anchors/search [POST]

This will search your anchors for a specific anchor  note: we will search all the anchor points

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SearchAnchorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AnchorsApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var searchInput = new SearchInput(); // SearchInput |  (optional) 

            try
            {
                // /anchors/search [POST]
                SearchedAnchors result = apiInstance.SearchAnchors(transferables, searchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnchorsApi.SearchAnchors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchAnchorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /anchors/search [POST]
    ApiResponse<SearchedAnchors> response = apiInstance.SearchAnchorsWithHttpInfo(transferables, searchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnchorsApi.SearchAnchorsWithHttpInfo: " + e.Message);
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

[**SearchedAnchors**](SearchedAnchors.md)

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

