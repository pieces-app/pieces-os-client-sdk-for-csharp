# Pieces.Os.Core.SdkModel.LinkifyMultiple
This is the incoming linkify model.  if access is PRIVATE then please provide and array of users to enable the link for.  Assumption, all assets are already backed up to the cloud. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Assets** | **List&lt;string&gt;** | This is an array or string that represents an already backed up asset. That will be added to a collection. | 
**Users** | [**List&lt;SeededUser&gt;**](SeededUser.md) | this is an array of users. | [optional] 
**Access** | **AccessEnum** |  | 
**Name** | **string** | optionally can give the collection a name if you want. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

