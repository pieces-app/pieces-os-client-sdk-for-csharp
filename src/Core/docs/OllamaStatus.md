# Pieces.Os.Core.SdkModel.OllamaStatus
This will get used in the Websocket and in the get request for Ollama Note:  - updating (nullable) will be used in the case an update is underway  - installing (nullable) will be used in the case an installation is underway  - updateRequired (nullable) will be used in the case an update is required  - installation (nullable) will be provided in the case Ollama is installed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Updating** | [**OllamaDeployment**](OllamaDeployment.md) |  | [optional] 
**Installing** | [**OllamaDeployment**](OllamaDeployment.md) |  | [optional] 
**UpdateRequired** | [**OllamaDeployment**](OllamaDeployment.md) |  | [optional] 
**Installation** | [**OllamaDeployment**](OllamaDeployment.md) |  | [optional] 
**Recommendation** | [**OllamaRecommendation**](OllamaRecommendation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

