# Pieces.Os.Core.SdkModel.QGPTRelevanceOutput
This is the returned value from /code_gpt/relevance.  This will return the snippets that we found are relevant to the query you provided.  (optional) answer: in the case you provided question: true, then we will also return to you the answer to your question.  Note: - relevant: this is required property and will represent the relevant snippets, to your specific query.(NOTE: these snippet will all have respective id's and seed defined. even though id and seed are optional)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Answer** | [**QGPTQuestionOutput**](QGPTQuestionOutput.md) |  | [optional] 
**Relevant** | [**RelevantQGPTSeeds**](RelevantQGPTSeeds.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

