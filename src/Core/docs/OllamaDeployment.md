# Pieces.Os.Core.SdkModel.OllamaDeployment
A deployment will be used in 4 cases: 1. used to describe an installation in progress 2. used to describe an update in progress 3. used to say what deployment will be needed to upgrade to. 4. used to say what the current version of ollama is present on the machine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | [optional] 
**Status** | **OllamaDeploymentStatusEnum** |  | [optional] 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Percentage** | **decimal?** | Optionally if the update is in progress you will recieve a download percent(from 0-100). | [optional] 
**VarVersion** | **string** |  | 
**UserManaged** | **bool** | Optionally set, specifically in the case where an update is required, and a user need to take manual action. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

