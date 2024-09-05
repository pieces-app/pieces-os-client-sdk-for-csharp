# Pieces.Os.Core.SdkModel.QGPTQuestionInput
This is the body input for the /code_gpt/question.  Note: - each relevant seed, must require at minimum a Seed or an id used from the /code_gpt/relevance endpoint or we will throw an error.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Relevant** | [**RelevantQGPTSeeds**](RelevantQGPTSeeds.md) |  | 
**Query** | **string** | This is the user asked question. | 
**Application** | **string** | optional application id | [optional] 
**Model** | **string** | optional model id | [optional] 
**Messages** | [**FlattenedConversationMessages**](FlattenedConversationMessages.md) |  | [optional] 
**Pipeline** | [**QGPTPromptPipeline**](QGPTPromptPipeline.md) |  | [optional] 
**Temporal** | [**TemporalRangeGrounding**](TemporalRangeGrounding.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

