# Pieces.Os.Core.SdkModel.QGPTHintsInput
Query is your hints question. Relevant is the relevant snippets. Answer is the previous answer.(that we are asking a hint up for.)  Query and Answer are both optional here because, you may pass over relevant snippets over ahead of hand if you already have them to answer your questions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | **string** |  | [optional] 
**Answer** | [**QGPTQuestionAnswer**](QGPTQuestionAnswer.md) |  | [optional] 
**Relevant** | [**RelevantQGPTSeeds**](RelevantQGPTSeeds.md) |  | 
**Application** | **string** | optional application id | [optional] 
**Model** | **string** | optional model id | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

