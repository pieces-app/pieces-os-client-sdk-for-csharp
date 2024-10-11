# Pieces.Os.Core.Api.UsersApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthenticateFromOauthToken**](UsersApi.md#authenticatefromoauthtoken) | **POST** /users/authenticate/from_token | /users/authenticate/from_token [POST] |
| [**UsersDisconnectUser**](UsersApi.md#usersdisconnectuser) | **POST** /users/{user}/disconnect | /users/{user}/disconnect [POST] |
| [**UsersSnapshot**](UsersApi.md#userssnapshot) | **GET** /users | /users [GET] |
| [**UsersSpecificUserSnapshot**](UsersApi.md#usersspecificusersnapshot) | **GET** /users/{user} | /users/{user} [GET] Scoped to Users |

<a id="authenticatefromoauthtoken"></a>
# **AuthenticateFromOauthToken**
> UserProfile AuthenticateFromOauthToken (OAuthToken oAuthToken = null)

/users/authenticate/from_token [POST]

Creates a User From a oAuth Token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AuthenticateFromOauthTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure OAuth2 access token for authorization: auth0
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: auth0
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: auth0
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var oAuthToken = new OAuthToken(); // OAuthToken |  (optional) 

            try
            {
                // /users/authenticate/from_token [POST]
                UserProfile result = apiInstance.AuthenticateFromOauthToken(oAuthToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.AuthenticateFromOauthToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthenticateFromOauthTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /users/authenticate/from_token [POST]
    ApiResponse<UserProfile> response = apiInstance.AuthenticateFromOauthTokenWithHttpInfo(oAuthToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.AuthenticateFromOauthTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oAuthToken** | [**OAuthToken**](OAuthToken.md) |  | [optional]  |

### Return type

[**UserProfile**](UserProfile.md)

### Authorization

[auth0](../README.md#auth0), [auth0](../README.md#auth0), [auth0](../README.md#auth0)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usersdisconnectuser"></a>
# **UsersDisconnectUser**
> Users UsersDisconnectUser (string user)

/users/{user}/disconnect [POST]

Locally Removing a user for the purpose of Signing Out

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class UsersDisconnectUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new UsersApi(config);
            var user = "user_example";  // string | 

            try
            {
                // /users/{user}/disconnect [POST]
                Users result = apiInstance.UsersDisconnectUser(user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersDisconnectUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersDisconnectUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /users/{user}/disconnect [POST]
    ApiResponse<Users> response = apiInstance.UsersDisconnectUserWithHttpInfo(user);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersDisconnectUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **user** | **string** |  |  |

### Return type

[**Users**](Users.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userssnapshot"></a>
# **UsersSnapshot**
> Users UsersSnapshot ()

/users [GET]

this will return a snapshot of all of the users that are in the users database. TODO might want to make this internal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class UsersSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new UsersApi(config);

            try
            {
                // /users [GET]
                Users result = apiInstance.UsersSnapshot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /users [GET]
    ApiResponse<Users> response = apiInstance.UsersSnapshotWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Users**](Users.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usersspecificusersnapshot"></a>
# **UsersSpecificUserSnapshot**
> UserProfile UsersSpecificUserSnapshot (Guid user)

/users/{user} [GET] Scoped to Users

This enables the client to get the current user.  This endpoint will return a UserPRofile or will throw an error since you are sending user uid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class UsersSpecificUserSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new UsersApi(config);
            var user = 497f6eca-6276-4993-bfeb-53cbbbba6f08;  // Guid | The id (uuid) for a specific user.

            try
            {
                // /users/{user} [GET] Scoped to Users
                UserProfile result = apiInstance.UsersSpecificUserSnapshot(user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersSpecificUserSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersSpecificUserSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /users/{user} [GET] Scoped to Users
    ApiResponse<UserProfile> response = apiInstance.UsersSpecificUserSnapshotWithHttpInfo(user);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersSpecificUserSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **user** | **Guid** | The id (uuid) for a specific user. |  |

### Return type

[**UserProfile**](UserProfile.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

