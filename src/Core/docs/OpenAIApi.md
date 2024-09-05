# Pieces.Os.Core.Api.OpenAIApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OpenAiModelsList**](OpenAIApi.md#openaimodelslist) | **POST** /open_ai/models/list | /open_ai/models/list [POST] |

<a id="openaimodelslist"></a>
# **OpenAiModelsList**
> OpenAIModelsListOutput OpenAiModelsList (OpenAIModelsListInput openAIModelsListInput = null)

/open_ai/models/list [POST]

This will get a list of all of your Models from OpenAI w/ you user.auth0.openAI.apiKey.  if the user is unauthenticated or if the openAI key doesnt exist or if it is invalid we will return a 401.  Requires internet as this will ping out to OpenAI's server to get the models.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class OpenAiModelsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new OpenAIApi(config);
            var openAIModelsListInput = new OpenAIModelsListInput(); // OpenAIModelsListInput |  (optional) 

            try
            {
                // /open_ai/models/list [POST]
                OpenAIModelsListOutput result = apiInstance.OpenAiModelsList(openAIModelsListInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpenAIApi.OpenAiModelsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OpenAiModelsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /open_ai/models/list [POST]
    ApiResponse<OpenAIModelsListOutput> response = apiInstance.OpenAiModelsListWithHttpInfo(openAIModelsListInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpenAIApi.OpenAiModelsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **openAIModelsListInput** | [**OpenAIModelsListInput**](OpenAIModelsListInput.md) |  | [optional]  |

### Return type

[**OpenAIModelsListOutput**](OpenAIModelsListOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Invalid Authentication, Incorrect API key provided or organization |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

