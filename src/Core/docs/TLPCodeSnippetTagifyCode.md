# Pieces.Os.Core.SdkModel.TLPCodeSnippetTagifyCode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Distribution** | **string** | stringified array of numbers | 
**InferredDistribution** | **string** | stringified array of numbers | 
**Tags** | **string** | stringified array of strings | 
**InferredTags** | **string** | stringified array of strings | 
**Model** | **string** | this is the model version  | 
**LabelVersion** | **string** | This is the version of the file that we are using that contains all the possible tags | 
**Threshold** | **decimal** | this is the minimum score from the model that a tag needs to have to be included in the tags array. | 
**InferredThreshold** | **decimal** | this is the minimum score from the postprocessing that a tag needs to have to be included in the inferred_tags array. | 
**Context** | **string** | this is the origin in which this asset was created, application(string representation) | 
**Asset** | **string** | This is the asset id. | 
**Os** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

