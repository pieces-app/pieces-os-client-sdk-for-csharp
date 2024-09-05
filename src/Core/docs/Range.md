# Pieces.Os.Core.SdkModel.Range
This is an identified Range, this is ONLY needed when using plural rangedTimestamps, in order to ensure granularity(add/modify/delete)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Score** | [**Score**](Score.md) |  | [optional] 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**To** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**From** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Between** | **bool** |  | [optional] 
**Summaries** | [**FlattenedWorkstreamSummaries**](FlattenedWorkstreamSummaries.md) |  | [optional] 
**Conversations** | [**FlattenedConversations**](FlattenedConversations.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

