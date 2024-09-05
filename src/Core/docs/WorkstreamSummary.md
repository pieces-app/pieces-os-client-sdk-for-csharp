# Pieces.Os.Core.SdkModel.WorkstreamSummary
This is representation or a summarized version of the highly relevant WorkstreamEvent events from a given time period, 1 day, 1 week, 1 month, dependinng on your given flow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Score** | [**Score**](Score.md) |  | [optional] 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Events** | [**FlattenedWorkstreamEvents**](FlattenedWorkstreamEvents.md) |  | [optional] 
**Name** | **string** |  | 
**Annotations** | [**FlattenedAnnotations**](FlattenedAnnotations.md) |  | [optional] 
**Ranges** | [**FlattenedRanges**](FlattenedRanges.md) |  | [optional] 
**Model** | [**Model**](Model.md) |  | 
**Websites** | [**FlattenedWebsites**](FlattenedWebsites.md) |  | [optional] 
**Anchors** | [**FlattenedAnchors**](FlattenedAnchors.md) |  | [optional] 
**Assets** | [**FlattenedAssets**](FlattenedAssets.md) |  | [optional] 
**Conversations** | [**FlattenedConversations**](FlattenedConversations.md) |  | [optional] 
**Persons** | [**FlattenedPersons**](FlattenedPersons.md) |  | [optional] 
**Applications** | [**Applications**](Applications.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

