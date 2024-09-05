# Pieces.Os.Core.SdkModel.Format
A representation of Data for a particular Form Factor of an Asset.  Below asset HAS to be Flattened because it is a leaf node and must prevent cycles agressively.

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
**Asset** | [**FlattenedAsset**](FlattenedAsset.md) |  | 
**Bytes** | [**ByteDescriptor**](ByteDescriptor.md) |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Synced** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Cloud** | **string** | This is a path used to determine what path this format lives at within the cloud. | [optional] 
**Fragment** | [**FragmentFormat**](FragmentFormat.md) |  | [optional] 
**File** | [**FileFormat**](FileFormat.md) |  | [optional] 
**Analysis** | [**Analysis**](Analysis.md) |  | [optional] 
**Relationship** | [**Relationship**](Relationship.md) |  | [optional] 
**Activities** | [**Activities**](Activities.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

