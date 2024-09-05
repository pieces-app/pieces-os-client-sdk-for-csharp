# Pieces.Os.Core.SdkModel.IDETab
This is a representation of an IDE Tab  value: is the value of the entire file(that being said we do not recomment passing this over as we can read this file on PieceOS side of things) classification: this is the classifcation of this file  selection: this is a represention of a copy/paste/selection of a bit of code  anchor: this is the file path  range: this is the duration that this user has been on this Tab  current: is a boolean that will let us know if this is the current active tab  contributors: is the people that are extracted via git  lsp: this is the languageserverprotocol this is used for may things such as error,stackstrces, mainly information extracted from the lang server

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Value** | [**TransferableString**](TransferableString.md) |  | [optional] 
**Classification** | [**Classification**](Classification.md) |  | [optional] 
**Selections** | [**IDESelections**](IDESelections.md) |  | [optional] 
**Anchor** | [**SeededAnchor**](SeededAnchor.md) |  | 
**Range** | [**AnonymousTemporalRange**](AnonymousTemporalRange.md) |  | [optional] 
**Current** | **bool** |  | [optional] 
**Contributors** | [**DocumentContributors**](DocumentContributors.md) |  | [optional] 
**Lsp** | [**LanguageServerProtocol**](LanguageServerProtocol.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

