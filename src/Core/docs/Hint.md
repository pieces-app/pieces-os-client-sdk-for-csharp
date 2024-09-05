# Pieces.Os.Core.SdkModel.Hint
This is a hint that is attached to an asset, used for suggested_queries, and hints given via the qgpt flow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Mechanisms** | [**Dictionary&lt;string, MechanismEnum&gt;**](MechanismEnum.md) | This is a Map&lt;String, MechanismEnum&gt; where the the key is an asset id. | [optional] 
**Assets** | [**FlattenedAssets**](FlattenedAssets.md) |  | [optional] 
**Type** | **HintTypeEnum** |  | 
**Text** | **string** | This is the text of the hint. | 
**Model** | [**ReferencedModel**](ReferencedModel.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

