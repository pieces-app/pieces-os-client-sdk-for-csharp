# Pieces.Os.Core.SdkModel.QGPTTaskPipelineForCodeFix
This task is for fixing a bit of code.  This is a class so that we can add optional properties in the future.  Note: the snippet && language that needs to be fixed should be within the QGPTQuestionInput.relevant.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Error** | **string** | This is the error message provided from the IDE, that we can use to provide the solution. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

