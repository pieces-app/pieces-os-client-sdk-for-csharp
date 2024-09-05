# Pieces.Os.Core.SdkModel.TransferableBytes
Bytes is a Model for A FileFormat. Raw and file are the only 2 that are currently supported. Raw and file are an array of integers that represent the file.Typical conversion UTF8 -> array[int] or UTF8 -> array[bytes(in hexidecimal)] -> array[int]. Either way you convert is up to you but the type we need here is an array of integers.  [NOT IMPLEMENTED] base64, base64_url, data_url [IMPLEMENTED] raw

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Raw** | **List&lt;int&gt;** | IMPLEMENTED | [optional] 
**Base64** | **List&lt;int&gt;** | NOT IMPLEMENTED | [optional] 
**Base64Url** | **List&lt;int&gt;** | NOT IMPLEMENTED | [optional] 
**DataUrl** | **List&lt;int&gt;** | NOT IMPLEMENTED | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

