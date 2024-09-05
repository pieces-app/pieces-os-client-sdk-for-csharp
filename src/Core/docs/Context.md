# Pieces.Os.Core.SdkModel.Context
A Context that is returned from almost all calls to the ContextAPI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Os** | **string** | This is th UUID of the OS that this context is currently connected to. This attempts to be the same as Segment&#39;s anonmyousId feild. It is attempted to be set at initial installation at Pieces/.identity/.os | 
**Application** | [**Application**](Application.md) |  | 
**Health** | [**Health**](Health.md) |  | 
**User** | [**UserProfile**](UserProfile.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

