# Pieces.Os.Core.SdkModel.FlattenedWebsite
This is a specific model for related websites to an asset.[DAG SAFE]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** | this is aspecific uuid that represents | 
**Assets** | [**FlattenedAssets**](FlattenedAssets.md) |  | [optional] 
**Name** | **string** | A customizable name. | 
**Url** | **string** | The true url or the website. | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Mechanisms** | [**Dictionary&lt;string, MechanismEnum&gt;**](MechanismEnum.md) | This is a Map&lt;String, MechanismEnum&gt; where the the key is an asset id. | [optional] 
**Interactions** | **int** | This is an optional value that will keep track of the number of times this has been interacted with. | [optional] 
**Persons** | [**FlattenedPersons**](FlattenedPersons.md) |  | [optional] 
**Conversations** | [**FlattenedConversations**](FlattenedConversations.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 
**Summaries** | [**FlattenedWorkstreamSummaries**](FlattenedWorkstreamSummaries.md) |  | [optional] 
**Messages** | [**FlattenedConversationMessages**](FlattenedConversationMessages.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

