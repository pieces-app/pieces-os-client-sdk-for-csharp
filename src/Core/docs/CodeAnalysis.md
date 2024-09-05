# Pieces.Os.Core.SdkModel.CodeAnalysis
This is the ML Analysis object Specific to code.  prediction and similarity are custom types. ** please dont not modify **

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Tokenized** | **List&lt;string&gt;** |  | [optional] 
**Language** | **string** |  | [optional] 
**Type** | **ClassificationGenericEnum** |  | 
**Prediction** | **Dictionary&lt;string, decimal&gt;** |  | [optional] 
**Similarity** | **Dictionary&lt;string, decimal&gt;** |  | [optional] 
**Top5Colors** | **List&lt;int&gt;** |  | [optional] 
**Top5Sorted** | **List&lt;string&gt;** |  | [optional] 
**Id** | **string** |  | 
**Analysis** | **string** | this is just a reference to the analysis parent object. | 
**Model** | [**Model**](Model.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

