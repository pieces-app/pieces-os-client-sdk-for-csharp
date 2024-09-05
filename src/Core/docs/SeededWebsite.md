# Pieces.Os.Core.SdkModel.SeededWebsite
This is the minimum information required to create a website for a specific asset.  you can optionally add an asset, or person id to attach this website directly to it  TODO consider updating these asset,format to referenced Models

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Asset** | **string** | This is the specific asset that this website is going to get attached to!! | [optional] 
**Conversation** | **string** | This is the specific conversation that this website is going to get attached to!! | [optional] 
**Url** | **string** | this is the url of the website. | 
**Name** | **string** | name of the website.(customizable and updateable as well.) | 
**Mechanism** | **MechanismEnum** |  | [optional] 
**Person** | **string** | this is a uuid of a person that we are going to add the website too. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

