# Pieces.Os.Core.SdkModel.RevokedPKCE
A model to support revoking a Token Generated Through PKCE  The behaviour of this endpoint depends on the state of the Refresh Token Revocation Deletes Grant toggle.  If this toggle is enabled, then each revocation request invalidates not only the specific token, but all other tokens based on the same authorization grant.  This means that all Refresh Tokens that have been issued for the same user, application, and audience will be revoked. If this toggle is disabled, then only the refresh token is revoked, while the grant is left intact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**ClientId** | **string** | Your application&#39;s Client ID. The application should match the one the Refresh Token was issued for. | 
**Token** | **string** | The Refresh Token you want to revoke. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

