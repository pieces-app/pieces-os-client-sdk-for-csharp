# Pieces.Os.Core.Api.RelationshipApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RelationshipsSpecificRelationshipSnapshot**](RelationshipApi.md#relationshipsspecificrelationshipsnapshot) | **GET** /relationship/{relationship} | /relationship/{relationship} [GET] |

<a id="relationshipsspecificrelationshipsnapshot"></a>
# **RelationshipsSpecificRelationshipSnapshot**
> Relationship RelationshipsSpecificRelationshipSnapshot (string relationship)

/relationship/{relationship} [GET]

This will return a single relationship object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class RelationshipsSpecificRelationshipSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new RelationshipApi(config);
            var relationship = "relationship_example";  // string | this is a specific relationship uuid.

            try
            {
                // /relationship/{relationship} [GET]
                Relationship result = apiInstance.RelationshipsSpecificRelationshipSnapshot(relationship);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipApi.RelationshipsSpecificRelationshipSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RelationshipsSpecificRelationshipSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /relationship/{relationship} [GET]
    ApiResponse<Relationship> response = apiInstance.RelationshipsSpecificRelationshipSnapshotWithHttpInfo(relationship);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RelationshipApi.RelationshipsSpecificRelationshipSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **relationship** | **string** | this is a specific relationship uuid. |  |

### Return type

[**Relationship**](Relationship.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

