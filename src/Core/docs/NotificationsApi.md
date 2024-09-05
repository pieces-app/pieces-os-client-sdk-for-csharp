# Pieces.Os.Core.Api.NotificationsApi

All URIs are relative to *http://localhost:1000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SendLocalNotification**](NotificationsApi.md#sendlocalnotification) | **POST** /notifications/local/send | Send notification |

<a id="sendlocalnotification"></a>
# **SendLocalNotification**
> void SendLocalNotification (Notification notification = null)

Send notification

Retrieves a snapshot of all available models.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pieces.Os.Core.Api;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.SdkModel;

namespace Example
{
    public class SendLocalNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:1000";
            var apiInstance = new NotificationsApi(config);
            var notification = new Notification(); // Notification |  (optional) 

            try
            {
                // Send notification
                apiInstance.SendLocalNotification(notification);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.SendLocalNotification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendLocalNotificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send notification
    apiInstance.SendLocalNotificationWithHttpInfo(notification);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsApi.SendLocalNotificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notification** | [**Notification**](Notification.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

