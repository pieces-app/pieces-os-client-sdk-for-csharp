# Pieces.Os.Core.SdkModel.SeededGithubGistsImport
This is the body of the /github/gists/import,  by default we will look for everything from your private gists, (TODO hook up public gists.)&& get clever  currently we will not ensure that this is a good pieces for you but we will just get you the gist and let you do what you want with it(room for improvement, if we want to layer in advanced pieces discovery)  For the future, we might want to add a max number of assets that are returned from this.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Application** | **string** | application id. | 
**VarPublic** | **bool** | This will default to false.(ie private), currently not supporting pulling public gists. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

