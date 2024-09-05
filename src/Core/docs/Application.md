# Pieces.Os.Core.SdkModel.Application
A Model to describe what application a format/analytics event originated.  mechanism: This will let us know where this came from. ie.only 2 enums are used here or else throw and error. default mechanism here is MANUAL- meaning that this came from our user Connecting an application. INTERNAL - means that this came from a shareable link

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** | The ID of the application at the device level | 
**Name** | **ApplicationNameEnum** |  | 
**VarVersion** | **string** | This is the specific version number 0.0.0 | 
**Platform** | **PlatformEnum** |  | 
**Onboarded** | **bool** |  | 
**Privacy** | **PrivacyEnum** |  | 
**Capabilities** | **CapabilitiesEnum** |  | [optional] 
**Mechanism** | **MechanismEnum** |  | [optional] 
**AutomaticUnload** | **bool** | This is a proper that will let us know if we will proactivity unload all of your machine learning models.by default this is false. | [optional] 
**Enrichment** | [**SeededAssetEnrichment**](SeededAssetEnrichment.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

