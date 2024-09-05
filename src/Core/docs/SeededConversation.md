# Pieces.Os.Core.SdkModel.SeededConversation
This is a pre-Conversation object.  This will hold together a conversation. Ie allthe message within a conversation.  All the additional properties on here used on here like(anchors/assets) are used for context that will seed the conversation.  model is a calculated property, and will be the model of the last message sent if applicable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Name** | **string** | This is a name that is customized. | [optional] 
**Favorited** | **bool** |  | [optional] 
**Application** | [**Application**](Application.md) |  | [optional] 
**Annotations** | [**List&lt;SeededAnnotation&gt;**](SeededAnnotation.md) |  | [optional] 
**Messages** | [**List&lt;SeededConversationMessage&gt;**](SeededConversationMessage.md) |  | [optional] 
**Model** | [**ReferencedModel**](ReferencedModel.md) |  | [optional] 
**Assets** | [**FlattenedAssets**](FlattenedAssets.md) |  | [optional] 
**Websites** | [**FlattenedWebsites**](FlattenedWebsites.md) |  | [optional] 
**Anchors** | [**List&lt;SeededAnchor&gt;**](SeededAnchor.md) |  | [optional] 
**Type** | **ConversationTypeEnum** |  | 
**Pipeline** | [**QGPTPromptPipeline**](QGPTPromptPipeline.md) |  | [optional] 
**Demo** | **bool** | This will let us know if this conversation was generated as a &#39;demo&#39; conversation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

