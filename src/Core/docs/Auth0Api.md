# Pieces.Os.Core.Api.Auth0Api

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Auth0Logout**](Auth0Api.md#auth0logout) | **GET** /v2/logout | https://auth.pieces.services/v2/logout [GET] |
| [**AuthorizeAuth0**](Auth0Api.md#authorizeauth0) | **GET** /authorize | https://auth.pieces.services/authorize [GET] |
| [**ExchangeForAuth0Token**](Auth0Api.md#exchangeforauth0token) | **POST** /oauth/token | https://auth.pieces.services/oauth/token [POST] |
| [**GetAuth0UserInfo**](Auth0Api.md#getauth0userinfo) | **GET** /userinfo | https://auth.pieces.services/userinfo [GET] |

<a id="auth0logout"></a>
# **Auth0Logout**
> string Auth0Logout (string clientId = null, string returnTo = null)

https://auth.pieces.services/v2/logout [GET]

https://auth0.com/docs/api/authentication#logout

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class Auth0LogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new Auth0Api(config);
            var clientId = "clientId_example";  // string | The client ID of the Auth0 Instance (optional) 
            var returnTo = "returnTo_example";  // string | The URL that the logout endpoint will return to (optional) 

            try
            {
                // https://auth.pieces.services/v2/logout [GET]
                string result = apiInstance.Auth0Logout(clientId, returnTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth0Api.Auth0Logout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Auth0LogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // https://auth.pieces.services/v2/logout [GET]
    ApiResponse<string> response = apiInstance.Auth0LogoutWithHttpInfo(clientId, returnTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Auth0Api.Auth0LogoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | The client ID of the Auth0 Instance | [optional]  |
| **returnTo** | **string** | The URL that the logout endpoint will return to | [optional]  |

### Return type

**string**

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authorizeauth0"></a>
# **AuthorizeAuth0**
> ResultedPKCE AuthorizeAuth0 (string audience, List<string> scope, string responseType, string clientId, string codeChallengeMethod, string codeChallenge, string responseMode, string state = null, string redirectUri = null, string connection = null, string prompt = null)

https://auth.pieces.services/authorize [GET]

An endpoint that is used locally authenticate via a PKCE Flow.  Example https://auth.pieces.services /authorize?audience=https%3A%2F%2Fpieces.us.auth0.com%2Fapi%2Fv2%2F&scope=email+profile+offline_access+openid&response_type=code&client_id=9sW4Pa1LEjX67l6VO14u0207NLYeXnu1&redirect_uri=http%3A%2F%2Flocalhost%3A3000%2Fpkce%2Fresponse%2Fcode&code_challenge_method=S256&code_challenge=yxRssZxdfBpMigRmDxAety1QU72Bd5WnDUbtlsCZOnk&response_mode=form_post&state=4bd0b9a389b4b229602346c33913b4c3c199628a90011ab3a901302ab62b3832

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class AuthorizeAuth0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new Auth0Api(config);
            var audience = https://pieces.us.auth0.com/api/v2/;  // string |  The unique identifier of the target API you want to access.
            var scope = new List<string>(); // List<string> | The scopes which you want to request authorization for. These must be separated by a space. You can request any of the standard OpenID Connect (OIDC) scopes about users, such as profile and email, custom claims that must conform to a namespaced format, or any scopes supported by the target API (for example, read:contacts). Include offline_access to get a Refresh Token.
            var responseType = code;  // string | Indicates to Auth0 which OAuth 2.0 Flow you want to perform. Use code for Authorization Code Grant (PKCE) Flow.
            var clientId = 9sW4Pa1LEjX67l6VO14u0207NLYeXnu1;  // string | Your application's Client ID.
            var codeChallengeMethod = S256;  // string | Method used to generate the challenge. The PKCE spec defines two methods, S256 and plain, however, Auth0 supports only S256 since the latter is discouraged.
            var codeChallenge = yxRssZxdfBpMigRmDxAety1QU72Bd5WnDUbtlsCZOnk;  // string | Generated challenge from the code_verifier.
            var responseMode = "form_post";  // string | 
            var state = "state_example";  // string | An opaque value the clients adds to the initial request that Auth0 includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks. (optional) 
            var redirectUri = "redirectUri_example";  // string | The URL to which Auth0 will redirect the browser after authorization has been granted by the user. (optional) 
            var connection = "connection_example";  // string | The name of the connection configured to your application. (optional) 
            var prompt = "prompt_example";  // string | To initiate a silent authentication request, use prompt=none (see Remarks for more info). (optional) 

            try
            {
                // https://auth.pieces.services/authorize [GET]
                ResultedPKCE result = apiInstance.AuthorizeAuth0(audience, scope, responseType, clientId, codeChallengeMethod, codeChallenge, responseMode, state, redirectUri, connection, prompt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth0Api.AuthorizeAuth0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizeAuth0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // https://auth.pieces.services/authorize [GET]
    ApiResponse<ResultedPKCE> response = apiInstance.AuthorizeAuth0WithHttpInfo(audience, scope, responseType, clientId, codeChallengeMethod, codeChallenge, responseMode, state, redirectUri, connection, prompt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Auth0Api.AuthorizeAuth0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **audience** | **string** |  The unique identifier of the target API you want to access. |  |
| **scope** | [**List&lt;string&gt;**](string.md) | The scopes which you want to request authorization for. These must be separated by a space. You can request any of the standard OpenID Connect (OIDC) scopes about users, such as profile and email, custom claims that must conform to a namespaced format, or any scopes supported by the target API (for example, read:contacts). Include offline_access to get a Refresh Token. |  |
| **responseType** | **string** | Indicates to Auth0 which OAuth 2.0 Flow you want to perform. Use code for Authorization Code Grant (PKCE) Flow. |  |
| **clientId** | **string** | Your application&#39;s Client ID. |  |
| **codeChallengeMethod** | **string** | Method used to generate the challenge. The PKCE spec defines two methods, S256 and plain, however, Auth0 supports only S256 since the latter is discouraged. |  |
| **codeChallenge** | **string** | Generated challenge from the code_verifier. |  |
| **responseMode** | **string** |  |  |
| **state** | **string** | An opaque value the clients adds to the initial request that Auth0 includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks. | [optional]  |
| **redirectUri** | **string** | The URL to which Auth0 will redirect the browser after authorization has been granted by the user. | [optional]  |
| **connection** | **string** | The name of the connection configured to your application. | [optional]  |
| **prompt** | **string** | To initiate a silent authentication request, use prompt&#x3D;none (see Remarks for more info). | [optional]  |

### Return type

[**ResultedPKCE**](ResultedPKCE.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/x-www-form-urlencoded


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exchangeforauth0token"></a>
# **ExchangeForAuth0Token**
> OAuthToken ExchangeForAuth0Token (string grantType, string clientId, string code, string redirectUri, string codeVerifier, EmbeddedModelSchema schema = null, string audience = null)

https://auth.pieces.services/oauth/token [POST]

An endpoint to generate a OAuth Token for an authentication flow. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class ExchangeForAuth0TokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            // Configure API key authorization: application
            config.AddApiKey("X-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Application-ID", "Bearer");

            var apiInstance = new Auth0Api(config);
            var grantType = "refresh_token";  // string | Denotes the flow you are using. For Authorization Code, use authorization_code or refresh_token.
            var clientId = "clientId_example";  // string | Your application's Client ID.
            var code = "code_example";  // string | The Authorization Code received from the initial /authorize call.
            var redirectUri = "redirectUri_example";  // string | This is required only if it was set at the GET /authorize endpoint. The values must match.
            var codeVerifier = "codeVerifier_example";  // string | Cryptographically random key that was used to generate the code_challenge passed to /authorize.
            var schema = new EmbeddedModelSchema(); // EmbeddedModelSchema |  (optional) 
            var audience = "audience_example";  // string | The audience domain: i.e. https://pieces.us.auth0.com (optional) 

            try
            {
                // https://auth.pieces.services/oauth/token [POST]
                OAuthToken result = apiInstance.ExchangeForAuth0Token(grantType, clientId, code, redirectUri, codeVerifier, schema, audience);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth0Api.ExchangeForAuth0Token: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExchangeForAuth0TokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // https://auth.pieces.services/oauth/token [POST]
    ApiResponse<OAuthToken> response = apiInstance.ExchangeForAuth0TokenWithHttpInfo(grantType, clientId, code, redirectUri, codeVerifier, schema, audience);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Auth0Api.ExchangeForAuth0TokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **grantType** | **string** | Denotes the flow you are using. For Authorization Code, use authorization_code or refresh_token. |  |
| **clientId** | **string** | Your application&#39;s Client ID. |  |
| **code** | **string** | The Authorization Code received from the initial /authorize call. |  |
| **redirectUri** | **string** | This is required only if it was set at the GET /authorize endpoint. The values must match. |  |
| **codeVerifier** | **string** | Cryptographically random key that was used to generate the code_challenge passed to /authorize. |  |
| **schema** | [**EmbeddedModelSchema**](EmbeddedModelSchema.md) |  | [optional]  |
| **audience** | **string** | The audience domain: i.e. https://pieces.us.auth0.com | [optional]  |

### Return type

[**OAuthToken**](OAuthToken.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauth0userinfo"></a>
# **GetAuth0UserInfo**
> Auth0User GetAuth0UserInfo ()

https://auth.pieces.services/userinfo [GET]

Get the users info from the Auth0 API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class GetAuth0UserInfoExample
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

            var apiInstance = new Auth0Api(config);

            try
            {
                // https://auth.pieces.services/userinfo [GET]
                Auth0User result = apiInstance.GetAuth0UserInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Auth0Api.GetAuth0UserInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuth0UserInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // https://auth.pieces.services/userinfo [GET]
    ApiResponse<Auth0User> response = apiInstance.GetAuth0UserInfoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Auth0Api.GetAuth0UserInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Auth0User**](Auth0User.md)

### Authorization

[auth0](../README.md#auth0), [auth0](../README.md#auth0), [auth0](../README.md#auth0)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

