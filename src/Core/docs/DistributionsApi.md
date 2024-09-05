# Pieces.Os.Core.Api.DistributionsApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DistributionsCreateNewDistribution**](DistributionsApi.md#distributionscreatenewdistribution) | **POST** /distributions/create | /distributions/create [POST] |
| [**DistributionsDeleteSpecificDistribution**](DistributionsApi.md#distributionsdeletespecificdistribution) | **POST** /distributions/{distribution}/delete | /distributions/{distribution}/delete [POST] |
| [**DistributionsSnapshot**](DistributionsApi.md#distributionssnapshot) | **GET** /distributions | /distributions [GET] |

<a id="distributionscreatenewdistribution"></a>
# **DistributionsCreateNewDistribution**
> Distribution DistributionsCreateNewDistribution (SeededDistribution seededDistribution = null)

/distributions/create [POST]

This will create a new distribution.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DistributionsCreateNewDistributionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new DistributionsApi(config);
            var seededDistribution = new SeededDistribution(); // SeededDistribution |  (optional) 

            try
            {
                // /distributions/create [POST]
                Distribution result = apiInstance.DistributionsCreateNewDistribution(seededDistribution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistributionsApi.DistributionsCreateNewDistribution: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DistributionsCreateNewDistributionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /distributions/create [POST]
    ApiResponse<Distribution> response = apiInstance.DistributionsCreateNewDistributionWithHttpInfo(seededDistribution);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DistributionsApi.DistributionsCreateNewDistributionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seededDistribution** | [**SeededDistribution**](SeededDistribution.md) |  | [optional]  |

### Return type

[**Distribution**](Distribution.md)

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

<a id="distributionsdeletespecificdistribution"></a>
# **DistributionsDeleteSpecificDistribution**
> void DistributionsDeleteSpecificDistribution (string distribution)

/distributions/{distribution}/delete [POST]

This will delete a specific distribution.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DistributionsDeleteSpecificDistributionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new DistributionsApi(config);
            var distribution = "distribution_example";  // string | This is the uuid of a specific distribution.

            try
            {
                // /distributions/{distribution}/delete [POST]
                apiInstance.DistributionsDeleteSpecificDistribution(distribution);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistributionsApi.DistributionsDeleteSpecificDistribution: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DistributionsDeleteSpecificDistributionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /distributions/{distribution}/delete [POST]
    apiInstance.DistributionsDeleteSpecificDistributionWithHttpInfo(distribution);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DistributionsApi.DistributionsDeleteSpecificDistributionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **distribution** | **string** | This is the uuid of a specific distribution. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="distributionssnapshot"></a>
# **DistributionsSnapshot**
> Distributions DistributionsSnapshot ()

/distributions [GET]

This will get a specific snapshot of all our distributions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class DistributionsSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new DistributionsApi(config);

            try
            {
                // /distributions [GET]
                Distributions result = apiInstance.DistributionsSnapshot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistributionsApi.DistributionsSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DistributionsSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /distributions [GET]
    ApiResponse<Distributions> response = apiInstance.DistributionsSnapshotWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DistributionsApi.DistributionsSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Distributions**](Distributions.md)

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

