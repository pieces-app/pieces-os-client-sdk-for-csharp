# Pieces.Os.Core.SdkModel.QGPTRepromptInput
Query is your followup question.  Conversation is a list of the back and fourth with the qgpt bot. where the first entry in the array was the last message sent.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Query** | **string** |  | 
**Conversation** | [**QGPTConversation**](QGPTConversation.md) |  | 
**Application** | **string** | optional application id | [optional] 
**Model** | **string** | optional model id | [optional] 
**Pipeline** | [**QGPTPromptPipeline**](QGPTPromptPipeline.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

