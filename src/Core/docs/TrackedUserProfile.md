# Pieces.Os.Core.SdkModel.TrackedUserProfile
A user that will be passed along with each analytics event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **Guid** | The ID of the user that you are tracking. | 
**Username** | **string** | This is a username that is attempted to be assigned but is \&quot;Anonymous User\&quot; by default | [default to "unknown"]
**Email** | **string** | The user&#39;s email if we have it. | [optional] 
**Granularity** | **string** | At what level is this user being tracked. | [default to GranularityEnum.ANONYMOUS]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

