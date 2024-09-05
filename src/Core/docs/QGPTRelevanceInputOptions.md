# Pieces.Os.Core.SdkModel.QGPTRelevanceInputOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Database** | **bool** | This is an optional boolen that will tell us to use our entire snippet database as the sample. | [optional] 
**Question** | **bool** | This is an optional boolean, that will let the serve know if you want to combine the 2 endpointsboth relevance &amp;&amp; the Question endpoint to return the final results. | [optional] 
**Pipeline** | [**QGPTPromptPipeline**](QGPTPromptPipeline.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

