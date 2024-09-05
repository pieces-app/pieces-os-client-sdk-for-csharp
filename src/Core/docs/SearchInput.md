# Pieces.Os.Core.SdkModel.SearchInput
generic endpoint body for the searching endpoints  query: this is optional, but the query string you will use to find your material  mode: this is the searching method/type that we will use to search your materials  TODO: consider passing in a score here ie only return things that match references/reuse/updates/...etc > x  TODO will want to consider returning related materials to this material potentially both associated/ and not associated materials, this would be an input property of suggestions?:boolean that will say if they want suggested materials returned as well

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Engines** | [**SearchEngines**](SearchEngines.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

