# Pieces.Os.Core.SdkModel.ModelCapabilities
This will let us know what capabilities the model is aloud to be used for.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Temporal** | **bool** | True if model is able to support live context and any other temporally powered RAG Capabilities i.e. \&quot;What did I do yesterday?\&quot; | [optional] 
**Images** | **bool** | True if the model can leverage images and graphical material files in it&#39;s context window | [optional] 
**Videos** | **bool** | True if the model can leverage videos files in it&#39;s context window | [optional] 
**Documents** | **bool** | True if the model can leverage code/text/other files in it&#39;s context window | [optional] 
**Codebases** | **bool** | True if the model can leverage entire code bases/snippetized code bases in its context window | [optional] 
**Assets** | **bool** | True if the model can leverage saved assets &amp; their metadata in its context window. | [optional] 
**Websites** | **bool** | True if the model can leverage websites in its context window. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

