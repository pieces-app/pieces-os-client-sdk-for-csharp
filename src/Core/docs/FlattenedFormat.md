# Pieces.Os.Core.SdkModel.FlattenedFormat
A representation of Data for a particular Form Factor of an Asset.[DAG Compatible - Directed Acyclic Graph Data Structure]  FlattenedFormats prevent Cycles in Reference because all outbound references are strings as opposed to crosspollinated objects.  i.e. FlattenedFormat.asset is Type String  fragment or file will always be defined. Even thought they are both optional.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Creator** | **string** |  | 
**Classification** | [**Classification**](Classification.md) |  | 
**Icon** | **string** |  | [optional] 
**Role** | **Role** |  | 
**Application** | [**Application**](Application.md) |  | 
**Asset** | **Guid** | A uuid model. 36 Characters (4 Dashes, 32 Numbers/Letters)  | 
**Bytes** | [**ByteDescriptor**](ByteDescriptor.md) |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Synced** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Cloud** | **string** | This is a path used to determine what path this format lives at within the cloud. | [optional] 
**Fragment** | [**FragmentFormat**](FragmentFormat.md) |  | [optional] 
**File** | [**FileFormat**](FileFormat.md) |  | [optional] 
**Analysis** | [**FlattenedAnalysis**](FlattenedAnalysis.md) |  | [optional] 
**Relationship** | [**Relationship**](Relationship.md) |  | [optional] 
**Activities** | [**FlattenedActivities**](FlattenedActivities.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

