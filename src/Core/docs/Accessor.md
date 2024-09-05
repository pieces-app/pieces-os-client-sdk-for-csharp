# Pieces.Os.Core.SdkModel.Accessor
This is used to determine who has accessed a share. and how many times.  The user here is the user that accessed this Piece.(optional) if undefined then this user was not logged in yet.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Os** | **string** | this is an os id. | 
**Share** | **string** |  | 
**Count** | **int** | how many times this user accessed this piece. | 
**User** | [**FlattenedUserProfile**](FlattenedUserProfile.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

