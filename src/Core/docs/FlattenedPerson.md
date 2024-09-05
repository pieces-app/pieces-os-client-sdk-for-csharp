# Pieces.Os.Core.SdkModel.FlattenedPerson
if expiration is add then, after the alloted expiration date the user will only have view && comment only permissions. Only present in the case there is a scope such as a defined collection/asset...  if asset is passed then that means this person belongs to a scoped asset.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Type** | [**PersonType**](PersonType.md) |  | 
**Assets** | [**FlattenedAssets**](FlattenedAssets.md) |  | [optional] 
**Mechanisms** | [**Dictionary&lt;string, MechanismEnum&gt;**](MechanismEnum.md) | This is a Map&lt;String, MechanismEnum&gt; where the the key is an asset id. | [optional] 
**Interactions** | **int** | This is an optional value that will keep track of the number of times this has been interacted with. | [optional] 
**Access** | [**Dictionary&lt;string, PersonAccess&gt;**](PersonAccess.md) | This is a Map&lt;String, PersonAccess&gt; where the the key is an asset id. | [optional] 
**Tags** | [**FlattenedTags**](FlattenedTags.md) |  | [optional] 
**Websites** | [**FlattenedWebsites**](FlattenedWebsites.md) |  | [optional] 
**Models** | [**Dictionary&lt;string, PersonModel&gt;**](PersonModel.md) | This is a Map&lt;String, PersonModel&gt;, where the the key is an asset id. | [optional] 
**Annotations** | [**FlattenedAnnotations**](FlattenedAnnotations.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 
**Summaries** | [**FlattenedWorkstreamSummaries**](FlattenedWorkstreamSummaries.md) |  | [optional] 
**Anchors** | [**FlattenedAnchors**](FlattenedAnchors.md) |  | [optional] 
**Messages** | [**FlattenedConversationMessages**](FlattenedConversationMessages.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

