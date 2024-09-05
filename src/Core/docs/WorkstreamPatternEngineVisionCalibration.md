# Pieces.Os.Core.SdkModel.WorkstreamPatternEngineVisionCalibration
This model is used for the dimensions of the copilot/feed/xyz window.  if dimensions/captured are null this means we do not have the dimensions for this given window.  TODO: consider adding 5 markers here for the qr codes(ie location of these as wel) NOTE: will want to add type of calibration for this specific dimension(ie copilot/feed/xyz)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Foreground** | **string** | This is the name of the window(foreground window).(this will always be present) | 
**Captured** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Dimensions** | [**WindowDimensions**](WindowDimensions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

