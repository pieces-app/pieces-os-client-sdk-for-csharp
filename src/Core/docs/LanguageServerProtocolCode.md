# Pieces.Os.Core.SdkModel.LanguageServerProtocolCode
NOTE: this can me a union type here.. (integer | string;) so we need to get a bit creative

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**CodeInteger** | **int** |  | [optional] 
**CodeString** | **string** |  | [optional] 
**RawJson** | **Dictionary&lt;string, string&gt;** | This is a Map&lt;String, String&gt;, basically just a json object for additional data if int/string will not work | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

