# Pieces.Os.Core.SdkModel.BackupStreamedProgress
This is a specific model to the /backups/create/streamed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Status** | **ModelDownloadProgressStatusEnum** |  | [optional] 
**Percentage** | **decimal?** | Optionally if the download is in progress you will recieve a download percent(from 0-100). | [optional] 
**Backup** | [**Backup**](Backup.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

