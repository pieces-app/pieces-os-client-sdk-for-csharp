# Pieces.Os.Core.SdkModel.QGPTPromptPipeline
This is a model related to switching between different prompts based on if we are dealing with  various tasks or if we are attempting to converse with LLMs via conversation.  You will have 2 options-  1) task- This is specifically for 1 off task operations for instance explaning a bit of code 2) conversation- This is specifically for conversing with our LLMs, will provide better results && high fedility                responses for instance contextualize code conversations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Task** | [**QGPTTaskPipeline**](QGPTTaskPipeline.md) |  | [optional] 
**Conversation** | [**QGPTConversationPipeline**](QGPTConversationPipeline.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

