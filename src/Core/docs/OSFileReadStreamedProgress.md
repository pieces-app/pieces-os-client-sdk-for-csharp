# Pieces.Os.Core.SdkModel.OSFileReadStreamedProgress
This is a model to return stream progress for a file read.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Status** | **ModelDownloadProgressStatusEnum** |  | 
**Percentage** | **decimal?** | Optionally if the download is in progress you will receive a download percent(from 0-100). | [optional] 
**Path** | **string** |  | 
**Id** | **string** | This is a generated UUID that represents this current stream in progress(can be used to cancel this in the future) | 
**Bytes** | [**TransferableBytes**](TransferableBytes.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

