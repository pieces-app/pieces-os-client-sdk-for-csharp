# Pieces.Os.Core.SdkModel.OSServerUpdateStatus
This is the model for the progress of the current update of Pieces os.  /os/update/check/stream && /os/update/check/  we will emit on a progress update  updated: is an optional property that will let us know when the update was checked last.  NOTE: it is reccommended to use the stream instead of pulling. NOTE: lets think about if we want to have a closing(as well as how we want to handle restarts)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Status** | **UpdatingStatusEnum** |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Percentage** | **decimal?** | Optionally if the update is in progress you will recieve a download percent(from 0-100). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

