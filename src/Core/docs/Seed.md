# Pieces.Os.Core.SdkModel.Seed
A seed Model used to wrap a format or asset  Note: we will expand this now to support additional paramerters.  Note: however if create an asset, only pass in the asset, not passing in an asset in this case will cause the endpoint to fail.  TODO: for a breaking change update the type enum here to add support for the additional materials or remove it entirely.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Asset** | [**SeededAsset**](SeededAsset.md) |  | [optional] 
**Person** | [**SeededPerson**](SeededPerson.md) |  | [optional] 
**Anchor** | [**SeededAnchor**](SeededAnchor.md) |  | [optional] 
**Website** | [**SeededWebsite**](SeededWebsite.md) |  | [optional] 
**Type** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

