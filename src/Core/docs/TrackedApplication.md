# Pieces.Os.Core.SdkModel.TrackedApplication
A Model to describe what application a format/analytics event originated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** | The ID of the tracked application. | 
**Name** | **ApplicationNameEnum** |  | 
**VarVersion** | **string** | This is the specific version number 0.0.0 | 
**Platform** | **PlatformEnum** |  | 
**AutomaticUnload** | **bool** | This is a proper that will let us know if we will proactivity unload all of your machine learning models.by default this is false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

