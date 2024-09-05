# Pieces.Os.Core.SdkModel.Suggestion
This is the model return by the connector's suggest endpoint.  Note: assets are the assets that this target was ran against.  distribution is the distribution that we generated from comparing the target to the asset's vectors.(currently uuid(assetid) : value that is the difference between the asset and the target) **could potentially make an additional model here that is an array from most to least relevent.  *** distribution is required but we are currently unable to reflect that with our current dart generation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Reuse** | [**ReuseSuggestion**](ReuseSuggestion.md) |  | 
**Save** | [**SaveSuggestion**](SaveSuggestion.md) |  | 
**Target** | [**SuggestionTarget**](SuggestionTarget.md) |  | 
**Assets** | [**Assets**](Assets.md) |  | 
**Distribution** | **Dictionary&lt;string, decimal&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

