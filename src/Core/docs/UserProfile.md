# Pieces.Os.Core.SdkModel.UserProfile
This is the model for a user logged into Pieces.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Picture** | **string** | mapped from picture.URL pointing to the user&#39;s profile picture.  | [optional] [default to "https://picsum.photos/200"]
**Email** | **string** |  | [optional] [default to "user@pieces.app"]
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Username** | **string** |  (unique) User&#39;s username.   | [optional] 
**Id** | **string** |  | 
**Name** | **string** | This is the name of the User. | [optional] 
**Aesthetics** | [**Aesthetics**](Aesthetics.md) |  | 
**Vanityname** | **string** |  | [optional] 
**Allocation** | [**AllocationCloud**](AllocationCloud.md) |  | [optional] 
**Providers** | [**ExternalProviders**](ExternalProviders.md) |  | [optional] 
**Auth0** | [**Auth0UserMetadata**](Auth0UserMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

