# Pieces.Os.Core.Api.BackupsApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BackupsCreateNewBackup**](BackupsApi.md#backupscreatenewbackup) | **POST** /backups/create | /backups/create [POST] |
| [**BackupsCreateNewBackupStreamed**](BackupsApi.md#backupscreatenewbackupstreamed) | **POST** /backups/create/streamed | /backups/create/streamed [POST] |
| [**BackupsCreateNewBackupStreamedWebsocket**](BackupsApi.md#backupscreatenewbackupstreamedwebsocket) | **GET** /backups/create/streamed/websocket | /backups/create/streamed/websocket [WS] |
| [**BackupsDeleteSpecificBackup**](BackupsApi.md#backupsdeletespecificbackup) | **POST** /backups/{backup}/delete | /backups/{backup}/delete [POST] |
| [**BackupsSnapshot**](BackupsApi.md#backupssnapshot) | **GET** /backups | /backups [GET] |
| [**BackupsStreamedProgress**](BackupsApi.md#backupsstreamedprogress) | **GET** /backups/streamed/progress | /backups/streamed/progress [WS] |

<a id="backupscreatenewbackup"></a>
# **BackupsCreateNewBackup**
> Backup BackupsCreateNewBackup (SeededBackup seededBackup = null)

/backups/create [POST]

This take a local database and ensure that it is backed up to the cloud.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupsCreateNewBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupsApi(config);
            var seededBackup = new SeededBackup(); // SeededBackup |  (optional) 

            try
            {
                // /backups/create [POST]
                Backup result = apiInstance.BackupsCreateNewBackup(seededBackup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.BackupsCreateNewBackup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupsCreateNewBackupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backups/create [POST]
    ApiResponse<Backup> response = apiInstance.BackupsCreateNewBackupWithHttpInfo(seededBackup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupsApi.BackupsCreateNewBackupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededBackup** | [**SeededBackup**](SeededBackup.md) |  | [optional]  |

### Return type

[**Backup**](Backup.md)

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
| **511** | Authentication Required, This means that you user needs to be authenticated with OS in order to perform this action |  -  |
| **505** | HTTP Version Not Supported, This means that your user needs to update their local os, or they cannot perform backup operations with the cloud |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backupscreatenewbackupstreamed"></a>
# **BackupsCreateNewBackupStreamed**
> BackupStreamedProgress BackupsCreateNewBackupStreamed (SeededBackup seededBackup = null)

/backups/create/streamed [POST]

This take a local database and ensure that it is backed up to the cloud.  NOTE: This is a streamed version of the /backups/create. and Since the Generator is unable to generate a streamed endpoint. this is a place holder, and will need to be implemented isolated from the code generator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupsCreateNewBackupStreamedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupsApi(config);
            var seededBackup = new SeededBackup(); // SeededBackup |  (optional) 

            try
            {
                // /backups/create/streamed [POST]
                BackupStreamedProgress result = apiInstance.BackupsCreateNewBackupStreamed(seededBackup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.BackupsCreateNewBackupStreamed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupsCreateNewBackupStreamedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backups/create/streamed [POST]
    ApiResponse<BackupStreamedProgress> response = apiInstance.BackupsCreateNewBackupStreamedWithHttpInfo(seededBackup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupsApi.BackupsCreateNewBackupStreamedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededBackup** | [**SeededBackup**](SeededBackup.md) |  | [optional]  |

### Return type

[**BackupStreamedProgress**](BackupStreamedProgress.md)

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
| **511** | Authentication Required, This means that you user needs to be authenticated with OS in order to perform this action |  -  |
| **505** | HTTP Version Not Supported, This means that your user needs to update their local os, or they cannot perform backup operation with the cloud |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backupscreatenewbackupstreamedwebsocket"></a>
# **BackupsCreateNewBackupStreamedWebsocket**
> BackupStreamedProgress BackupsCreateNewBackupStreamedWebsocket (SeededBackup seededBackup = null)

/backups/create/streamed/websocket [WS]

WEBSOCKET VERSION! This take a local database and ensure that it is backed up to the cloud.  NOTE: This is a streamed version of the /backups/create. and Since the Generator is unable to generate a streamed endpoint. this is a place holder, and will need to be implemented isolated from the code generator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupsCreateNewBackupStreamedWebsocketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupsApi(config);
            var seededBackup = new SeededBackup(); // SeededBackup |  (optional) 

            try
            {
                // /backups/create/streamed/websocket [WS]
                BackupStreamedProgress result = apiInstance.BackupsCreateNewBackupStreamedWebsocket(seededBackup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.BackupsCreateNewBackupStreamedWebsocket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupsCreateNewBackupStreamedWebsocketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backups/create/streamed/websocket [WS]
    ApiResponse<BackupStreamedProgress> response = apiInstance.BackupsCreateNewBackupStreamedWebsocketWithHttpInfo(seededBackup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupsApi.BackupsCreateNewBackupStreamedWebsocketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededBackup** | [**SeededBackup**](SeededBackup.md) |  | [optional]  |

### Return type

[**BackupStreamedProgress**](BackupStreamedProgress.md)

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
| **511** | Authentication Required, This means that you user needs to be authenticated with OS in order to perform this action |  -  |
| **505** | HTTP Version Not Supported, This means that your user needs to update their local os, or they cannot perform backup operation with the cloud |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backupsdeletespecificbackup"></a>
# **BackupsDeleteSpecificBackup**
> void BackupsDeleteSpecificBackup (string backup, Backup backup2 = null)

/backups/{backup}/delete [POST]

This will delete a specific backup from the cloud.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupsDeleteSpecificBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupsApi(config);
            var backup = "backup_example";  // string | This is a identifier that is used to identify a specific backup.(version_timestamp)
            var backup2 = new Backup(); // Backup |  (optional) 

            try
            {
                // /backups/{backup}/delete [POST]
                apiInstance.BackupsDeleteSpecificBackup(backup, backup2);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.BackupsDeleteSpecificBackup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupsDeleteSpecificBackupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backups/{backup}/delete [POST]
    apiInstance.BackupsDeleteSpecificBackupWithHttpInfo(backup, backup2);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupsApi.BackupsDeleteSpecificBackupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **backup** | **string** | This is a identifier that is used to identify a specific backup.(version_timestamp) |  |
| **backup2** | [**Backup**](Backup.md) |  | [optional]  |

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
| **511** | Authentication Required, This means that you user needs to be authenticated with OS in order to perform this action |  -  |
| **505** | HTTP Version Not Supported, This means that your user needs to update their local os, or they cannot perform backup operation with the cloud |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backupssnapshot"></a>
# **BackupsSnapshot**
> Backups BackupsSnapshot ()

/backups [GET]

This will get a snapshot of Backsup within the cloud.  This endpoint requires our user to be authenticated and connected to the cloud.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupsApi(config);

            try
            {
                // /backups [GET]
                Backups result = apiInstance.BackupsSnapshot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.BackupsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backups [GET]
    ApiResponse<Backups> response = apiInstance.BackupsSnapshotWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupsApi.BackupsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Backups**](Backups.md)

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
| **511** | Authentication Required, This means that you user needs to be authenticated with OS in order to perform this action |  -  |
| **505** | HTTP Version Not Supported, This means that your user needs to update their local os, or they cannot perform backup operations with the cloud |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backupsstreamedprogress"></a>
# **BackupsStreamedProgress**
> BackupsStreamedProgress BackupsStreamedProgress ()

/backups/streamed/progress [WS]

This endpoint is a Websocket, that will list all the current websockets that are in progress, this will emit changes as there are changes with the backups or restores in progress.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupsStreamedProgressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupsApi(config);

            try
            {
                // /backups/streamed/progress [WS]
                BackupsStreamedProgress result = apiInstance.BackupsStreamedProgress();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.BackupsStreamedProgress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupsStreamedProgressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backups/streamed/progress [WS]
    ApiResponse<BackupsStreamedProgress> response = apiInstance.BackupsStreamedProgressWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupsApi.BackupsStreamedProgressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**BackupsStreamedProgress**](BackupsStreamedProgress.md)

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

