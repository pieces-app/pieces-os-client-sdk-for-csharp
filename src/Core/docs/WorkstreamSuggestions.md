# Pieces.Os.Core.SdkModel.WorkstreamSuggestions
This is a list of the materials used in the workstream suggestions.  The feed will return a list of individual material that will be required to be fetched and re-referenced.(the materials that is.)  Considering if we want to have all the materaials just being referenced( ie ReferencedWebsite/ReferencedWorkstreamSummary/...xyz) && rebuilt

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Iterable** | [**List&lt;WorkstreamSuggestion&gt;**](WorkstreamSuggestion.md) |  | 
**Types** | [**List&lt;WorkstreamSuggestionType&gt;**](WorkstreamSuggestionType.md) | This is iterable &lt;WorkstreamSuggestionType&gt;[] that gives the type of each of the items in the iterable. I.E. types[0] is the suggestion type of the item at iterable[0]. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

