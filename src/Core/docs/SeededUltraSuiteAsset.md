# Pieces.Os.Core.SdkModel.SeededUltraSuiteAsset
A SeededUEAsset is the minimum data sent from UE required to create an asset within Pieces.  Fragment & file are both optional properties however we will throw an internal error if both fragment and file are passed through or if both are undefined.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Name** | **string** | (optional) name is the name of the file | [optional] 
**Ext** | **ClassificationSpecificEnum** |  | [optional] 
**Format** | [**SeededFormat**](SeededFormat.md) |  | 
**Description** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

