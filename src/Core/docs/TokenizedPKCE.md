# Pieces.Os.Core.SdkModel.TokenizedPKCE
This is the flow that mobile apps use to access an API. Use this endpoint to exchange an Authorization Code for a Token.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**GrantType** | **string** | Denotes the flow you are using. For Authorization Code, use authorization_code or refresh_token. | 
**ClientId** | **string** | Your application&#39;s Client ID. | 
**Code** | **string** | The Authorization Code received from the initial /authorize call. | 
**RedirectUri** | **string** | This is required only if it was set at the GET /authorize endpoint. The values must match. | 
**CodeVerifier** | **string** | Cryptographically random key that was used to generate the code_challenge passed to /authorize. | 
**Audience** | **string** | The audience domain: i.e. https://pieces.us.auth0.com | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

