# Pieces.Os.Core.SdkModel.TrackedAssetEventIdentifierDescriptionPairs
These are all of the available event types that are permitted in an object pair notation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**AssetCreated** | **string** | The key value pair for an asset being created. | [optional] 
**AssetViewed** | **string** | An asset was viewed | [optional] 
**AssetFormatCopied** | **string** | An asset&#39;s format was copied | [optional] 
**AssetFormatDownloaded** | **string** | An asset&#39;s format was downloaded | [optional] 
**AssetDeleted** | **string** | An asset was deleted or not | [optional] 
**AssetDescriptionUpdated** | **string** | An asset was redescribed by the user | [optional] 
**AssetNameUpdated** | **string** | An asset was renamed by the user | [optional] 
**AssetFormatGenericClassificationUpdated** | **string** | A generic classification was changed on a format within an asset | [optional] 
**AssetFormatSpecificClassificationUpdated** | **string** | A specific classification was changed on a format within an asset | [optional] 
**AssetCreationFailed** | **string** |  | [optional] 
**AssetTagAdded** | **string** |  | [optional] 
**AssetLinkAdded** | **string** |  | [optional] 
**AssetLinkGenerated** | **string** | user generated a link for the asset | [optional] 
**AssetLinkDeleted** | **string** |  | [optional] 
**AssetTagDeleted** | **string** |  | [optional] 
**AssetUpdated** | **string** | This is just a generic string for an asset was updated. | [optional] 
**AssetFormatValueEdited** | **string** | This is a side effect event for a format value getting edited that exists on an asset. | [optional] 
**AssetFormatUpdated** | **string** | This is a generic activity event for an asset getting updated because our format was updated for some reason. | [optional] 
**AssetLinkRevoked** | **string** | This means that a shareable link was revoked. | [optional] 
**AssetPersonAdded** | **string** | This just means that a person was added via the user. | [optional] 
**AssetPersonDeleted** | **string** | This just means that a person was deleted via the user. | [optional] 
**AssetSensitiveAdded** | **string** | This just means that a sensitive was added via the user. | [optional] 
**AssetSensitiveDeleted** | **string** | This just means that a sensitive was deleted via the user. | [optional] 
**SuggestedAssetReferenced** | **string** | This means that an asset was view/used while the user was looking at the suggestion view. | [optional] 
**SearchedAssetReferenced** | **string** | This means that an asset was view/used while the user was looking at the searching view. | [optional] 
**AssetReferenced** | **string** | This means that an asset was view/used while the user was looking at the default view. | [optional] 
**ActivityAssetReferenced** | **string** | This means that a user referenced an asset by first clicking on an asset within an activity event.(ie from the activity view) | [optional] 
**AssetAnnotationAdded** | **string** |  | [optional] 
**AssetAnnotationDeleted** | **string** |  | [optional] 
**AssetAnnotationUpdated** | **string** |  | [optional] 
**AssetHintAdded** | **string** |  | [optional] 
**AssetHintDeleted** | **string** |  | [optional] 
**AssetHintUpdated** | **string** |  | [optional] 
**AssetAnchorAdded** | **string** |  | [optional] 
**AssetAnchorDeleted** | **string** |  | [optional] 
**AssetAnchorUpdated** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

