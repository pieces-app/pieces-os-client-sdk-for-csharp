# Pieces.Os.Core.SdkModel.FlattenedConversation
This is a flattened version of the Convsersation for DAG-Safety.  This will hold together a conversation. Ie all the message within a conversation.  All the additional properties on here used on here like(anchors/assets) are used for context that will seed the conversation.  model is a calculated property, and will be the model of the last message sent if applicable.  summaries: on the top level here will simply be used to associate a conversation and a summary(this is not used for grounding), grounding.summaries will be used for this.(TODO)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Name** | **string** | This is a name that is customized. | [optional] 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Favorited** | **bool** |  | [optional] 
**Application** | [**Application**](Application.md) |  | [optional] 
**Annotations** | [**FlattenedAnnotations**](FlattenedAnnotations.md) |  | [optional] 
**Messages** | [**FlattenedConversationMessages**](FlattenedConversationMessages.md) |  | 
**Model** | [**ReferencedModel**](ReferencedModel.md) |  | [optional] 
**Assets** | [**FlattenedAssets**](FlattenedAssets.md) |  | [optional] 
**Websites** | [**FlattenedWebsites**](FlattenedWebsites.md) |  | [optional] 
**Anchors** | [**FlattenedAnchors**](FlattenedAnchors.md) |  | [optional] 
**Type** | **ConversationTypeEnum** |  | 
**Grounding** | [**ConversationGrounding**](ConversationGrounding.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 
**Pipeline** | [**QGPTPromptPipeline**](QGPTPromptPipeline.md) |  | [optional] 
**Demo** | **bool** | This will let us know if this conversation was generated as a &#39;demo&#39; conversation | [optional] 
**Summaries** | [**FlattenedWorkstreamSummaries**](FlattenedWorkstreamSummaries.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

