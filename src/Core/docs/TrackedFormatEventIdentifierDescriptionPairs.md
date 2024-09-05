# Pieces.Os.Core.SdkModel.TrackedFormatEventIdentifierDescriptionPairs
This is a model that allows us to send send over super specific format related events such as copied, deleted, downloaded, etc

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**FormatCreated** | **string** | The key value pair for an asset being created. | [optional] 
**FormatCopied** | **string** | If a format was copied entirely | [optional] 
**FormatPartiallyCopied** | **string** | If a format was copied partially | [optional] 
**FormatDownloaded** | **string** | If a format was downloaded | [optional] 
**FormatDeleted** | **string** | If an format was deleted | [optional] 
**FormatGenericClassificationUpdated** | **string** | If a generic classification was changed on a format | [optional] 
**FormatSpecificClassificationUpdated** | **string** | If a specific classification was changed on a format | [optional] 
**FormatUpdated** | **string** | a format was updated, generic update. | [optional] 
**FormatInserted** | **string** | a format was inserted | [optional] 
**FormatValueEdited** | **string** | a format&#39;s value was update ie, the text, etc... | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

