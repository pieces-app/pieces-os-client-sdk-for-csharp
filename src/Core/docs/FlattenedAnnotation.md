# Pieces.Os.Core.SdkModel.FlattenedAnnotation
This is the flattened Version of the annotation, IMPORTANT: when referencing these, ONLY Take the UUID, do NOT polinate(ie w/ asset/person/model) the FlattenedAnnotation as it can create an infinite loop.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Mechanism** | **MechanismEnum** |  | [optional] 
**Asset** | [**ReferencedAsset**](ReferencedAsset.md) |  | [optional] 
**Person** | [**ReferencedPerson**](ReferencedPerson.md) |  | [optional] 
**Type** | **AnnotationTypeEnum** |  | 
**Text** | **string** | This is the text of the annotation. | 
**Model** | [**ReferencedModel**](ReferencedModel.md) |  | [optional] 
**Pseudo** | **bool** |  | [optional] 
**Favorited** | **bool** |  | [optional] 
**Anchor** | [**ReferencedAnchor**](ReferencedAnchor.md) |  | [optional] 
**Conversation** | [**ReferencedConversation**](ReferencedConversation.md) |  | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 
**Messages** | [**FlattenedConversationMessages**](FlattenedConversationMessages.md) |  | [optional] 
**Summary** | [**ReferencedWorkstreamSummary**](ReferencedWorkstreamSummary.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

