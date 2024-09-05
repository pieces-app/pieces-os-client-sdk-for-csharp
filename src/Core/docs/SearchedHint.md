# Pieces.Os.Core.SdkModel.SearchedHint
This is used for the Hint searching endpoint  hint here is only provided if transferables are set to true.  temporal: if this is provided this means that their material matched the input via a timestamp.  TODO will want to consider returning related materials to this material potentially both associated/ and not associated materials ie suggestion: WorkstreamSuggestions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Hint** | [**Hint**](Hint.md) |  | [optional] 
**Exact** | **bool** |  | 
**Similarity** | **decimal** |  | 
**Temporal** | **bool** |  | [optional] 
**Identifier** | **string** | This is the uuid of the hint. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

