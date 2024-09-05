# Pieces.Os.Core.SdkModel.SearchedConversationMessage
This is used for the ConversationMessages searching endpoint && the specific Conversation search && ConversationsSearch  conversation here is only provided if transferables are set to true.  temporal: if this is provided this means that their material matched the input via a timestamp.  TODO will want to consider returning related materials to this material potentially both associated/ and not associated materials ie suggestion: WorkstreamSuggestions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Message** | [**ConversationMessage**](ConversationMessage.md) |  | [optional] 
**Exact** | **bool** |  | 
**Similarity** | **decimal** |  | 
**Temporal** | **bool** |  | [optional] 
**Identifier** | **string** | This is the uuid of the ConversationMessage. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

