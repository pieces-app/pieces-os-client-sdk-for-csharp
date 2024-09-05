# Pieces.Os.Core.SdkModel.Auth0UserMetadata
User Metadata from Auth0

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**GlobalId** | **Guid** |  | 
**CloudKey** | **string** |  | [optional] 
**StripeCustomerId** | **string** | A customer ID that is added to the user in the case of payments | [optional] 
**Vanityname** | **string** | this is the vanityname of the user.(set from their custom CNAME dns record.) ie mark.pieces.cloud where \&quot;mark\&quot; is the vanityname. | [optional] 
**Allocation** | [**Auth0UserAllocationMetadata**](Auth0UserAllocationMetadata.md) |  | [optional] 
**OpenAI** | [**Auth0OpenAIUserMetadata**](Auth0OpenAIUserMetadata.md) |  | [optional] 
**Beta** | [**AnonymousTemporalRange**](AnonymousTemporalRange.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

