# Pieces.Os.Core.Api.MachineLearningApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PersonificationTechnicalLanguageGeneration**](MachineLearningApi.md#personificationtechnicallanguagegeneration) | **POST** /machine_learning/text/technical_language/generators/personification | /machine_learning/text/technical_language/generators/personification [GET] |
| [**SegmentTechnicalLanguage**](MachineLearningApi.md#segmenttechnicallanguage) | **POST** /machine_learning/text/technical_language/parsers/segmentation | /machine_learning/text/technical_language/parsers/segmentation [POST] |

<a id="personificationtechnicallanguagegeneration"></a>
# **PersonificationTechnicalLanguageGeneration**
> OnboardedPersonaDetails PersonificationTechnicalLanguageGeneration (PreonboardedPersonaDetails preonboardedPersonaDetails = null)

/machine_learning/text/technical_language/generators/personification [GET]

This is going to take in some personification details ie languages & personas.  and will return generated Seeds that can be used as snippets post/pre onboarding.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonificationTechnicalLanguageGenerationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new MachineLearningApi(config);
            var preonboardedPersonaDetails = new PreonboardedPersonaDetails(); // PreonboardedPersonaDetails |  (optional) 

            try
            {
                // /machine_learning/text/technical_language/generators/personification [GET]
                OnboardedPersonaDetails result = apiInstance.PersonificationTechnicalLanguageGeneration(preonboardedPersonaDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MachineLearningApi.PersonificationTechnicalLanguageGeneration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonificationTechnicalLanguageGenerationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /machine_learning/text/technical_language/generators/personification [GET]
    ApiResponse<OnboardedPersonaDetails> response = apiInstance.PersonificationTechnicalLanguageGenerationWithHttpInfo(preonboardedPersonaDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MachineLearningApi.PersonificationTechnicalLanguageGenerationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **preonboardedPersonaDetails** | [**PreonboardedPersonaDetails**](PreonboardedPersonaDetails.md) |  | [optional]  |

### Return type

[**OnboardedPersonaDetails**](OnboardedPersonaDetails.md)

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

<a id="segmenttechnicallanguage"></a>
# **SegmentTechnicalLanguage**
> SegmentedTechnicalLanguage SegmentTechnicalLanguage (bool? classify = null, UnsegmentedTechnicalLanguage unsegmentedTechnicalLanguage = null)

/machine_learning/text/technical_language/parsers/segmentation [POST]

This is a functional endpoint that will parse a message or text in to text or code.  if the optional query param is passed along 'classify' then we will optionally classify the just the code that is segmented.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SegmentTechnicalLanguageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new MachineLearningApi(config);
            var classify = true;  // bool? | This will let us know if you want us to classifiy your code, this is default to false. (optional) 
            var unsegmentedTechnicalLanguage = new UnsegmentedTechnicalLanguage(); // UnsegmentedTechnicalLanguage |  (optional) 

            try
            {
                // /machine_learning/text/technical_language/parsers/segmentation [POST]
                SegmentedTechnicalLanguage result = apiInstance.SegmentTechnicalLanguage(classify, unsegmentedTechnicalLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MachineLearningApi.SegmentTechnicalLanguage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SegmentTechnicalLanguageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /machine_learning/text/technical_language/parsers/segmentation [POST]
    ApiResponse<SegmentedTechnicalLanguage> response = apiInstance.SegmentTechnicalLanguageWithHttpInfo(classify, unsegmentedTechnicalLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MachineLearningApi.SegmentTechnicalLanguageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **classify** | **bool?** | This will let us know if you want us to classifiy your code, this is default to false. | [optional]  |
| **unsegmentedTechnicalLanguage** | [**UnsegmentedTechnicalLanguage**](UnsegmentedTechnicalLanguage.md) |  | [optional]  |

### Return type

[**SegmentedTechnicalLanguage**](SegmentedTechnicalLanguage.md)

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

