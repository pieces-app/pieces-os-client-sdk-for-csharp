# Pieces.Os.Core.SdkModel.Share
This represents what information that is relavent to anything and every sharing related. v1 will look very bare and will add more and more data as we go!  if user is undefined && access is public then we have an asset that is publicly available.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** | This is the uuid that represents this share model. | 
**User** | **string** | this is the uuid of the user that the share is created for. | [optional] 
**Asset** | [**FlattenedAsset**](FlattenedAsset.md) |  | [optional] 
**Assets** | [**FlattenedAssets**](FlattenedAssets.md) |  | [optional] 
**Link** | **string** | This is the prebuilt link. | 
**Access** | **AccessEnum** |  | 
**Accessors** | [**Accessors**](Accessors.md) |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**VarShort** | **string** | This is a shortened version of our uuid. | 
**Name** | **string** | this is an optional name we can give to the link, ie ?p&#x3D;JAVASCRIPT or what ever the user wants as long as it is available. | [optional] 
**Distributions** | [**Distributions**](Distributions.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

