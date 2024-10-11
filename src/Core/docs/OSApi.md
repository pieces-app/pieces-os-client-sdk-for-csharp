# Pieces.Os.Core.Api.OSApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LinkProvider**](OSApi.md#linkprovider) | **POST** /os/link_provider | /os/link_provider [POST] |
| [**OsAppletLaunch**](OSApi.md#osappletlaunch) | **POST** /os/applet/launch | /os/applet/launch [POST] |
| [**OsAppletRestart**](OSApi.md#osappletrestart) | **POST** /os/applet/restart | /os/applet/restart [POST] |
| [**OsAppletTerminate**](OSApi.md#osappletterminate) | **POST** /os/applet/terminate | /os/applet/terminate [POST] |
| [**OsBrowserUrlOpen**](OSApi.md#osbrowserurlopen) | **POST** /os/browser/url/open | /os/browser/url/open [POST] |
| [**OsDeviceInformation**](OSApi.md#osdeviceinformation) | **GET** /os/device/information | /os/device/information [GET] |
| [**OsFilesystemFileOpen**](OSApi.md#osfilesystemfileopen) | **POST** /os/filesystem/file/open | /os/filesystem/file/open [POST] |
| [**OsFilesystemFileReadStreamed**](OSApi.md#osfilesystemfilereadstreamed) | **GET** /os/filesystem/file/read/streamed | /os/filesystem/file/read/streamed [WS] |
| [**OsFilesystemPathVerify**](OSApi.md#osfilesystempathverify) | **POST** /os/filesystem/path/verify | /os/filesystem/path/verify [POST] |
| [**OsFilesystemPickFiles**](OSApi.md#osfilesystempickfiles) | **POST** /os/filesystem/files/pick | /os/filesystem/files/pick [POST] |
| [**OsFilesystemPickFolders**](OSApi.md#osfilesystempickfolders) | **POST** /os/filesystem/folders/pick | /os/filesystem/folders/pick [POST] |
| [**OsMemoryOptimize**](OSApi.md#osmemoryoptimize) | **POST** /os/memory/optimize | /os/memory/optimize [POST] |
| [**OsMetadata**](OSApi.md#osmetadata) | **GET** /os/metadata | /os/metadata [GET] |
| [**OsPermissions**](OSApi.md#ospermissions) | **GET** /os/permissions | /os/permissions [GET] |
| [**OsPermissionsRequest**](OSApi.md#ospermissionsrequest) | **POST** /os/permissions/request | /os/permissions/request [POST] |
| [**OsRestart**](OSApi.md#osrestart) | **GET** /os/restart | Your GET endpoint |
| [**OsSettingsSnapshot**](OSApi.md#ossettingssnapshot) | **GET** /os/settings | /os/settings [GET] |
| [**OsSettingsStream**](OSApi.md#ossettingsstream) | **GET** /os/settings/stream | /os/settings/stream [WS] |
| [**OsSettingsUpdate**](OSApi.md#ossettingsupdate) | **POST** /os/settings/update | /os/settings/update [POST] |
| [**OsTerminate**](OSApi.md#osterminate) | **POST** /os/terminate | /os/terminate [POST] |
| [**OsUpdateCheck**](OSApi.md#osupdatecheck) | **POST** /os/update/check | /os/update/check [POST] |
| [**OsUpdateCheckStream**](OSApi.md#osupdatecheckstream) | **GET** /os/update/check/stream | /os/update/check/stream [WS] |
| [**SignIntoOS**](OSApi.md#signintoos) | **POST** /os/sign_in |  |
| [**SignOutOfOS**](OSApi.md#signoutofos) | **POST** /os/sign_out | /os/sign_out [POST] |

<a id="linkprovider"></a>
# **LinkProvider**
> ReturnedUserProfile LinkProvider (SeededExternalProvider seededExternalProvider = null)

/os/link_provider [POST]

This will link an external provider to your current auth0 account.  Will throw errors if your user is not signed in.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class LinkProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var seededExternalProvider = new SeededExternalProvider(); // SeededExternalProvider |  (optional) 

            try
            {
                // /os/link_provider [POST]
                ReturnedUserProfile result = apiInstance.LinkProvider(seededExternalProvider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.LinkProvider: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkProviderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/link_provider [POST]
    ApiResponse<ReturnedUserProfile> response = apiInstance.LinkProviderWithHttpInfo(seededExternalProvider);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.LinkProviderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededExternalProvider** | [**SeededExternalProvider**](SeededExternalProvider.md) |  | [optional]  |

### Return type

[**ReturnedUserProfile**](ReturnedUserProfile.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized, this means your user is not authenticated |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="osappletlaunch"></a>
# **OsAppletLaunch**
> ActiveOSServerApplet OsAppletLaunch (InactiveOSServerApplet inactiveOSServerApplet = null)

/os/applet/launch [POST]

This will attempt to launch(serve) a micro_application. If one is already spun up we will just return the port number. TODO: take in an application and return a port number at minimum.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsAppletLaunchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var inactiveOSServerApplet = new InactiveOSServerApplet(); // InactiveOSServerApplet |  (optional) 

            try
            {
                // /os/applet/launch [POST]
                ActiveOSServerApplet result = apiInstance.OsAppletLaunch(inactiveOSServerApplet);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsAppletLaunch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsAppletLaunchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/applet/launch [POST]
    ApiResponse<ActiveOSServerApplet> response = apiInstance.OsAppletLaunchWithHttpInfo(inactiveOSServerApplet);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsAppletLaunchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inactiveOSServerApplet** | [**InactiveOSServerApplet**](InactiveOSServerApplet.md) |  | [optional]  |

### Return type

[**ActiveOSServerApplet**](ActiveOSServerApplet.md)

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

<a id="osappletrestart"></a>
# **OsAppletRestart**
> ActiveOSServerApplet OsAppletRestart (InactiveOSServerApplet inactiveOSServerApplet = null)

/os/applet/restart [POST]

This will attempt to restart a micro_application.(this will shut down the copilot and then rehost it)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsAppletRestartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var inactiveOSServerApplet = new InactiveOSServerApplet(); // InactiveOSServerApplet |  (optional) 

            try
            {
                // /os/applet/restart [POST]
                ActiveOSServerApplet result = apiInstance.OsAppletRestart(inactiveOSServerApplet);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsAppletRestart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsAppletRestartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/applet/restart [POST]
    ApiResponse<ActiveOSServerApplet> response = apiInstance.OsAppletRestartWithHttpInfo(inactiveOSServerApplet);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsAppletRestartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inactiveOSServerApplet** | [**InactiveOSServerApplet**](InactiveOSServerApplet.md) |  | [optional]  |

### Return type

[**ActiveOSServerApplet**](ActiveOSServerApplet.md)

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

<a id="osappletterminate"></a>
# **OsAppletTerminate**
> void OsAppletTerminate (TerminatingOSServerApplet terminatingOSServerApplet = null)

/os/applet/terminate [POST]

This will attempt to shutdown or terminate a specified micro_application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsAppletTerminateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var terminatingOSServerApplet = new TerminatingOSServerApplet(); // TerminatingOSServerApplet |  (optional) 

            try
            {
                // /os/applet/terminate [POST]
                apiInstance.OsAppletTerminate(terminatingOSServerApplet);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsAppletTerminate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsAppletTerminateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/applet/terminate [POST]
    apiInstance.OsAppletTerminateWithHttpInfo(terminatingOSServerApplet);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsAppletTerminateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **terminatingOSServerApplet** | [**TerminatingOSServerApplet**](TerminatingOSServerApplet.md) |  | [optional]  |

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

<a id="osbrowserurlopen"></a>
# **OsBrowserUrlOpen**
> void OsBrowserUrlOpen (string body = null)

/os/browser/url/open [POST]

This will accept a url and launch this in an external browser.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsBrowserUrlOpenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var body = "body_example";  // string |  (optional) 

            try
            {
                // /os/browser/url/open [POST]
                apiInstance.OsBrowserUrlOpen(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsBrowserUrlOpen: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsBrowserUrlOpenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/browser/url/open [POST]
    apiInstance.OsBrowserUrlOpenWithHttpInfo(body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsBrowserUrlOpenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  | [optional]  |

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

<a id="osdeviceinformation"></a>
# **OsDeviceInformation**
> OSDeviceInformationReturnable OsDeviceInformation ()

/os/device/information [GET]

This will get information related to your specific device.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsDeviceInformationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // /os/device/information [GET]
                OSDeviceInformationReturnable result = apiInstance.OsDeviceInformation();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsDeviceInformation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsDeviceInformationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/device/information [GET]
    ApiResponse<OSDeviceInformationReturnable> response = apiInstance.OsDeviceInformationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsDeviceInformationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OSDeviceInformationReturnable**](OSDeviceInformationReturnable.md)

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

<a id="osfilesystemfileopen"></a>
# **OsFilesystemFileOpen**
> void OsFilesystemFileOpen (string body = null)

/os/filesystem/file/open [POST]

This will accept a path and will launch a path in a given finder/file explorer window  note: TODO in the future add an endpoint for open/in || open/with (browser,files,...etc)       && if so we will want /os/open_with/file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsFilesystemFileOpenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var body = "body_example";  // string |  (optional) 

            try
            {
                // /os/filesystem/file/open [POST]
                apiInstance.OsFilesystemFileOpen(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsFilesystemFileOpen: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsFilesystemFileOpenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/filesystem/file/open [POST]
    apiInstance.OsFilesystemFileOpenWithHttpInfo(body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsFilesystemFileOpenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  | [optional]  |

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

<a id="osfilesystemfilereadstreamed"></a>
# **OsFilesystemFileReadStreamed**
> OSFileStreamingRead OsFilesystemFileReadStreamed (OSFileStreamingReadAttempt oSFileStreamingReadAttempt = null)

/os/filesystem/file/read/streamed [WS]

This will stream(via a WS the contents of a file back to the client, given a file, it will read the contents and return to the client.  NOTE: will NOT support relative paths. only ABSOLUTE paths. NOTE: needs to be a File.(will not stream a folder) NOTE: we might want to put a limit on the size of the file(IE no more than a GB or something like that??) TODO: would be nice to cancel stream NOTE: for v2 we could have two query params i.e. find which could take in a relative path and or file name and        the other could be compress i.e. streaming a gzip vs the raw bytes..        the caveat here would be mack would need to decompress em.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsFilesystemFileReadStreamedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var oSFileStreamingReadAttempt = new OSFileStreamingReadAttempt(); // OSFileStreamingReadAttempt |  (optional) 

            try
            {
                // /os/filesystem/file/read/streamed [WS]
                OSFileStreamingRead result = apiInstance.OsFilesystemFileReadStreamed(oSFileStreamingReadAttempt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsFilesystemFileReadStreamed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsFilesystemFileReadStreamedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/filesystem/file/read/streamed [WS]
    ApiResponse<OSFileStreamingRead> response = apiInstance.OsFilesystemFileReadStreamedWithHttpInfo(oSFileStreamingReadAttempt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsFilesystemFileReadStreamedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oSFileStreamingReadAttempt** | [**OSFileStreamingReadAttempt**](OSFileStreamingReadAttempt.md) |  | [optional]  |

### Return type

[**OSFileStreamingRead**](OSFileStreamingRead.md)

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

<a id="osfilesystempathverify"></a>
# **OsFilesystemPathVerify**
> VerifiedOSFilesystemPath OsFilesystemPathVerify (string body = null)

/os/filesystem/path/verify [POST]

This will determine in a given path is a file/a directory or invalid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsFilesystemPathVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var body = "body_example";  // string |  (optional) 

            try
            {
                // /os/filesystem/path/verify [POST]
                VerifiedOSFilesystemPath result = apiInstance.OsFilesystemPathVerify(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsFilesystemPathVerify: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsFilesystemPathVerifyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/filesystem/path/verify [POST]
    ApiResponse<VerifiedOSFilesystemPath> response = apiInstance.OsFilesystemPathVerifyWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsFilesystemPathVerifyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  | [optional]  |

### Return type

[**VerifiedOSFilesystemPath**](VerifiedOSFilesystemPath.md)

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

<a id="osfilesystempickfiles"></a>
# **OsFilesystemPickFiles**
> List&lt;string&gt; OsFilesystemPickFiles (FilePickerInput filePickerInput = null)

/os/filesystem/files/pick [POST]

This will trigger a filer picker and return the string paths of the files that were selected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsFilesystemPickFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var filePickerInput = new FilePickerInput(); // FilePickerInput |  (optional) 

            try
            {
                // /os/filesystem/files/pick [POST]
                List<string> result = apiInstance.OsFilesystemPickFiles(filePickerInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsFilesystemPickFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsFilesystemPickFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/filesystem/files/pick [POST]
    ApiResponse<List<string>> response = apiInstance.OsFilesystemPickFilesWithHttpInfo(filePickerInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsFilesystemPickFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filePickerInput** | [**FilePickerInput**](FilePickerInput.md) |  | [optional]  |

### Return type

**List<string>**

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

<a id="osfilesystempickfolders"></a>
# **OsFilesystemPickFolders**
> List&lt;string&gt; OsFilesystemPickFolders ()

/os/filesystem/folders/pick [POST]

This will trigger a folder picker and return the string paths of the folders that were selected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsFilesystemPickFoldersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // /os/filesystem/folders/pick [POST]
                List<string> result = apiInstance.OsFilesystemPickFolders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsFilesystemPickFolders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsFilesystemPickFoldersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/filesystem/folders/pick [POST]
    ApiResponse<List<string>> response = apiInstance.OsFilesystemPickFoldersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsFilesystemPickFoldersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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

<a id="osmemoryoptimize"></a>
# **OsMemoryOptimize**
> void OsMemoryOptimize ()

/os/memory/optimize [POST]

This will optimize memory across PiecesOS.(TODO in the future might want to accept a body, so this will be a POST)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsMemoryOptimizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // /os/memory/optimize [POST]
                apiInstance.OsMemoryOptimize();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsMemoryOptimize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsMemoryOptimizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/memory/optimize [POST]
    apiInstance.OsMemoryOptimizeWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsMemoryOptimizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="osmetadata"></a>
# **OsMetadata**
> OSServerMetadata OsMetadata ()

/os/metadata [GET]

This will return metadata (total materials) in your pieces drive.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // /os/metadata [GET]
                OSServerMetadata result = apiInstance.OsMetadata();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/metadata [GET]
    ApiResponse<OSServerMetadata> response = apiInstance.OsMetadataWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OSServerMetadata**](OSServerMetadata.md)

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

<a id="ospermissions"></a>
# **OsPermissions**
> OSPermissions OsPermissions ()

/os/permissions [GET]

This will only work on Macos and Windows.  And will get the permissions of the user's local machine w/ regard to anything needed to effectively run PiecesOS.  Note: this will let us know if we need to tell them to take action to enable any given permissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // /os/permissions [GET]
                OSPermissions result = apiInstance.OsPermissions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/permissions [GET]
    ApiResponse<OSPermissions> response = apiInstance.OsPermissionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsPermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OSPermissions**](OSPermissions.md)

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

<a id="ospermissionsrequest"></a>
# **OsPermissionsRequest**
> OSPermissions OsPermissionsRequest (OSPermissions oSPermissions = null)

/os/permissions/request [POST]

This will only work on Macos and Windows.  This will request permissions for the given inputs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsPermissionsRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var oSPermissions = new OSPermissions(); // OSPermissions |  (optional) 

            try
            {
                // /os/permissions/request [POST]
                OSPermissions result = apiInstance.OsPermissionsRequest(oSPermissions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsPermissionsRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsPermissionsRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/permissions/request [POST]
    ApiResponse<OSPermissions> response = apiInstance.OsPermissionsRequestWithHttpInfo(oSPermissions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsPermissionsRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oSPermissions** | [**OSPermissions**](OSPermissions.md) |  | [optional]  |

### Return type

[**OSPermissions**](OSPermissions.md)

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

<a id="osrestart"></a>
# **OsRestart**
> void OsRestart ()

Your GET endpoint

This will restart PiecesOS, if successfull with return a 204. This is a LOCALOS Only Endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsRestartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // Your GET endpoint
                apiInstance.OsRestart();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsRestart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsRestartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Your GET endpoint
    apiInstance.OsRestartWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsRestartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="ossettingssnapshot"></a>
# **OsSettingsSnapshot**
> OSServerSettings OsSettingsSnapshot ()

/os/settings [GET]

This is a snapshot of the piecesOS settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsSettingsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // /os/settings [GET]
                OSServerSettings result = apiInstance.OsSettingsSnapshot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsSettingsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsSettingsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/settings [GET]
    ApiResponse<OSServerSettings> response = apiInstance.OsSettingsSnapshotWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsSettingsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OSServerSettings**](OSServerSettings.md)

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

<a id="ossettingsstream"></a>
# **OsSettingsStream**
> OSServerSettings OsSettingsStream ()

/os/settings/stream [WS]

This is a websocket that will emit a change on the update of the OSSettings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsSettingsStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // /os/settings/stream [WS]
                OSServerSettings result = apiInstance.OsSettingsStream();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsSettingsStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsSettingsStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/settings/stream [WS]
    ApiResponse<OSServerSettings> response = apiInstance.OsSettingsStreamWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsSettingsStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OSServerSettings**](OSServerSettings.md)

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

<a id="ossettingsupdate"></a>
# **OsSettingsUpdate**
> OSServerSettings OsSettingsUpdate (OSServerSettings oSServerSettings = null)

/os/settings/update [POST]

This will ensure that we update the os settings.  This will emit a change via the setting stream as well.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsSettingsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var oSServerSettings = new OSServerSettings(); // OSServerSettings |  (optional) 

            try
            {
                // /os/settings/update [POST]
                OSServerSettings result = apiInstance.OsSettingsUpdate(oSServerSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsSettingsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsSettingsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/settings/update [POST]
    ApiResponse<OSServerSettings> response = apiInstance.OsSettingsUpdateWithHttpInfo(oSServerSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsSettingsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oSServerSettings** | [**OSServerSettings**](OSServerSettings.md) |  | [optional]  |

### Return type

[**OSServerSettings**](OSServerSettings.md)

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

<a id="osterminate"></a>
# **OsTerminate**
> void OsTerminate ()

/os/terminate [POST]

This will force quit PiecesOS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsTerminateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // /os/terminate [POST]
                apiInstance.OsTerminate();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsTerminate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsTerminateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/terminate [POST]
    apiInstance.OsTerminateWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsTerminateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="osupdatecheck"></a>
# **OsUpdateCheck**
> OSServerUpdateStatus OsUpdateCheck (UncheckedOSServerUpdate uncheckedOSServerUpdate = null)

/os/update/check [POST]

This is a helper endpoint that will check the status of an update for PiecesOS. IE if there is an update downloading, if there is one available, but the downloading has not started... etc

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsUpdateCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);
            var uncheckedOSServerUpdate = new UncheckedOSServerUpdate(); // UncheckedOSServerUpdate |  (optional) 

            try
            {
                // /os/update/check [POST]
                OSServerUpdateStatus result = apiInstance.OsUpdateCheck(uncheckedOSServerUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsUpdateCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsUpdateCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/update/check [POST]
    ApiResponse<OSServerUpdateStatus> response = apiInstance.OsUpdateCheckWithHttpInfo(uncheckedOSServerUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsUpdateCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uncheckedOSServerUpdate** | [**UncheckedOSServerUpdate**](UncheckedOSServerUpdate.md) |  | [optional]  |

### Return type

[**OSServerUpdateStatus**](OSServerUpdateStatus.md)

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

<a id="osupdatecheckstream"></a>
# **OsUpdateCheckStream**
> OSServerUpdateStatus OsUpdateCheckStream ()

/os/update/check/stream [WS]

This will first kick off the check.  Then will stream the progress.  **TODO lets think about if we want to have a closing NOTE: it is reccommended to use the stream instead of pulling(via the normal check endpoint).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OsUpdateCheckStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // /os/update/check/stream [WS]
                OSServerUpdateStatus result = apiInstance.OsUpdateCheckStream();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.OsUpdateCheckStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OsUpdateCheckStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/update/check/stream [WS]
    ApiResponse<OSServerUpdateStatus> response = apiInstance.OsUpdateCheckStreamWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.OsUpdateCheckStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OSServerUpdateStatus**](OSServerUpdateStatus.md)

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

<a id="signintoos"></a>
# **SignIntoOS**
> UserProfile SignIntoOS ()



A trigger that launches a Sign into OS Server

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SignIntoOSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                UserProfile result = apiInstance.SignIntoOS();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.SignIntoOS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignIntoOSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserProfile> response = apiInstance.SignIntoOSWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.SignIntoOSWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserProfile**](UserProfile.md)

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

<a id="signoutofos"></a>
# **SignOutOfOS**
> Users SignOutOfOS ()

/os/sign_out [POST]

A trigger that signs out a user from the OS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SignOutOfOSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new OSApi(config);

            try
            {
                // /os/sign_out [POST]
                Users result = apiInstance.SignOutOfOS();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OSApi.SignOutOfOS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignOutOfOSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /os/sign_out [POST]
    ApiResponse<Users> response = apiInstance.SignOutOfOSWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OSApi.SignOutOfOSWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Users**](Users.md)

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

