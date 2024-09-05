# Pieces.Os.Core.SdkModel.SeededAssetMetadata
This is optional metadata sent with the SeededAsset and other SeededAssets ie (UE, Jetbrains...)  Note: if a user/develop didnt explicitly state a mechanism we will default to manual(user Driven only)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Name** | **string** | This is the name of the asset. | [optional] 
**Mechanism** | **MechanismEnum** |  | [optional] 
**Tags** | [**List&lt;SeededAssetTag&gt;**](SeededAssetTag.md) | (optional) can add some tags to associate to this asset. | [optional] 
**Websites** | [**List&lt;SeededAssetWebsite&gt;**](SeededAssetWebsite.md) |  | [optional] 
**Sensitives** | [**List&lt;SeededAssetSensitive&gt;**](SeededAssetSensitive.md) |  | [optional] 
**Persons** | [**List&lt;SeededPerson&gt;**](SeededPerson.md) |  | [optional] 
**Annotations** | [**List&lt;SeededAnnotation&gt;**](SeededAnnotation.md) |  | [optional] 
**Hints** | [**List&lt;SeededHint&gt;**](SeededHint.md) |  | [optional] 
**Anchors** | [**List&lt;SeededAnchor&gt;**](SeededAnchor.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

