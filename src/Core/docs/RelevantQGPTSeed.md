# Pieces.Os.Core.SdkModel.RelevantQGPTSeed
This is a generic model used, to wrap a seed, as well as give an identifier used to further identifiy this snippet.  Seed is optional here because you may just want to provide the id, and not the original seed.  id is also optional here as you may provide an id or not here.(however with specific endpoint this ID is a guarentee.)  location:(optional) if a path or an anchor is passed in, this will let us know the specific location within the 'file' that this relevant seed is located           note: if this is null and a path/anchor is present then we will use the entire file that is provided.(this logic will be determined within the relevance flow & not by the user)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | [optional] 
**Seed** | [**Seed**](Seed.md) |  | [optional] 
**Path** | **string** | This is an optional file path | [optional] 
**Anchor** | [**ReferencedAnchor**](ReferencedAnchor.md) |  | [optional] 
**Asset** | [**ReferencedAsset**](ReferencedAsset.md) |  | [optional] 
**Location** | [**TextLocation**](TextLocation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

