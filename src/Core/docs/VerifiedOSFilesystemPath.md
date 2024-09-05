# Pieces.Os.Core.SdkModel.VerifiedOSFilesystemPath
This will return is the given path was verified/ or it was invalid.  and if it is valid if it is a file/folder  note: file/directory are both null.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional] 
**Path** | **string** |  | 
**File** | **bool** |  | [optional] 
**Directory** | **bool** |  | [optional] 
**Verified** | **bool** | This means if the path(file/folder) exists on the machine. | 
**Denied** | **bool** | This means that attempting to access the file was not aloud(ie no permission) | [optional] 
**Bytes** | [**ByteDescriptor**](ByteDescriptor.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

