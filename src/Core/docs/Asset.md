# Pieces.Os.Core.SdkModel.Asset
An Asset Model representing data extracted from an Application connecting a group of data containing one or more Formats.  Below formats, preview, and original CAN to be pollinated (DAG Unsafe) because it is a root node and it's child leaf nodes will prevent cycles agressively.

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
**Formats** | [**Formats**](Formats.md) |  | 
**Preview** | [**Preview**](Preview.md) |  | 
**Original** | [**ReferencedFormat**](ReferencedFormat.md) |  | 
**Shares** | [**Shares**](Shares.md) |  | [optional] 
**Mechanism** | **MechanismEnum** |  | 
**Websites** | [**Websites**](Websites.md) |  | [optional] 
**Interacted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Tags** | [**Tags**](Tags.md) |  | [optional] 
**Sensitives** | [**Sensitives**](Sensitives.md) |  | [optional] 
**Persons** | [**Persons**](Persons.md) |  | [optional] 
**Curated** | **bool** | This is an optional boolean that will flag that this asset came from a currated collection. | [optional] 
**Discovered** | **bool** |  | [optional] 
**Activities** | [**Activities**](Activities.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 
**Favorited** | **bool** |  | [optional] 
**Pseudo** | **bool** | This will determine if this is a asset that the user did not explicitly save. | [optional] 
**Annotations** | [**Annotations**](Annotations.md) |  | [optional] 
**Hints** | [**Hints**](Hints.md) |  | [optional] 
**Anchors** | [**Anchors**](Anchors.md) |  | [optional] 
**Conversations** | [**Conversations**](Conversations.md) |  | [optional] 
**Summaries** | [**WorkstreamSummaries**](WorkstreamSummaries.md) |  | [optional] 
**Demo** | **bool** | This will let us know if this asset was generated as a &#39;demo&#39; snippet | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

