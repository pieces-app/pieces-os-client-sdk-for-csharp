# Pieces.Os.Core.SdkModel.SeededTrackedAssetEvent
This seeded tracked asset event will be recieved by a context on the OS Server side, which will then be able to look up the asset id and structure the asset for shipment to Segment aka a fully built TrackedAssetEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Asset** | [**ReferencedAsset**](ReferencedAsset.md) |  | 
**IdentifierDescriptionPair** | [**TrackedAssetEventIdentifierDescriptionPairs**](TrackedAssetEventIdentifierDescriptionPairs.md) |  | 
**Metadata** | [**TrackedAssetEventMetadata**](TrackedAssetEventMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

