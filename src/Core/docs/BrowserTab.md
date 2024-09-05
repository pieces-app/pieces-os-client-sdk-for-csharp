# Pieces.Os.Core.SdkModel.BrowserTab
a tab can have many values because you might want to pass in a value that represents the code_blocks(snippets) or a md represenet note: please only pass 1 representation, I will clean on POS side tho (txt || md || html)  anchor: can be defined in the browser if view a local file  website: this is the given url of the tab  range: this is the amount of time this user is current on this given tab  current: means that this is the current tab that is open  contributors: these are all the extracted people from this given tab

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Values** | [**BrowserTabValues**](BrowserTabValues.md) |  | [optional] 
**Anchor** | [**SeededAnchor**](SeededAnchor.md) |  | [optional] 
**Website** | [**SeededWebsite**](SeededWebsite.md) |  | [optional] 
**Range** | [**AnonymousTemporalRange**](AnonymousTemporalRange.md) |  | [optional] 
**Current** | **bool** |  | [optional] 
**Contributors** | [**DocumentContributors**](DocumentContributors.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

