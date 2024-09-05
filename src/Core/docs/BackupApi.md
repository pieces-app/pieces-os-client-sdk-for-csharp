# Pieces.Os.Core.Api.BackupApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Backup**](BackupApi.md#backup) | **POST** /backup | /backup [POST] |
| [**BackupAsset**](BackupApi.md#backupasset) | **POST** /backup/asset | /backup/asset [POST] |
| [**BackupRestoreSpecificBackup**](BackupApi.md#backuprestorespecificbackup) | **POST** /backup/{backup}/restore | /backup/{backup}/restore [POST] |
| [**BackupRestoreSpecificBackupStreamed**](BackupApi.md#backuprestorespecificbackupstreamed) | **POST** /backup/{backup}/restore/streamed | /backup/{backup}/restore/streamed [POST] |
| [**BackupRestoreSpecificBackupStreamedWebsocket**](BackupApi.md#backuprestorespecificbackupstreamedwebsocket) | **GET** /backup/{backup}/restore/streamed/websocket | /backup/{backup}/restore/streamed/websocket [WS] |
| [**BackupSpecificBackupSnapshot**](BackupApi.md#backupspecificbackupsnapshot) | **GET** /backup/{backup} | /backup/{backup} [GET] |
| [**BackupSpecificCreationCancel**](BackupApi.md#backupspecificcreationcancel) | **POST** /backup/{backup}/creation/cancel | /backup/{backup}/creation/cancel [POST] |
| [**BackupSpecificCreationStatus**](BackupApi.md#backupspecificcreationstatus) | **GET** /backup/{backup}/creation/status | /backup/{backup}/creation/status [GET] |
| [**BackupSpecificRestorationCancel**](BackupApi.md#backupspecificrestorationcancel) | **POST** /backup/{backup}/restoration/cancel | /backup/{backup}/restoration/cancel [POST] |
| [**BackupSpecificRestorationStatus**](BackupApi.md#backupspecificrestorationstatus) | **GET** /backup/{backup}/restoration/status | /backup/{backup}/restoration/status [GET] |

<a id="backup"></a>
# **Backup**
> void Backup (Assets assets = null)

/backup [POST]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupApi(config);
            var assets = new Assets(); // Assets |  (optional) 

            try
            {
                // /backup [POST]
                apiInstance.Backup(assets);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupApi.Backup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backup [POST]
    apiInstance.BackupWithHttpInfo(assets);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupApi.BackupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assets** | [**Assets**](Assets.md) |  | [optional]  |

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
| **505** | HTTP Version Not Supported, This means that your user need to update their local os, or they cannot Backup to the Cloud. |  -  |
| **511** | Network Authentication Required, This means that you user needs to be authenticated with OS inorder to backup. The User also need to be connected to their cloud to backup.(If either of the 2 are not connected we will return a 511)  TODO thinking about returning a more comprehensive value for digestion on the recieving side. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backupasset"></a>
# **BackupAsset**
> void BackupAsset (Asset asset = null)

/backup/asset [POST]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupApi(config);
            var asset = new Asset(); // Asset |  (optional) 

            try
            {
                // /backup/asset [POST]
                apiInstance.BackupAsset(asset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupApi.BackupAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backup/asset [POST]
    apiInstance.BackupAssetWithHttpInfo(asset);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupApi.BackupAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asset** | [**Asset**](Asset.md) |  | [optional]  |

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
| **505** | HTTP Version Not Supported, This means that your user need to update their local os, or they cannot Backup to the Cloud. |  -  |
| **511** | Network Authentication Required, This means that you user needs to be authenticated with OS inorder to backup. The User also need to be connected to their cloud to backup.(If either of the 2 are not connected we will return a 511)  TODO thinking about returning a more comprehensive value for digestion on the recieving side. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backuprestorespecificbackup"></a>
# **BackupRestoreSpecificBackup**
> Backup BackupRestoreSpecificBackup (string backup, Backup backup2 = null)

/backup/{backup}/restore [POST]

Given a backup identifier version_timestamp.  we will restore a given backup from the cloud and override your local database!!!  NOTE!!!! This will NOT sync, ie all local snippets will get replaced with the restored database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupRestoreSpecificBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupApi(config);
            var backup = "backup_example";  // string | This is a identifier that is used to identify a specific backup.(version_timestamp)
            var backup2 = new Backup(); // Backup |  (optional) 

            try
            {
                // /backup/{backup}/restore [POST]
                Backup result = apiInstance.BackupRestoreSpecificBackup(backup, backup2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupApi.BackupRestoreSpecificBackup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupRestoreSpecificBackupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backup/{backup}/restore [POST]
    ApiResponse<Backup> response = apiInstance.BackupRestoreSpecificBackupWithHttpInfo(backup, backup2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupApi.BackupRestoreSpecificBackupWithHttpInfo: " + e.Message);
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

<a id="backuprestorespecificbackupstreamed"></a>
# **BackupRestoreSpecificBackupStreamed**
> BackupStreamedProgress BackupRestoreSpecificBackupStreamed (string backup, Backup backup2 = null)

/backup/{backup}/restore/streamed [POST]

This take a local database and ensure that it is backed up to the cloud.  NOTE: This is a streamed version of the /backups/<backup>/restore. and Since the Generator is unable to generate a streamed endpoint. this is a place holder, and will need to be implemented isolated from the code generator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupRestoreSpecificBackupStreamedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupApi(config);
            var backup = "backup_example";  // string | This is a identifier that is used to identify a specific backup.(version_timestamp)
            var backup2 = new Backup(); // Backup |  (optional) 

            try
            {
                // /backup/{backup}/restore/streamed [POST]
                BackupStreamedProgress result = apiInstance.BackupRestoreSpecificBackupStreamed(backup, backup2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupApi.BackupRestoreSpecificBackupStreamed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupRestoreSpecificBackupStreamedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backup/{backup}/restore/streamed [POST]
    ApiResponse<BackupStreamedProgress> response = apiInstance.BackupRestoreSpecificBackupStreamedWithHttpInfo(backup, backup2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupApi.BackupRestoreSpecificBackupStreamedWithHttpInfo: " + e.Message);
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
| **511** | Authentication Required, This means that you user needs to be authenticated with OS in order to change the beta status |  -  |
| **505** | HTTP Version Not Supported, This means that your user needs to update their local os, or they cannot perform backup operation with the cloud |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backuprestorespecificbackupstreamedwebsocket"></a>
# **BackupRestoreSpecificBackupStreamedWebsocket**
> BackupStreamedProgress BackupRestoreSpecificBackupStreamedWebsocket (string backup, Backup backup2 = null)

/backup/{backup}/restore/streamed/websocket [WS]

WEBOCKET IMPLEMENTATION: This take a local database and ensure that it is backed up to the cloud.  NOTE: This is a streamed version of the /backups/<backup>/restore. and Since the Generator is unable to generate a streamed endpoint. this is a place holder, and will need to be implemented isolated from the code generator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupRestoreSpecificBackupStreamedWebsocketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupApi(config);
            var backup = "backup_example";  // string | This is a identifier that is used to identify a specific backup.(version_timestamp)
            var backup2 = new Backup(); // Backup |  (optional) 

            try
            {
                // /backup/{backup}/restore/streamed/websocket [WS]
                BackupStreamedProgress result = apiInstance.BackupRestoreSpecificBackupStreamedWebsocket(backup, backup2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupApi.BackupRestoreSpecificBackupStreamedWebsocket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupRestoreSpecificBackupStreamedWebsocketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backup/{backup}/restore/streamed/websocket [WS]
    ApiResponse<BackupStreamedProgress> response = apiInstance.BackupRestoreSpecificBackupStreamedWebsocketWithHttpInfo(backup, backup2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupApi.BackupRestoreSpecificBackupStreamedWebsocketWithHttpInfo: " + e.Message);
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
| **511** | Authentication Required, This means that you user needs to be authenticated with OS in order to change the beta status |  -  |
| **505** | HTTP Version Not Supported, This means that your user needs to update their local os, or they cannot perform backup operation with the cloud |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backupspecificbackupsnapshot"></a>
# **BackupSpecificBackupSnapshot**
> Backup BackupSpecificBackupSnapshot (string backup)

/backup/{backup} [GET]

This will just get the metadata associated with a specific backup.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupSpecificBackupSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupApi(config);
            var backup = "backup_example";  // string | This is a identifier that is used to identify a specific backup.(version_timestamp)

            try
            {
                // /backup/{backup} [GET]
                Backup result = apiInstance.BackupSpecificBackupSnapshot(backup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupApi.BackupSpecificBackupSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupSpecificBackupSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backup/{backup} [GET]
    ApiResponse<Backup> response = apiInstance.BackupSpecificBackupSnapshotWithHttpInfo(backup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupApi.BackupSpecificBackupSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **backup** | **string** | This is a identifier that is used to identify a specific backup.(version_timestamp) |  |

### Return type

[**Backup**](Backup.md)

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
| **511** | Authentication Required, This means that you user needs to be authenticated with OS in order to change the beta status |  -  |
| **505** | HTTP Version Not Supported, This means that your user needs to update their local os, or they cannot perform backup operation with the cloud |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backupspecificcreationcancel"></a>
# **BackupSpecificCreationCancel**
> void BackupSpecificCreationCancel (string backup)

/backup/{backup}/creation/cancel [POST]

This is Going to cancel a create backup (streamed) or not streamed that is currently in progress.  This will throw a 500 if there is not a backup in progress.  TODO: ADD mofe DESCRIPITON To this.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupSpecificCreationCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupApi(config);
            var backup = "backup_example";  // string | This is a identifier that is used to identify a specific backup.(version_timestamp)

            try
            {
                // /backup/{backup}/creation/cancel [POST]
                apiInstance.BackupSpecificCreationCancel(backup);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupApi.BackupSpecificCreationCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupSpecificCreationCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backup/{backup}/creation/cancel [POST]
    apiInstance.BackupSpecificCreationCancelWithHttpInfo(backup);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupApi.BackupSpecificCreationCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **backup** | **string** | This is a identifier that is used to identify a specific backup.(version_timestamp) |  |

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

<a id="backupspecificcreationstatus"></a>
# **BackupSpecificCreationStatus**
> BackupStatus BackupSpecificCreationStatus (string backup)

/backup/{backup}/creation/status [GET]

TODO add a description:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupSpecificCreationStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupApi(config);
            var backup = "backup_example";  // string | This is a identifier that is used to identify a specific backup.(version_timestamp)

            try
            {
                // /backup/{backup}/creation/status [GET]
                BackupStatus result = apiInstance.BackupSpecificCreationStatus(backup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupApi.BackupSpecificCreationStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupSpecificCreationStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backup/{backup}/creation/status [GET]
    ApiResponse<BackupStatus> response = apiInstance.BackupSpecificCreationStatusWithHttpInfo(backup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupApi.BackupSpecificCreationStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **backup** | **string** | This is a identifier that is used to identify a specific backup.(version_timestamp) |  |

### Return type

[**BackupStatus**](BackupStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Internal Server Error |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backupspecificrestorationcancel"></a>
# **BackupSpecificRestorationCancel**
> void BackupSpecificRestorationCancel (string backup, Backup backup2 = null)

/backup/{backup}/restoration/cancel [POST]

This will cancel a Restoration that is in progress and restore to the original database.  Note: if there is not a restore in progress we will return a 500.  TODO add

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupSpecificRestorationCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupApi(config);
            var backup = "backup_example";  // string | This is a identifier that is used to identify a specific backup.(version_timestamp)
            var backup2 = new Backup(); // Backup |  (optional) 

            try
            {
                // /backup/{backup}/restoration/cancel [POST]
                apiInstance.BackupSpecificRestorationCancel(backup, backup2);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupApi.BackupSpecificRestorationCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupSpecificRestorationCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backup/{backup}/restoration/cancel [POST]
    apiInstance.BackupSpecificRestorationCancelWithHttpInfo(backup, backup2);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupApi.BackupSpecificRestorationCancelWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="backupspecificrestorationstatus"></a>
# **BackupSpecificRestorationStatus**
> BackupStatus BackupSpecificRestorationStatus (string backup)

/backup/{backup}/restoration/status [GET]

TODO add a description:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class BackupSpecificRestorationStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new BackupApi(config);
            var backup = "backup_example";  // string | This is a identifier that is used to identify a specific backup.(version_timestamp)

            try
            {
                // /backup/{backup}/restoration/status [GET]
                BackupStatus result = apiInstance.BackupSpecificRestorationStatus(backup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupApi.BackupSpecificRestorationStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackupSpecificRestorationStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /backup/{backup}/restoration/status [GET]
    ApiResponse<BackupStatus> response = apiInstance.BackupSpecificRestorationStatusWithHttpInfo(backup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackupApi.BackupSpecificRestorationStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **backup** | **string** | This is a identifier that is used to identify a specific backup.(version_timestamp) |  |

### Return type

[**BackupStatus**](BackupStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Internal Server Error |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

