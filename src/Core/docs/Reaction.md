# Pieces.Os.Core.SdkModel.Reaction
This will the the Request body of the Request Endpoint.  Reuse will not be required here because we do NOT know if the user will choose to reuse what we have suggested.  save will however be required because this will let us know if we should save the coppied asset that was first sent over or not.  seed is required, because we will want to know 100% sure what the original suggestion was made against.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Save** | **bool** | This will just be a simple boolean here that will say if the use should save the asset or not. | 
**Reuse** | [**ReuseReaction**](ReuseReaction.md) |  | [optional] 
**Seed** | [**SeededConnectorCreation**](SeededConnectorCreation.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

