# Pieces.Os.Core.SdkModel.TextuallyExtractedMaterial
This is an extraction, this was a person/website/anchor that was extracted  this will return the text location where this was found within the extraction.  as well return the material itself that was extracted.  Note: - seeds: will only be extracted people if provided, because the website/anchors will be created if extracted. - basically only thing that is different about the extracted people, if that if we extract a person that was not already saved,   then we will not save them, however if there are related people then we will add them as well.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Match** | [**TextLocation**](TextLocation.md) |  | 
**Websites** | [**FlattenedWebsites**](FlattenedWebsites.md) |  | [optional] 
**Anchors** | [**FlattenedAnchors**](FlattenedAnchors.md) |  | [optional] 
**Persons** | [**FlattenedPersons**](FlattenedPersons.md) |  | [optional] 
**Seeds** | [**Seeds**](Seeds.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

