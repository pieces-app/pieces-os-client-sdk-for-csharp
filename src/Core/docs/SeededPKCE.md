# Pieces.Os.Core.SdkModel.SeededPKCE
A model that initialized a PKCE Authentication Flow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**ResponseType** | **string** | Indicates to Auth0 which OAuth 2.0 Flow you want to perform. Use code for Authorization Code Grant (PKCE) Flow. | 
**State** | **Guid** | An opaque value the clients adds to the initial request that Auth0 includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks. | 
**Nonce** | **Guid** | A local key that is held as the comparator to state, thus they should be the same. | 
**RedirectUri** | **string** | http://localhost:8080/authentication/response | [optional] 
**CodeChallenge** | **string** | Generated challenge from the code_verifier. | 
**CodeChallengeMethod** | **string** | Method used to generate the challenge. The PKCE spec defines two methods, S256 and plain, however, Auth0 supports only S256 since the latter is discouraged. | 
**Domain** | **string** | https://auth.pieces.services/authorize | [optional] 
**Audience** | **string** | The unique identifier of the target API you want to access. i.e. https://pieces.us.auth0.com/api/v2/ | [optional] 
**ScreenHint** | **string** | Provides a hint to Auth0 as to what flow should be displayed. The default behavior is to show a login page but you can override this by passing &#39;signup&#39; to show the signup page instead. | [optional] 
**Prompt** | **string** |  To initiate a silent authentication request, use prompt&#x3D;none (see Remarks for more info). | [optional] 
**Organization** | **string** |  | [optional] 
**Invitation** | **string** |  | [optional] 
**Scope** | **List&lt;SeededPKCE.ScopeEnum&gt;** | The scopes which you want to request authorization for. These must be separated by a space. You can request any of the standard OpenID Connect (OIDC) scopes about users, such as profile and email, custom claims that must conform to a namespaced format, or any scopes supported by the target API (for example, read:contacts). Include offline_access to get a Refresh Token. | 
**ClientId** | **string** | Your application&#39;s Client ID. | 
**ADDITIONAL_PARAMETERS** | [**SeededPKCEADDITIONALPARAMETERS**](SeededPKCEADDITIONALPARAMETERS.md) |  | [optional] 
**ResponseMode** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

