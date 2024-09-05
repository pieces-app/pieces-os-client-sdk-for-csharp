# Pieces.Os.Core.SdkModel.AllocationCloud
update && version: will be present only if your cloud was successfully spun up && running.  updated: is the last time this was updated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** | This is a uuid that represents this cloud.(this is the same as the userid) | 
**User** | **string** | this is your useruuid. | 
**Urls** | [**AllocationCloudUrls**](AllocationCloudUrls.md) |  | 
**Status** | [**AllocationCloudStatus**](AllocationCloudStatus.md) |  | 
**Project** | **string** | This is the project that this is attached to. | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**VarVersion** | **string** | this is the current version of the server. | [optional] 
**Region** | **string** | this is the region where the project is defined. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

