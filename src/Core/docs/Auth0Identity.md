# Pieces.Os.Core.SdkModel.Auth0Identity
Contains info retrieved from the identity provider with which the user originally authenticates. Users may also link their profile to multiple identity providers; those identities will then also appear in this array. The contents of an individual identity provider object varies by provider, but it will typically include the following. Link: [https://auth0.com/docs/rules/user-object-in-rules]  Currently left out: - profile_data: (Object) User information associated with the connection. When profiles are linked, it is populated with the associated user info for secondary accounts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Connection** | **string** | Name of the Auth0 connection used to authenticate the user.  | [optional] 
**IsSocial** | **bool** | Indicates whether the connection is a social one.  | [optional] 
**Provider** | **string** | mapped from user_id  -&gt; id | [optional] 
**UserId** | **string** | User&#39;s unique identifier for this connection/provider. | [optional] 
**AccessToken** | **string** |  | [optional] 
**ExpiresIn** | **int** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

