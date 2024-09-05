# Pieces.Os.Core.SdkModel.TrackedSessionEventIdentifierDescriptionPairs
These are all of the available event types that are permitted in an object pair notation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**SessionInitialized** | **string** | The key value pair for an application being opened. | [optional] 
**SessionLocalConnectionSucceeded** | **string** | There was a successful connection locally | [optional] 
**SessionLocalConnectionFailed** | **string** | There was a failed connection locally | [optional] 
**SessionInactive** | **string** | If the current application is in the background or not, could also be minimized. | [optional] 
**SessionActive** | **string** | If the application has been brought to the forground. | [optional] 
**SessionTerminated** | **string** | If the user has closed the application, thus ending the session. | [optional] 
**SessionAuthenticatedWithSignIn** | **string** | A user has signed into this session with a an external account | [optional] 
**SessionUnauthenticatedWithSignOut** | **string** | A user has signed out of this session | [optional] 
**SessionUnauthenticatedWithDismiss** | **string** | A user did not sign into the session with a dismissal | [optional] 
**SessionUnauthenticatedWithRemind** | **string** | A user did not sign into the session with a reminder | [optional] 
**SessionOnboardingInitialized** | **string** | Onboarding has been initialized for this session | [optional] 
**SessionOnboardingCompleted** | **string** | Onboarding has been completed for this session | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

