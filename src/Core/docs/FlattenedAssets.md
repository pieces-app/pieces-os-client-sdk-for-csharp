# Pieces.Os.Core.SdkModel.FlattenedAssets
A collection of Assets specific to the authenticated user. [DAG Compatible - Directed Acyclic Graph Data Structure]  FlattenedAssets prevent Cycles in Reference because all outbound references are strings as opposed to crosspollinated objects.  i.e. Asset asset = FlattenedAssets.iterable[0] => Format format = asset.preview => String id = format.asset => String id

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Iterable** | [**List&lt;ReferencedAsset&gt;**](ReferencedAsset.md) |  | [optional] 
**Indices** | **Dictionary&lt;string, int&gt;** | This is a Map&lt;String, int&gt; where the the key is an asset id. | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

