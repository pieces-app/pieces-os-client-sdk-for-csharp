# Pieces.Os.Core.SdkModel.SeededSensitive
This is the seededSensitive, this does not have an id yet as we will add it on the server side.  can optionally pass in our mechanism here, as the default will be manual unless specified.  TODO consider updating these asset,format to referenced Models

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Asset** | **string** |  | 
**Text** | **string** | this is the string representative of the sensative piece of data. | 
**Mechanism** | **MechanismEnum** |  | [optional] 
**Category** | **SensitiveCategoryEnum** |  | 
**Severity** | **SensitiveSeverityEnum** |  | 
**Name** | **string** |  | 
**Description** | **string** |  | 
**Metadata** | [**SensitiveMetadata**](SensitiveMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

