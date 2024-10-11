# Pieces.Os.Core.SdkModel.SeededWorkstreamIngestion
This is used as the input in the Context ingestion endpoint for the feed.  This will take in a required seed, this will get created as an internal WorkstreamEvent until we determine internally that this event is relevant and will then attach it to a WorkstreamSummary and it will get moved over to a WorkstreamEvent.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Event** | [**SeededWorkstreamEvent**](SeededWorkstreamEvent.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

