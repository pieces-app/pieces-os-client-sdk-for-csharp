# Pieces.Os.Core.Api.DatabaseApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DatabaseExport**](DatabaseApi.md#databaseexport) | **GET** /database/export | Your GET endpoint |
| [**DatabaseImport**](DatabaseApi.md#databaseimport) | **POST** /database/import | /database/import [POST] |

<a id="databaseexport"></a>
# **DatabaseExport**
> ExportedDatabase DatabaseExport ()

Your GET endpoint

This is going to export your current database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DatabaseExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new DatabaseApi(config);

            try
            {
                // Your GET endpoint
                ExportedDatabase result = apiInstance.DatabaseExport();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabaseApi.DatabaseExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatabaseExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Your GET endpoint
    ApiResponse<ExportedDatabase> response = apiInstance.DatabaseExportWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabaseApi.DatabaseExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ExportedDatabase**](ExportedDatabase.md)

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

<a id="databaseimport"></a>
# **DatabaseImport**
> void DatabaseImport (ExportedDatabase exportedDatabase = null)

/database/import [POST]

This is going to take in a database, and merge it with the current database. This will revert your database back to it original form if this request fails.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DatabaseImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new DatabaseApi(config);
            var exportedDatabase = new ExportedDatabase(); // ExportedDatabase |  (optional) 

            try
            {
                // /database/import [POST]
                apiInstance.DatabaseImport(exportedDatabase);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabaseApi.DatabaseImport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatabaseImportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /database/import [POST]
    apiInstance.DatabaseImportWithHttpInfo(exportedDatabase);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabaseApi.DatabaseImportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **exportedDatabase** | [**ExportedDatabase**](ExportedDatabase.md) |  | [optional]  |

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
| **505** | HTTP Version Not Supported, This means that your user need to update their local os, and they cannot create a shareable link. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

