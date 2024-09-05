# Pieces.Os.Core.SdkModel.SeededAssetSensitive
This is the seededAssetSensitive, this does not have an id yet as we will add it on the server side.  can optionally pass in our mechanism here, as the default will be manual unless specified.  This is different that hte SeededSensitive as this is pre-before the asset has been created.(but added when the asset is created.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Text** | **string** | this is the string representative of the sensative piece of data. | 
**Mechanism** | **MechanismEnum** |  | [optional] 
**Category** | **SensitiveCategoryEnum** |  | 
**Severity** | **SensitiveSeverityEnum** |  | 
**Name** | **string** |  | 
**Description** | **string** |  | 
**Metadata** | [**SensitiveMetadata**](SensitiveMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

