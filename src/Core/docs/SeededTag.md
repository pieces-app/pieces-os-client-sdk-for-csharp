# Pieces.Os.Core.SdkModel.SeededTag
This is the minimum information needed when creating a Tag.  Default we will attach manual to a tag unless otherwise specified for mechanism.  you can optionally add an asset, format, or person uuid to attach this tag directly to it  TODO consider updating these asset,format to referenced Models

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Text** | **string** | This is the description of the tag. | 
**Asset** | **string** | this is a uuid that references an asset. | [optional] 
**Mechanism** | **MechanismEnum** |  | [optional] 
**Category** | **TagCategoryEnum** |  | [optional] 
**Person** | **string** | uuid of the person, you want to add this tag too | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

