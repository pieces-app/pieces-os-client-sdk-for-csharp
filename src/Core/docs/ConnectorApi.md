# Pieces.Os.Core.Api.ConnectorApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Connect**](ConnectorApi.md#connect) | **POST** /connect | /connect [POST] |
| [**Intention**](ConnectorApi.md#intention) | **POST** /{application}/intention | /{application}/intention [POST] |
| [**Onboarded**](ConnectorApi.md#onboarded) | **POST** /{application}/onboarded | /onboarded [POST] |
| [**React**](ConnectorApi.md#react) | **POST** /{application}/reaction | /{application}/reaction [POST] |
| [**Suggest**](ConnectorApi.md#suggest) | **POST** /{application}/suggestion | /{application}/suggestion [POST] |
| [**Track**](ConnectorApi.md#track) | **POST** /{application}/track | /{application}/track [POST] |

<a id="connect"></a>
# **Connect**
> Context Connect (SeededConnectorConnection seededConnectorConnection = null)

/connect [POST]

Abstracts a bootup/connection for a specific context.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ConnectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConnectorApi(config);
            var seededConnectorConnection = new SeededConnectorConnection(); // SeededConnectorConnection |  (optional) 

            try
            {
                // /connect [POST]
                Context result = apiInstance.Connect(seededConnectorConnection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.Connect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConnectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /connect [POST]
    ApiResponse<Context> response = apiInstance.ConnectWithHttpInfo(seededConnectorConnection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorApi.ConnectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededConnectorConnection** | [**SeededConnectorConnection**](SeededConnectorConnection.md) |  | [optional]  |

### Return type

[**Context**](Context.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request, Application Failed to connect, Please ensure this is a valid integration. This happens in the case a developer provides and incorrect {application} (applicationId) within the route that doest match a preregisterd integration. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="intention"></a>
# **Intention**
> string Intention (string application, SeededConnectorAsset seededConnectorAsset = null)

/{application}/intention [POST]

Allows you to send a SeededAsset for future comparison.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class IntentionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConnectorApi(config);
            var application = "application_example";  // string | 
            var seededConnectorAsset = new SeededConnectorAsset(); // SeededConnectorAsset |  (optional) 

            try
            {
                // /{application}/intention [POST]
                string result = apiInstance.Intention(application, seededConnectorAsset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.Intention: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntentionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /{application}/intention [POST]
    ApiResponse<string> response = apiInstance.IntentionWithHttpInfo(application, seededConnectorAsset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorApi.IntentionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **application** | **string** |  |  |
| **seededConnectorAsset** | [**SeededConnectorAsset**](SeededConnectorAsset.md) |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request, Application Failed to connect, Please ensure this is a valid integration. This happens in the case a developer provides and incorrect {application} (applicationId) within the route that doest match a preregisterd integration. |  -  |
| **401** | Unauthorized, you will get this in the case that you are trying to ping Pieces_OS but havnt connected yet.\&quot;/connect was not called for your application.\&quot; |  -  |
| **500** | Internal Server Error:  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="onboarded"></a>
# **Onboarded**
> string Onboarded (string application, bool? body = null)

/onboarded [POST]

A central endpoint to manage updates to the onboarding process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OnboardedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConnectorApi(config);
            var application = "application_example";  // string | This is a uuid that represents an application
            var body = true;  // bool? | Whether or not that application has been onboarded. (optional) 

            try
            {
                // /onboarded [POST]
                string result = apiInstance.Onboarded(application, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.Onboarded: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnboardedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /onboarded [POST]
    ApiResponse<string> response = apiInstance.OnboardedWithHttpInfo(application, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorApi.OnboardedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **application** | **string** | This is a uuid that represents an application |  |
| **body** | **bool?** | Whether or not that application has been onboarded. | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK, This will just return a string of \&quot;OK\&quot;. |  -  |
| **400** | Bad Request, Application Failed to connect, Please ensure this is a valid integration. This happens in the case a developer provides and incorrect {application} (applicationId) within the route that doest match a preregisterd integration. |  -  |
| **401** | Unauthorized, you will get this in the case that you are trying to ping Pieces_OS but havnt connected yet.\&quot;/connect was not called for your application.\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="react"></a>
# **React**
> string React (string application, Reaction reaction = null)

/{application}/reaction [POST]

This will respond to the output generated by the /suggest endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ReactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConnectorApi(config);
            var application = "application_example";  // string | 
            var reaction = new Reaction(); // Reaction | ** This body will need to be modified. (optional) 

            try
            {
                // /{application}/reaction [POST]
                string result = apiInstance.React(application, reaction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.React: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /{application}/reaction [POST]
    ApiResponse<string> response = apiInstance.ReactWithHttpInfo(application, reaction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorApi.ReactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **application** | **string** |  |  |
| **reaction** | [**Reaction**](Reaction.md) | ** This body will need to be modified. | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This string will either (1) be a string of the AssetUid or (2) will be a generic string of &#39;OK&#39; if the asset was not saved and &#39;OK&#39; if the result was just used to send information about the a suggested reuse. |  -  |
| **400** | Bad Request, Application Failed to connect, Please ensure this is a valid integration. This happens in the case a developer provides and incorrect {application} (applicationId) within the route that doest match a preregisterd integration. |  -  |
| **401** | Unauthorized, you will get this in the case that you are trying to ping Pieces_OS but havnt connected yet.\&quot;/connect was not called for your application.\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="suggest"></a>
# **Suggest**
> Suggestion Suggest (string application, SeededConnectorCreation seededConnectorCreation = null)

/{application}/suggestion [POST]

Invoked whenever a code snippet is copied from an integration. For instance, if a JetBrains user copies code, this endpoint can be called to assess whether to suggest reusing a piece (if reuse is true, the endpoint provides assets that the user may consider using), saving the code snippet, or taking no action.   **Note: This endpoint could potentially accept a SeededFormat for the request body if required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SuggestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConnectorApi(config);
            var application = "application_example";  // string | 
            var seededConnectorCreation = new SeededConnectorCreation(); // SeededConnectorCreation | This is the Snippet that we will compare to all the saved assets to determine what we want to do with it! (optional) 

            try
            {
                // /{application}/suggestion [POST]
                Suggestion result = apiInstance.Suggest(application, seededConnectorCreation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.Suggest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuggestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /{application}/suggestion [POST]
    ApiResponse<Suggestion> response = apiInstance.SuggestWithHttpInfo(application, seededConnectorCreation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorApi.SuggestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **application** | **string** |  |  |
| **seededConnectorCreation** | [**SeededConnectorCreation**](SeededConnectorCreation.md) | This is the Snippet that we will compare to all the saved assets to determine what we want to do with it! | [optional]  |

### Return type

[**Suggestion**](Suggestion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request, Application Failed to connect, Please ensure this is a valid integration. This happens in the case a developer provides and incorrect {application} (applicationId) within the route that doest match a preregisterd integration. |  -  |
| **401** | Unauthorized, you will get this in the case that you are trying to ping Pieces_OS but havnt connected yet.\&quot;/connect was not called for your application.\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="track"></a>
# **Track**
> string Track (string application, SeededConnectorTracking seededConnectorTracking = null)

/{application}/track [POST]

Abstracts the process of packaging segments on a per-context basis.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class TrackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new ConnectorApi(config);
            var application = "application_example";  // string | This is a uuid that represents an application
            var seededConnectorTracking = new SeededConnectorTracking(); // SeededConnectorTracking | The body is able to take in several properties  (optional) 

            try
            {
                // /{application}/track [POST]
                string result = apiInstance.Track(application, seededConnectorTracking);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorApi.Track: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /{application}/track [POST]
    ApiResponse<string> response = apiInstance.TrackWithHttpInfo(application, seededConnectorTracking);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorApi.TrackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **application** | **string** | This is a uuid that represents an application |  |
| **seededConnectorTracking** | [**SeededConnectorTracking**](SeededConnectorTracking.md) | The body is able to take in several properties  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK, This will jsut return a string of \&quot;OK\&quot;. |  -  |
| **400** | Bad Request, Application Failed to connect, Please ensure this is a valid integration. This happens in the case a developer provides and incorrect {application} (applicationId) within the route that doest match a preregisterd integration. |  -  |
| **401** | Unauthorized, you will get this in the case that you are trying to ping Pieces_OS but havnt connected yet.\&quot;/connect was not called for your application.\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

