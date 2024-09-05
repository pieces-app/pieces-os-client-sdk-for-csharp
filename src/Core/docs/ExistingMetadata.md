# Pieces.Os.Core.SdkModel.ExistingMetadata
This is a shared input model for all the exists endpoints: /tags/exists : if the tag exists you will have a defined tag:ReferencedTag, if not then it doesnt exist. /websites/exists: if the url exists you will have a defined website:ReferencedWebsite, if not then it doesnt exist.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Website** | [**ReferencedWebsite**](ReferencedWebsite.md) |  | [optional] 
**Tag** | [**ReferencedTag**](ReferencedTag.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

