# Pieces.Os.Core.SdkModel.WorkstreamPatternEngineSource
This is a specific model for a given WPE qdrant source.  note: application is optional b/c we may want a network sorce in the future TODO: think about adding an enum or something that will delimit the type of processor(vision/filewatcher/network/audio)  TODO: in the future we can add tabs/filepaths to this model here. TODO: Enum for source/processor ? i.e. WorkstreamPatternEngineProcessorEnum.VISION, WorkstreamPatternEngineProcessorEnum.NETWORK, WorkstreamPatternEngineProcessorEnum.FILE_IO, WorkstreamPatternEngineProcessorEnum.AUDIO, etc.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Name** | **string** | This is the name of the window(foreground window)/application.(this will always be present) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

