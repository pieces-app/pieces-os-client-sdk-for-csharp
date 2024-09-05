# Pieces.Os.Core.SdkModel.QGPTStreamOutput
This is the out for the /qgpt/stream endpoint.  200: success 401: invalid authentication/api key 429: Rate limit/Quota exceeded 500: server had an error 503: the engine is currently overloaded

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Request** | **string** | This is the id used to represent the stream of response. this will always be present. We will use the value passed inby the client, or we will generate one. | [optional] 
**Relevance** | [**QGPTRelevanceOutput**](QGPTRelevanceOutput.md) |  | [optional] 
**Question** | [**QGPTQuestionOutput**](QGPTQuestionOutput.md) |  | [optional] 
**Status** | **QGPTStreamEnum** |  | [optional] 
**Conversation** | **string** | This is the ID of a predefined persisted conversation, if this is not present we will create a new conversation for the input/output.(in the case of a question) | 
**StatusCode** | **decimal?** | This will be provided | [optional] 
**ErrorMessage** | **string** | optional error message is the status code is NOT 200 | [optional] 
**AgentRoutes** | [**QGPTAgentRoutes**](QGPTAgentRoutes.md) |  | [optional] 
**Extracted** | [**QGPTStreamedOutputExtractedMaterials**](QGPTStreamedOutputExtractedMaterials.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

