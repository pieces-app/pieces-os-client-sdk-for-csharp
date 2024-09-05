# Pieces.Os.Core.Api.AllocationsApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AllocationsConnectNewCloud**](AllocationsApi.md#allocationsconnectnewcloud) | **POST** /allocations/connect | /allocations/connect [POST] |
| [**AllocationsCreateNewAllocation**](AllocationsApi.md#allocationscreatenewallocation) | **POST** /allocations/create | /allocations/create [POST] |
| [**AllocationsDeleteAllocation**](AllocationsApi.md#allocationsdeleteallocation) | **POST** /allocations/delete | /allocations/delete [POST] |
| [**AllocationsDisconnectCloud**](AllocationsApi.md#allocationsdisconnectcloud) | **POST** /allocations/disconnect | /allocations/disconnect [POST] |
| [**AllocationsReconnectCloud**](AllocationsApi.md#allocationsreconnectcloud) | **POST** /allocations/reconnect | /allocations/reconnect [POST] |
| [**AllocationsSnapshot**](AllocationsApi.md#allocationssnapshot) | **GET** /allocations | /allocations [GET] |

<a id="allocationsconnectnewcloud"></a>
# **AllocationsConnectNewCloud**
> AllocationCloud AllocationsConnectNewCloud (UserProfile userProfile = null)

/allocations/connect [POST]

This will attempt to connect to a specific users cloud.(Required that the current user is logged in.)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AllocationsConnectNewCloudExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AllocationsApi(config);
            var userProfile = new UserProfile(); // UserProfile |  (optional) 

            try
            {
                // /allocations/connect [POST]
                AllocationCloud result = apiInstance.AllocationsConnectNewCloud(userProfile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AllocationsApi.AllocationsConnectNewCloud: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AllocationsConnectNewCloudWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /allocations/connect [POST]
    ApiResponse<AllocationCloud> response = apiInstance.AllocationsConnectNewCloudWithHttpInfo(userProfile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AllocationsApi.AllocationsConnectNewCloudWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userProfile** | [**UserProfile**](UserProfile.md) |  | [optional]  |

### Return type

[**AllocationCloud**](AllocationCloud.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **504** | Gateway Timeout, request timed out. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="allocationscreatenewallocation"></a>
# **AllocationsCreateNewAllocation**
> AllocationCloud AllocationsCreateNewAllocation (AllocationCloud allocationCloud = null)

/allocations/create [POST]

This is unimplemented locally. This will create an allocation. ONLY used within the cloud.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AllocationsCreateNewAllocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AllocationsApi(config);
            var allocationCloud = new AllocationCloud(); // AllocationCloud |  (optional) 

            try
            {
                // /allocations/create [POST]
                AllocationCloud result = apiInstance.AllocationsCreateNewAllocation(allocationCloud);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AllocationsApi.AllocationsCreateNewAllocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AllocationsCreateNewAllocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /allocations/create [POST]
    ApiResponse<AllocationCloud> response = apiInstance.AllocationsCreateNewAllocationWithHttpInfo(allocationCloud);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AllocationsApi.AllocationsCreateNewAllocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **allocationCloud** | [**AllocationCloud**](AllocationCloud.md) |  | [optional]  |

### Return type

[**AllocationCloud**](AllocationCloud.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="allocationsdeleteallocation"></a>
# **AllocationsDeleteAllocation**
> string AllocationsDeleteAllocation (AllocationCloud allocationCloud = null)

/allocations/delete [POST]

This is unimplemented locally. This will delete an allocation. ONLY used within the cloud.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AllocationsDeleteAllocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AllocationsApi(config);
            var allocationCloud = new AllocationCloud(); // AllocationCloud |  (optional) 

            try
            {
                // /allocations/delete [POST]
                string result = apiInstance.AllocationsDeleteAllocation(allocationCloud);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AllocationsApi.AllocationsDeleteAllocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AllocationsDeleteAllocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /allocations/delete [POST]
    ApiResponse<string> response = apiInstance.AllocationsDeleteAllocationWithHttpInfo(allocationCloud);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AllocationsApi.AllocationsDeleteAllocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **allocationCloud** | [**AllocationCloud**](AllocationCloud.md) |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="allocationsdisconnectcloud"></a>
# **AllocationsDisconnectCloud**
> string AllocationsDisconnectCloud (AllocationCloud allocationCloud = null)

/allocations/disconnect [POST]

This will attempt to disconnect to a specific users cloud.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AllocationsDisconnectCloudExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AllocationsApi(config);
            var allocationCloud = new AllocationCloud(); // AllocationCloud |  (optional) 

            try
            {
                // /allocations/disconnect [POST]
                string result = apiInstance.AllocationsDisconnectCloud(allocationCloud);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AllocationsApi.AllocationsDisconnectCloud: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AllocationsDisconnectCloudWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /allocations/disconnect [POST]
    ApiResponse<string> response = apiInstance.AllocationsDisconnectCloudWithHttpInfo(allocationCloud);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AllocationsApi.AllocationsDisconnectCloudWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **allocationCloud** | [**AllocationCloud**](AllocationCloud.md) |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK, this will return the uuid of the cloud that was disconnected! |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="allocationsreconnectcloud"></a>
# **AllocationsReconnectCloud**
> AllocationCloud AllocationsReconnectCloud (AllocationCloud allocationCloud = null)

/allocations/reconnect [POST]

This will attempt to reconnect to a users cloud. This will ensure that we are connected to a users cloud and will ensure that all the data associated with a user's cloud is up-to-date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AllocationsReconnectCloudExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AllocationsApi(config);
            var allocationCloud = new AllocationCloud(); // AllocationCloud |  (optional) 

            try
            {
                // /allocations/reconnect [POST]
                AllocationCloud result = apiInstance.AllocationsReconnectCloud(allocationCloud);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AllocationsApi.AllocationsReconnectCloud: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AllocationsReconnectCloudWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /allocations/reconnect [POST]
    ApiResponse<AllocationCloud> response = apiInstance.AllocationsReconnectCloudWithHttpInfo(allocationCloud);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AllocationsApi.AllocationsReconnectCloudWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **allocationCloud** | [**AllocationCloud**](AllocationCloud.md) |  | [optional]  |

### Return type

[**AllocationCloud**](AllocationCloud.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **504** | Gateway Timeout, request timed out. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="allocationssnapshot"></a>
# **AllocationsSnapshot**
> Allocations AllocationsSnapshot ()

/allocations [GET]

This is going to get a snapshot of all of the connected allocations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AllocationsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new AllocationsApi(config);

            try
            {
                // /allocations [GET]
                Allocations result = apiInstance.AllocationsSnapshot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AllocationsApi.AllocationsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AllocationsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /allocations [GET]
    ApiResponse<Allocations> response = apiInstance.AllocationsSnapshotWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AllocationsApi.AllocationsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Allocations**](Allocations.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

