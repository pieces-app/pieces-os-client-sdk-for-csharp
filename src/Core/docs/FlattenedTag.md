# Pieces.Os.Core.SdkModel.FlattenedTag
This is a Flattened Version of a Tag.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Text** | **string** |  | 
**Mechanisms** | [**Dictionary&lt;string, MechanismEnum&gt;**](MechanismEnum.md) | This is a Map&lt;String, MechanismEnum&gt; where the the key is an asset id. | [optional] 
**Assets** | [**FlattenedAssets**](FlattenedAssets.md) |  | [optional] 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Category** | **TagCategoryEnum** |  | 
**Relationship** | [**Relationship**](Relationship.md) |  | [optional] 
**Interactions** | **int** | This is an optional value that will keep track of the number of times this has been interacted with. | [optional] 
**Persons** | [**FlattenedPersons**](FlattenedPersons.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

