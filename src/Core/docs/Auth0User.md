# Pieces.Os.Core.SdkModel.Auth0User

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  User&#39;s full name. | [optional] 
**Picture** | **string** | mapped from picture.URL pointing to the user&#39;s profile picture.  | [optional] 
**Email** | **string** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**EmailVerified** | **bool** | Indicates whether the user has verified their email address. Mapped from email_verified -&gt; emailVerified. | [optional] 
**FamilyName** | **string** | User&#39;s family name. | [optional] 
**GivenName** | **string** | User&#39;s given name.  | [optional] 
**Identities** | [**List&lt;Auth0Identity&gt;**](Auth0Identity.md) | Contains info retrieved from the identity provider with which the user originally authenticates. | [optional] 
**Nickname** | **string** | User&#39;s nickname.  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**Username** | **string** |  (unique) User&#39;s username.   | [optional] 
**UserMetadata** | [**Auth0UserMetadata**](Auth0UserMetadata.md) |  | [optional] 
**Locale** | **string** |  | [optional] 
**UserId** | **string** |  | [optional] 
**LastIp** | **string** |  | [optional] 
**LastLogin** | **DateTime** |  | [optional] 
**LoginsCount** | **int** |  | [optional] 
**BlockedFor** | **List&lt;string&gt;** |  | [optional] 
**GuardianAuthenticators** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

