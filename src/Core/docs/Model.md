# Pieces.Os.Core.SdkModel.Model
This is a Machine Learning Model, that will give readable information about the Machine Learning Model Used.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** | uuid  | 
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
**Loaded** | **bool** | This is a boolean that represents if the model is loaded into memory.(this is not persisted, and is calculated on the fly.) | [optional] 
**Unique** | **string** | This is the unique model name used to load the model. | [optional] 
**Parameters** | **decimal?** | This is the number of parameters in terms of billions. | [optional] 
**Provider** | **ExternalMLProviderEnum** |  | [optional] 
**Cpu** | **bool** | This is an optional bool that is optimized for CPU usage. | [optional] 
**Downloading** | **bool** | This is a calculated property, that will say if this is currently downloading. | [optional] 
**MaxTokens** | [**ModelMaxTokens**](ModelMaxTokens.md) |  | [optional] 
**Custom** | **bool** | This will let us know if this is a custom, or fine tuned model imported by the user. | [optional] 
**Capabilities** | [**ModelCapabilities**](ModelCapabilities.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

