# Pieces.Os.Core.SdkModel.SearchedPerson
This is used for the Persons searching endpoint.  person here is only provided if transferables are set to true.  temporal: if this is provided this means that their material matched the input via a timestamp.  TODO will want to consider returning related materials to this material potentially both associated/ and not associated materials ie suggestion: WorkstreamSuggestions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Person** | [**Person**](Person.md) |  | [optional] 
**Exact** | **bool** |  | 
**Similarity** | **decimal** |  | 
**Temporal** | **bool** |  | [optional] 
**Identifier** | **string** | This is the uuid of the person. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

