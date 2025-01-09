# Pieces.Os.Core.SdkModel.IdentifiedWorkstreamPatternEngineSource
This is a specific persisted model for WorkstreamPatternEngineSources that are persisted in the database(not just on the WPE event)  note: there is a \"WorkstreamPatternEngineSource\" model however we will NOT be modify this because it is linked to a different model that would require additional code to properly associate/disassociate.  note: we get 3 raw events from the WPE data so far:(encapsulated in the \"WorkstreamPatternEngineSource\") event 1. browserUrl - defaults to null 2. appTitle - ** not sure on default here ** (this is because this is always present on all WPE events.) 3. windowTitle - defaults to \"Window Title Not Found\"  note: raw is the raw value from the WPE(expect I will replace the defaults w/ nullish values)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Raw** | [**WorkstreamPatternEngineSource**](WorkstreamPatternEngineSource.md) |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Filter** | **bool** | This will determine if we want to filter this specific source | [optional] 
**Score** | [**Score**](Score.md) |  | [optional] 
**Readable** | **string** | This is the name of the source(defualt original data) this is NOT used for matching just for readability | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

