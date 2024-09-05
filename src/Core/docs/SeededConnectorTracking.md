# Pieces.Os.Core.SdkModel.SeededConnectorTracking
This model is designed to be light weight and low friction while most of the heavy lifting will be happening inside of the context servers.  This Model is important because this has references to our materials, instead of fully referenced materials.(very similar to our SeededTrackedEvent, consider consolidating and converting these to Referenced models instead of ID's)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Format** | [**SeededTrackedFormatEvent**](SeededTrackedFormatEvent.md) |  | [optional] 
**Asset** | [**SeededTrackedAssetEvent**](SeededTrackedAssetEvent.md) |  | [optional] 
**Interaction** | [**SeededTrackedInteractionEvent**](SeededTrackedInteractionEvent.md) |  | [optional] 
**Keyboard** | [**SeededTrackedKeyboardEvent**](SeededTrackedKeyboardEvent.md) |  | [optional] 
**Session** | [**SeededTrackedSessionEvent**](SeededTrackedSessionEvent.md) |  | [optional] 
**Assets** | [**SeededTrackedAssetsEvent**](SeededTrackedAssetsEvent.md) |  | [optional] 
**Ml** | [**SeededTrackedMachineLearningEvent**](SeededTrackedMachineLearningEvent.md) |  | [optional] 
**Adoption** | [**SeededTrackedAdoptionEvent**](SeededTrackedAdoptionEvent.md) |  | [optional] 
**Conversation** | [**SeededTrackedConversationEvent**](SeededTrackedConversationEvent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

