# Pieces.Os.Core.SdkModel.QGPTConversationPipeline
This model is specifically for QGPT Conversation pipelines, the model is used to group conversational prompts for instance a conversation around generating code.  here are some use cases- 1. contextualized_code_generation- This is for users that want to have conversations around generating code, when there is provided context. 2. generalized_code- This is for users that want to have conversations without context around code. 3. contextualized_code- This is for users that want to have conversation around code with Context. 4. contextualized_code_workstream: this is for the users that want to use context as well as WPE information in their chat (we wiil prioritize WPE infomration, but also support other info as well)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**ContextualizedCodeGeneration** | [**QGPTConversationPipelineForContextualizedCodeGeneration**](QGPTConversationPipelineForContextualizedCodeGeneration.md) |  | [optional] 
**GeneralizedCodeDialog** | [**QGPTConversationPipelineForGeneralizedCodeDialog**](QGPTConversationPipelineForGeneralizedCodeDialog.md) |  | [optional] 
**ContextualizedCodeDialog** | [**QGPTConversationPipelineForContextualizedCodeDialog**](QGPTConversationPipelineForContextualizedCodeDialog.md) |  | [optional] 
**ContextualizedCodeWorkstreamDialog** | [**QGPTConversationPipelineForContextualizedCodeWorkstreamDialog**](QGPTConversationPipelineForContextualizedCodeWorkstreamDialog.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

