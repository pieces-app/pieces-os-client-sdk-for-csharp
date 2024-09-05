# Pieces.Os.Core.SdkModel.SeededModel
This is Precursor to a Model.  bytes: here is the size of the model in a file local on your computer. ram: is the amount of ram usage when the model is loaded into memory.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**VarVersion** | **string** | this is a version of the model. | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Name** | **string** | This is an Optional Name of the Model. | 
**Description** | **string** | An Optional Description of the model itself. | [optional] 
**Cloud** | **bool** | This will inform the user if this was a model that is hosted in the cloud | 
**Type** | **ModelTypeEnum** |  | 
**Usage** | **ModelUsageEnum** |  | 
**Bytes** | [**ByteDescriptor**](ByteDescriptor.md) |  | [optional] 
**Ram** | [**ByteDescriptor**](ByteDescriptor.md) |  | [optional] 
**Quantization** | **string** | quantization is a string like: q8f16_0,  q4f16_1, etc... | [optional] 
**Foundation** | **ModelFoundationEnum** |  | [optional] 
**Downloaded** | **bool** | This is an optional bool to let us know if this model has been downloaded locally. | [optional] 
**Unique** | **string** | This is the unique model name used to load the model. | [optional] 
**Parameters** | **decimal?** | This is the number of parameters in terms of billions. | [optional] 
**Provider** | **ExternalMLProviderEnum** |  | [optional] 
**Cpu** | **bool** | This is an optional bool that is optimized for CPU usage. | [optional] 
**MaxTokens** | [**ModelMaxTokens**](ModelMaxTokens.md) |  | [optional] 
**Custom** | **bool** | This is reserved to customly register models. | [optional] 
**Capabilities** | [**ModelCapabilities**](ModelCapabilities.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

