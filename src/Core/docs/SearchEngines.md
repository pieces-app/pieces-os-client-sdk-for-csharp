# Pieces.Os.Core.SdkModel.SearchEngines
This is a model for plural Engine. This means that you can run multiple searches, this follow similar behavior to the Asset Filtering.where you can create you own complex operations: IE search a query in FTS, and filter all that have the create from here to here.  note: each Engine will only represent 1 search operation, however you many pass in operations to create further nesting. IE  Engine: [FTS + w/ operations: [created filter, updated filer, ncs Search] w/ a type of OR:::: This can be as nested as you want however will just increase the time till it returns results.]  note: type: default behavior for the type is an AND operation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Iterable** | [**List&lt;SearchEngine&gt;**](SearchEngine.md) |  | 
**Type** | **FilterOperationTypeEnum** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

