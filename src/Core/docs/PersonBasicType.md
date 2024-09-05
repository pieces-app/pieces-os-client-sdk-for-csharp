# Pieces.Os.Core.SdkModel.PersonBasicType
This is all optional properties around the most basic information around a non-pieces user.  A Basic type will NOT have a scope as it is not an actual pieces user.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Username** | **string** | username or twitter handle...etc | [optional] 
**Name** | **string** | This is the name of the basic user. | [optional] 
**Picture** | **string** | this is a url picture representation of a user. | [optional] 
**Email** | **string** | an email that was extracted. | [optional] 
**Sourced** | **ExternallySourcedEnum** |  | [optional] 
**Url** | **string** | This is a specific url that this basic user came from. | [optional] 
**Mailgun** | [**MailgunMetadata**](MailgunMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

