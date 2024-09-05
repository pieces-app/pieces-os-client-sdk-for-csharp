# Pieces.Os.Core.SdkModel.DetectedExternalApplications
This is used as the returnable for the /applications/external && /applications/external/related endpoints.  This will return an iterable of Deteched Application a detected Application is an application that is currently installed on your machine.  the /applications/external/related endpoint, will return a subset of the applications returned mainly applications that we detect are Pieces Applications that you have yet to install + names of applications where Pieces is coming soon.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Iterable** | [**List&lt;DetectedExternalApplication&gt;**](DetectedExternalApplication.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

