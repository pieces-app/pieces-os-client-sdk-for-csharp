# Pieces.Os.Core.Api.GithubApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ImportGithubGists**](GithubApi.md#importgithubgists) | **POST** /github/gists/import | /github/gists/import [POST] |

<a id="importgithubgists"></a>
# **ImportGithubGists**
> Seeds ImportGithubGists (bool? automatic = null, SeededGithubGistsImport seededGithubGistsImport = null)

/github/gists/import [POST]

This will attempt to get all the gist availble and return them to the user as a DiscoveredAssets.  if automatic is true we will automatically create the asset.  v1. will just get all the users' gists. implemented. v2. can get specific a public gist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ImportGithubGistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new GithubApi(config);
            var automatic = true;  // bool? | For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. (optional)  (default to true)
            var seededGithubGistsImport = new SeededGithubGistsImport(); // SeededGithubGistsImport |  (optional) 

            try
            {
                // /github/gists/import [POST]
                Seeds result = apiInstance.ImportGithubGists(automatic, seededGithubGistsImport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GithubApi.ImportGithubGists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportGithubGistsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /github/gists/import [POST]
    ApiResponse<Seeds> response = apiInstance.ImportGithubGistsWithHttpInfo(automatic, seededGithubGistsImport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GithubApi.ImportGithubGistsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **automatic** | **bool?** | For most cases set to true. If this is set to true we will handle the behavior automically or else we will not proactively handle specific behavior but we will let the developer decide the behavior. | [optional] [default to true] |
| **seededGithubGistsImport** | [**SeededGithubGistsImport**](SeededGithubGistsImport.md) |  | [optional]  |

### Return type

[**Seeds**](Seeds.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **412** | Precondition Failed, This means the user was not authenticated with PiecesOS with github. |  -  |
| **500** | Internal Server Error |  -  |
| **511** | Network Authentication Required, Not logged into Pieces os required the user to authenticate. or if the user is not connected to their cloud. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

