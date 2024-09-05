# Pieces.Os.Core.SdkModel.SeededPerson
This is a per-cursor to a full person.  Will throw an error, if asset is passed in but acces.scope is undefined.  can optionally pass in our mechanism here, as the default will be manual unless specified.  TODO consider updating these asset, format to referenced Models  Note: model, access, mechanism will only be added if the asset is passed in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Asset** | **string** |  | [optional] 
**Mechanism** | **MechanismEnum** |  | [optional] 
**Access** | [**PersonAccess**](PersonAccess.md) |  | [optional] 
**Type** | [**PersonType**](PersonType.md) |  | 
**Model** | [**PersonModel**](PersonModel.md) |  | [optional] 
**Annotations** | [**List&lt;SeededAnnotation&gt;**](SeededAnnotation.md) |  | [optional] 
**Anchors** | [**FlattenedAnchors**](FlattenedAnchors.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

