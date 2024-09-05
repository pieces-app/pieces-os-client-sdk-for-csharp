# Pieces.Os.Core.SdkModel.SearchEngine
This will determine the type of search that will run  These are all different searching methods all of which are exclusive. Meaning that you cannot mix & match types.  operations: is here if you want to build complex searching behavior. (A || B) && (B || C) , note this can get very complex but can be as flexible as you need.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Query** | **string** |  | [optional] 
**Embeddings** | [**EmbeddingsSearchOptions**](EmbeddingsSearchOptions.md) |  | [optional] 
**FullText** | [**FullTextSearchOptions**](FullTextSearchOptions.md) |  | [optional] 
**Temporal** | [**TemporalSearchOptions**](TemporalSearchOptions.md) |  | [optional] 
**Workstream** | [**WorkstreamSearchOptions**](WorkstreamSearchOptions.md) |  | [optional] 
**Operations** | [**SearchEngines**](SearchEngines.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

