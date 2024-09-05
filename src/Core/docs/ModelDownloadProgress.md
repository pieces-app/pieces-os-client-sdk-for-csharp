# Pieces.Os.Core.SdkModel.ModelDownloadProgress
This is the model that is sent over our ws for streaming the progress of a model that is being downloaded.  can eventually add a number that display the percent downloaded an so on.(this is called percent 0-100)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Status** | **ModelDownloadProgressStatusEnum** |  | [optional] 
**Percentage** | **decimal?** | Optionally if the download is in progress you will recieve a download percent(from 0-100). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

