# Pieces.Os.Core.SdkModel.ConversationMessage
This is a fully referenced ConversationMessage.  This has the minimum amount of properties to keep this light weight  (will consider additional properties in the future like people/tags/links xyz)

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
**Websites** | [**FlattenedWebsites**](FlattenedWebsites.md) |  | [optional] 
**Persons** | [**FlattenedPersons**](FlattenedPersons.md) |  | [optional] 
**Anchors** | [**FlattenedAnchors**](FlattenedAnchors.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

