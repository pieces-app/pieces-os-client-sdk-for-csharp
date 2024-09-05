# Pieces.Os.Core.SdkModel.SeededDiscoverableSensitive
This is the SeededDiscoverableSensitive, this has every property that the seededSensitive has except this one is all optionally passed in. and will override our classification if provided.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Asset** | **string** |  | 
**Text** | **string** | this is the string representative of the sensative piece of data. | 
**Mechanism** | **MechanismEnum** |  | [optional] 
**Category** | **SensitiveCategoryEnum** |  | [optional] 
**Severity** | **SensitiveSeverityEnum** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Metadata** | [**SensitiveMetadata**](SensitiveMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

