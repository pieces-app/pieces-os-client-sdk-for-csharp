# Pieces.Os.Core.SdkModel.DiscoveredAssets
This is a plural Model that is used within the bulk upload flow in both cases of a file(&& needing snippitization) as well as if the fragments are passed in and they only need to be clustered.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Application** | **string** | application id. | 
**Iterable** | [**List&lt;DiscoveredAsset&gt;**](DiscoveredAsset.md) | This is an iterable of already snippitized snippets that have been clustered.(These are assets that are going to be uploaded or at minimum the assets that we reccommend to upload) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

