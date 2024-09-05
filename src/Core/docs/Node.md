# Pieces.Os.Core.SdkModel.Node
This describes a node within a relationship graph used to related like types. ie asset to asset, tag to tag, ...etc  created: is here to let us know when the node was attached.  id: this is the the id of the type ie, if the type is Asset the id here points to the asset that this node represents.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Type** | **NodeTypeEnum** |  | 
**Root** | **bool** | This is a boolean to let us know if this node is the root or origin of the relationship graph. | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

