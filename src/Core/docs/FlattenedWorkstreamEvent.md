# Pieces.Os.Core.SdkModel.FlattenedWorkstreamEvent
This is a singular (DAG Safe) version of a WorkstreamEvent.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Score** | [**Score**](Score.md) |  | [optional] 
**Application** | [**Application**](Application.md) |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Trigger** | [**WorkstreamEventTrigger**](WorkstreamEventTrigger.md) |  | 
**Context** | [**WorkstreamEventContext**](WorkstreamEventContext.md) |  | [optional] 
**Summaries** | [**FlattenedWorkstreamSummaries**](FlattenedWorkstreamSummaries.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

