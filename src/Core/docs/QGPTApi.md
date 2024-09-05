# Pieces.Os.Core.Api.QGPTApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Hints**](QGPTApi.md#hints) | **POST** /qgpt/hints | /qgpt/hints [POST] |
| [**PersonsRelated**](QGPTApi.md#personsrelated) | **POST** /qgpt/persons/related | /qgpt/persons/related [POST] |
| [**QgptStream**](QGPTApi.md#qgptstream) | **GET** /qgpt/stream | /qgpt/stream [WS] |
| [**Question**](QGPTApi.md#question) | **POST** /qgpt/question | /qgpt/question [POST] |
| [**Relevance**](QGPTApi.md#relevance) | **POST** /qgpt/relevance | /qgpt/relevance [POST] |
| [**Reprompt**](QGPTApi.md#reprompt) | **POST** /qgpt/reprompt | /qgpt/reprompt [POST] |

<a id="hints"></a>
# **Hints**
> QGPTQuestionOutput Hints (QGPTHintsInput qGPTHintsInput = null)

/qgpt/hints [POST]

Generates suggested questions that users can ask. It accepts the answer displayed to the user, relevant code snippets used for the answer, and the previous query as inputs. In return, it provides a list of questions that can be presented to the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class HintsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new QGPTApi(config);
            var qGPTHintsInput = new QGPTHintsInput(); // QGPTHintsInput |  (optional) 

            try
            {
                // /qgpt/hints [POST]
                QGPTQuestionOutput result = apiInstance.Hints(qGPTHintsInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QGPTApi.Hints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HintsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /qgpt/hints [POST]
    ApiResponse<QGPTQuestionOutput> response = apiInstance.HintsWithHttpInfo(qGPTHintsInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QGPTApi.HintsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **qGPTHintsInput** | [**QGPTHintsInput**](QGPTHintsInput.md) |  | [optional]  |

### Return type

[**QGPTQuestionOutput**](QGPTQuestionOutput.md)

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

<a id="personsrelated"></a>
# **PersonsRelated**
> QGPTPersonsRelatedOutput PersonsRelated (bool? transferables = null, QGPTPersonsRelatedInput qGPTPersonsRelatedInput = null)

/qgpt/persons/related [POST]

Utilize this endpoint for Who Support, identifying individuals who can provide assistance when given context such as a Seed or a QGPT Conversation, for example.  Input:   - (optional) seed: Seed - Only supports fragments for now.   - (optional) conversation: QGPTConversation.  Output:   - persons: Persons

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class PersonsRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new QGPTApi(config);
            var transferables = true;  // bool? | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) (optional) 
            var qGPTPersonsRelatedInput = new QGPTPersonsRelatedInput(); // QGPTPersonsRelatedInput |  (optional) 

            try
            {
                // /qgpt/persons/related [POST]
                QGPTPersonsRelatedOutput result = apiInstance.PersonsRelated(transferables, qGPTPersonsRelatedInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QGPTApi.PersonsRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /qgpt/persons/related [POST]
    ApiResponse<QGPTPersonsRelatedOutput> response = apiInstance.PersonsRelatedWithHttpInfo(transferables, qGPTPersonsRelatedInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QGPTApi.PersonsRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferables** | **bool?** | This is a boolean that will decided if we are want to return the transferable data (default) or not(performance enhancement) | [optional]  |
| **qGPTPersonsRelatedInput** | [**QGPTPersonsRelatedInput**](QGPTPersonsRelatedInput.md) |  | [optional]  |

### Return type

[**QGPTPersonsRelatedOutput**](QGPTPersonsRelatedOutput.md)

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

<a id="qgptstream"></a>
# **QgptStream**
> QGPTStreamOutput QgptStream (QGPTStreamInput qGPTStreamInput = null)

/qgpt/stream [WS]

Provides a WebSocket connection that streams inputs to the qGPT model. It handles relevance and questions, but will throw an error if both are passed in simultaneously. However, if you wish to utilize both question and relevance, you can obtain stream results by passing relevance with the option 'question:true'. It is designed to manage multiple conversations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class QgptStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new QGPTApi(config);
            var qGPTStreamInput = new QGPTStreamInput(); // QGPTStreamInput |  (optional) 

            try
            {
                // /qgpt/stream [WS]
                QGPTStreamOutput result = apiInstance.QgptStream(qGPTStreamInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QGPTApi.QgptStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QgptStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /qgpt/stream [WS]
    ApiResponse<QGPTStreamOutput> response = apiInstance.QgptStreamWithHttpInfo(qGPTStreamInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QGPTApi.QgptStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **qGPTStreamInput** | [**QGPTStreamInput**](QGPTStreamInput.md) |  | [optional]  |

### Return type

[**QGPTStreamOutput**](QGPTStreamOutput.md)

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
| **429** | Rate limit/Quota exceeded |  -  |
| **500** | Internal Server Error |  -  |
| **503** | The engine is currently overloaded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="question"></a>
# **Question**
> QGPTQuestionOutput Question (QGPTQuestionInput qGPTQuestionInput = null)

/qgpt/question [POST]

Processes relevant code snippets or UUIDs returned from the /qgpt/relevance endpoint, along with a question query, to provide possible answers.  Note:   - Relevant seeds must either include an ID used within the /qgpt/relevance endpoint or a seed with a fragment/string; otherwise, an error will be thrown.   - This endpoint utilizes your query and relevant snippets to generate multiple answers, each accompanied by a score.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class QuestionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new QGPTApi(config);
            var qGPTQuestionInput = new QGPTQuestionInput(); // QGPTQuestionInput |  (optional) 

            try
            {
                // /qgpt/question [POST]
                QGPTQuestionOutput result = apiInstance.Question(qGPTQuestionInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QGPTApi.Question: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QuestionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /qgpt/question [POST]
    ApiResponse<QGPTQuestionOutput> response = apiInstance.QuestionWithHttpInfo(qGPTQuestionInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QGPTApi.QuestionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **qGPTQuestionInput** | [**QGPTQuestionInput**](QGPTQuestionInput.md) |  | [optional]  |

### Return type

[**QGPTQuestionOutput**](QGPTQuestionOutput.md)

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
| **429** | Too Many Requests (Rate limit or quota exceeded) |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable, (engine is currently overloaded) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="relevance"></a>
# **Relevance**
> QGPTRelevanceOutput Relevance (QGPTRelevanceInput qGPTRelevanceInput = null)

/qgpt/relevance [POST]

This is the first phase to the QGPT flow.  Please one of the following. 1. provide an absolute path on the users machine that we can use locally. 2. provide Seeds that you want to compare to, which will be ONLY fragment/string values(all other values will be ignored) 3. provide assets, here you can provide an iterable of the asset id, and we will do the rest 4. you can set your database boolean to true which will tell us to use your entire DB as the query space.  required - query: string; This is the question of the user. optional - question: boolean; This will by-pass the second endpoint and just ask the question and return the results(as an ease of use bool)  This endpoint will embed everything. and will return the relevance snippets that we will use in the next phase, to answer your question.  on the UI: we can show this to users (around this is the snippets we used to answer your question.)  Next: feed this information to the /qgpt/question [POST] endpoint to get your question answered.(unless you included the question:true optional boolean, then you will get the results from here.)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class RelevanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new QGPTApi(config);
            var qGPTRelevanceInput = new QGPTRelevanceInput(); // QGPTRelevanceInput |  (optional) 

            try
            {
                // /qgpt/relevance [POST]
                QGPTRelevanceOutput result = apiInstance.Relevance(qGPTRelevanceInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QGPTApi.Relevance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RelevanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /qgpt/relevance [POST]
    ApiResponse<QGPTRelevanceOutput> response = apiInstance.RelevanceWithHttpInfo(qGPTRelevanceInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QGPTApi.RelevanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **qGPTRelevanceInput** | [**QGPTRelevanceInput**](QGPTRelevanceInput.md) |  | [optional]  |

### Return type

[**QGPTRelevanceOutput**](QGPTRelevanceOutput.md)

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
| **429** | Too Many Requests (Rate limit or quota exceeded) |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable, (engine is currently overloaded) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reprompt"></a>
# **Reprompt**
> QGPTRepromptOutput Reprompt (QGPTRepromptInput qGPTRepromptInput = null)

/qgpt/reprompt [POST]

This will take in a followup question and the history of the conversation, and emit your a prompt or query that you can pass to the /qgpt/relevance and then the /qgpt/question endpoint to get your next answer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class RepromptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new QGPTApi(config);
            var qGPTRepromptInput = new QGPTRepromptInput(); // QGPTRepromptInput |  (optional) 

            try
            {
                // /qgpt/reprompt [POST]
                QGPTRepromptOutput result = apiInstance.Reprompt(qGPTRepromptInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QGPTApi.Reprompt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RepromptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /qgpt/reprompt [POST]
    ApiResponse<QGPTRepromptOutput> response = apiInstance.RepromptWithHttpInfo(qGPTRepromptInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QGPTApi.RepromptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **qGPTRepromptInput** | [**QGPTRepromptInput**](QGPTRepromptInput.md) |  | [optional]  |

### Return type

[**QGPTRepromptOutput**](QGPTRepromptOutput.md)

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

