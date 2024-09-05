# Pieces.Os.Core.SdkModel.QGPTPersonsRelatedOutput
This model is used for the output of the /qgpt/related/persons endpoint.  Explanations here is a custom object with key value pairs, when the key is the personUUId and the value is an explanation as to why this person was reccommended.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Persons** | [**Persons**](Persons.md) |  | 
**Explanations** | **Dictionary&lt;string, string&gt;** | This is a Map&lt;String, String&gt; where the the key is a person id. and the value is the explanation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

