# Pieces.Os.Core.SdkModel.SeededActivity
This is the preseed to a full blown Activity.  This is the minimum information needed to create an Activity, used within our [POST] /activities/create  if mechenism is not passed in we will default to AUTOMATIC  NOT required to pass in an asset/user/format.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarEvent** | [**SeededConnectorTracking**](SeededConnectorTracking.md) |  | 
**Application** | [**Application**](Application.md) |  | 
**Asset** | [**ReferencedAsset**](ReferencedAsset.md) |  | [optional] 
**User** | [**ReferencedUser**](ReferencedUser.md) |  | [optional] 
**Format** | [**ReferencedFormat**](ReferencedFormat.md) |  | [optional] 
**Mechanism** | **MechanismEnum** |  | [optional] 
**Conversation** | [**ReferencedConversation**](ReferencedConversation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

