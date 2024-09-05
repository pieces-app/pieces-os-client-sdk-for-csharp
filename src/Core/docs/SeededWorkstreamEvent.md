# Pieces.Os.Core.SdkModel.SeededWorkstreamEvent
This is a precreated version of a WorkstreamEvent event, this will be used ingested into PiecesOS and PiecesOS will do all the magic to transform this into relevant data show in the workstream feed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 
**Application** | [**Application**](Application.md) |  | 
**Trigger** | [**WorkstreamEventTrigger**](WorkstreamEventTrigger.md) |  | 
**Context** | [**WorkstreamEventContext**](WorkstreamEventContext.md) |  | [optional] 
**Summary** | [**ReferencedWorkstreamSummary**](ReferencedWorkstreamSummary.md) |  | [optional] 
**InternalIdentifier** | **string** | This is used to override the event identifier, if this was an event that was originally in the internal events collection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

