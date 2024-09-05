# Pieces.Os.Core.SdkModel.FlattenedConversationMessage
This is a flattened DAG safe version of a ConversationMessage.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Model** | [**Model**](Model.md) |  | [optional] 
**Fragment** | [**FragmentFormat**](FragmentFormat.md) |  | [optional] 
**Conversation** | [**ReferencedConversation**](ReferencedConversation.md) |  | 
**Sentiment** | **ConversationMessageSentimentEnum** |  | [optional] 
**Role** | **QGPTConversationMessageRoleEnum** |  | 
**Score** | [**Score**](Score.md) |  | [optional] 
**Annotations** | [**FlattenedAnnotations**](FlattenedAnnotations.md) |  | [optional] 
**Anchors** | [**FlattenedAnchors**](FlattenedAnchors.md) |  | [optional] 
**Persons** | [**FlattenedPersons**](FlattenedPersons.md) |  | [optional] 
**Websites** | [**FlattenedWebsites**](FlattenedWebsites.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

