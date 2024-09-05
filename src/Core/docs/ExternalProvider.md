# Pieces.Os.Core.SdkModel.ExternalProvider
I know that profileData and user_id have differeing casing but they are done because they map to Auth0's projeecties.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Type** | **ExternalProviderTypeEnum** |  | 
**UserId** | **string** | This is the user_id within the provider. | 
**AccessToken** | **string** | This is optional here, but will be present for BB, Github, and google. | [optional] 
**ExpiresIn** | **int** | Some providers have an expiration on their access token. IE BB, Google, NOT Github. | [optional] 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**ProfileData** | [**ExternalProviderProfileData**](ExternalProviderProfileData.md) |  | [optional] 
**Connection** | **string** | This is an optional field that will be provided onentreprise connections. ie is type &#x3D;&#x3D; waad then connection might be PiecesApp. However is other cases,you my find your provider and connection is the exact same string. To decifer between the two, you can use the isSocial bool. | [optional] 
**IsSocial** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

