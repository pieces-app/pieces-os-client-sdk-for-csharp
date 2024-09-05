# Pieces.Os.Core.SdkModel.Activity
consider a rename to Event? That being said if we go with event we need to think about a word to pre/post fix event because it is likely to be a reserved word.  additional documentation: https://www.notion.so/getpieces/Activity-4da8de193733441f85f87b510235fb74   Notes: - user/asset/format are all optional, NOT required that one of these are present. - if mechanism == internal we will not display to the user.  Thoughts around additional properties. - hmm dismissed array here, that is an array of strings, where the string is the userId that dismissed this notification? or we could potentially do it based on the os_ID. - 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Id** | **string** |  | 
**Created** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**Updated** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | 
**VarEvent** | [**SeededConnectorTracking**](SeededConnectorTracking.md) |  | 
**Application** | [**Application**](Application.md) |  | 
**Deleted** | [**GroupedTimestamp**](GroupedTimestamp.md) |  | [optional] 
**Asset** | [**FlattenedAsset**](FlattenedAsset.md) |  | [optional] 
**User** | [**FlattenedUserProfile**](FlattenedUserProfile.md) |  | [optional] 
**Format** | [**FlattenedFormat**](FlattenedFormat.md) |  | [optional] 
**Mechanism** | **MechanismEnum** |  | 
**Rank** | **int** | This is the numeric value assigned for this activity event. This number is based off the the type of activity event calcaulated on the server side.DO NOT MODIFY. To see what the value qualilates to, please refer to the function within the common sdk. The number here is based on the fib series. from 0 -&gt; infinity but rn there arnt any value over 8. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

