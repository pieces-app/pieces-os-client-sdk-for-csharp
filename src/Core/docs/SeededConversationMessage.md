# Pieces.Os.Core.SdkModel.SeededConversationMessage
This is a seeded version of a ConversationMessage.  conversation is optional, this is because it can be used within the SeededConversation, however if this is passed into the /messages/create w/o a conversation uuid then we will throw an error.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Model** | [**Model**](Model.md) |  | [optional] 
**Fragment** | [**FragmentFormat**](FragmentFormat.md) |  | 
**Conversation** | [**ReferencedConversation**](ReferencedConversation.md) |  | [optional] 
**Sentiment** | **ConversationMessageSentimentEnum** |  | [optional] 
**Role** | **QGPTConversationMessageRoleEnum** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

