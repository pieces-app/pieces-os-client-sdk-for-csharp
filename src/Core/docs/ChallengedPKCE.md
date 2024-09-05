# Pieces.Os.Core.SdkModel.ChallengedPKCE
A model that Generates A PKCE Challenge Object with the needed requirements.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**State** | **Guid** | An opaque value the clients adds to the initial request that Auth0 includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks. | 
**Nonce** | **Guid** | A local key that is held as the comparator to state, thus they should be the same. | 
**Challenge** | **string** | Generated challenge from the code_verifier. | 
**Method** | **string** | Method used to generate the challenge. The PKCE spec defines two methods, S256 and plain, however, Auth0 supports only S256 since the latter is discouraged. | 
**Verifier** | **string** | Cryptographically random key that was used to generate the code_challenge passed to /authorize. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

