# Pieces.Os.Core.SdkModel.FlattenedShare
This is a dag safe version of the Share.  if user is undefined && access is public then we have an asset that is publicly available.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** | This references the share it self. | 
**Asset** | **string** | this is the asset id on the flattened share. | [optional] 
**User** | **string** | this is the uuid of the user that the share is created for. | [optional] 
**Link** | **string** | this is the prebuilt link. | 
**Access** | **AccessEnum** |  | 
**Accessors** | [**Accessors**](Accessors.md) |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Short** | **string** | This is a shortened version of our uuid. | 
**Name** | **string** |  | [optional] 
**Assets** | [**FlattenedAssets**](FlattenedAssets.md) |  | [optional] 
**Distributions** | [**FlattenedDistributions**](FlattenedDistributions.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

