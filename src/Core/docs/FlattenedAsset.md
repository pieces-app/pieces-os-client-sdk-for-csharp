# Pieces.Os.Core.SdkModel.FlattenedAsset
An Asset Model representing data extracted from an Application connecting a group of data containing one or more Formats. [DAG Compatible - Directed Acyclic Graph Data Structure]  FlattenedAsset prevent Cycles in Reference because all outbound references are strings as opposed to crosspollinated objects.  i.e. FlattenedFormat.preview is Type String, and FlattenedFormat.original is Type String

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** | The globally available UID representing the asset in the Database, both locally and in the cloud. | 
**Name** | **string** |  | [optional] 
**Creator** | **string** |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Synced** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Formats** | [**FlattenedFormats**](FlattenedFormats.md) |  | 
**Preview** | [**FlattenedPreview**](FlattenedPreview.md) |  | 
**Original** | **string** | An identifier of the format that is a reference to the original. | 
**Shares** | [**FlattenedShares**](FlattenedShares.md) |  | [optional] 
**Mechanism** | **MechanismEnum** |  | 
**Websites** | [**FlattenedWebsites**](FlattenedWebsites.md) |  | [optional] 
**Interacted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Tags** | [**FlattenedTags**](FlattenedTags.md) |  | [optional] 
**Sensitives** | [**FlattenedSensitives**](FlattenedSensitives.md) |  | [optional] 
**Persons** | [**FlattenedPersons**](FlattenedPersons.md) |  | [optional] 
**Curated** | **bool** | This is an optional boolean that will flag that this asset came from a currated collection. | [optional] 
**Discovered** | **bool** |  | [optional] 
**Activities** | [**FlattenedActivities**](FlattenedActivities.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 
**Favorited** | **bool** |  | [optional] 
**Pseudo** | **bool** |  | [optional] 
**Annotations** | [**FlattenedAnnotations**](FlattenedAnnotations.md) |  | [optional] 
**Hints** | [**FlattenedHints**](FlattenedHints.md) |  | [optional] 
**Anchors** | [**FlattenedAnchors**](FlattenedAnchors.md) |  | [optional] 
**Conversations** | [**FlattenedConversations**](FlattenedConversations.md) |  | [optional] 
**Demo** | **bool** | This will let us know if this asset was generated as a &#39;demo&#39; snippet | [optional] 
**Summaries** | [**FlattenedWorkstreamSummaries**](FlattenedWorkstreamSummaries.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

