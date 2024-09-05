# Pieces.Os.Core.SdkModel.AssetFilter
** in the future, consider adding an optional bool's called nextAnd, nextOr which will say that the next filter will be  AND behavor or OR behavior.  \"operations\": here is is an optional property to allow or behavior,(we will only allow 1 level deep of or's), if or is not passed in then it is just simply ignored. If or is passed in then we will be or'd together with the top level filter and considered extras. default behavior for operations is and, however yoour can specifiy OR operations as well.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Classification** | **ClassificationSpecificEnum** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**Websites** | **List&lt;string&gt;** |  | [optional] 
**Persons** | **List&lt;string&gt;** |  | [optional] 
**Phrase** | [**AssetFilterPhrase**](AssetFilterPhrase.md) |  | [optional] 
**Created** | [**AssetFilterTimestamp**](AssetFilterTimestamp.md) |  | [optional] 
**Updated** | [**AssetFilterTimestamp**](AssetFilterTimestamp.md) |  | [optional] 
**Operations** | [**AssetFilters**](AssetFilters.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

