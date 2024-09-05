# Pieces.Os.Core.SdkModel.SeededRange
This is a preIdentified version of a Range.  conversation: this is here to specify the relationship that we want to set up with the Range.  IE for this case we want to associate a Range with a Conversation.grounding.temporal.workstream. Otherwise, if this was a conversation we would have no way to know what relationship that we want to set up on the conversation w/ the range. (because this will be set up for many relationShip opportunities that have different functionalities)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**To** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**From** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Between** | **bool** |  | [optional] 
**Summary** | [**ReferencedWorkstreamSummary**](ReferencedWorkstreamSummary.md) |  | [optional] 
**Conversation** | [**SeededRangeConversationAssociation**](SeededRangeConversationAssociation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

