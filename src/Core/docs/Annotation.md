# Pieces.Os.Core.SdkModel.Annotation
An Annotation is the replacement for descriptions, this will enable comments, description, summaries and many more.  person on here is a reference to the description/comment/annotation about a person  NOTE: person here is NOT the creator of the annotaion. but rather the descriptions of the person. NOTE****: if we want to add \"who\" wrote the annotation, we will want to add a new field on here called author && will need to also layer in behavior the enable an author(person) and an asset both being referenced(ensure you check the side effect in the AssetsFacade.delete)

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

