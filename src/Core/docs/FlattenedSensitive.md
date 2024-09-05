# Pieces.Os.Core.SdkModel.FlattenedSensitive
This is a dereferenced representation of a sensitive pieces of data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Asset** | [**ReferencedAsset**](ReferencedAsset.md) |  | 
**Text** | **string** |  | 
**Mechanism** | **MechanismEnum** |  | 
**Category** | **SensitiveCategoryEnum** |  | 
**Severity** | **SensitiveSeverityEnum** |  | 
**Name** | **string** |  | 
**Description** | **string** |  | 
**Metadata** | [**SensitiveMetadata**](SensitiveMetadata.md) |  | [optional] 
**Interactions** | **int** | This is an optional value that will keep track of the number of times this has been interacted with. | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

