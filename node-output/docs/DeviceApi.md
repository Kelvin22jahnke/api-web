# IO.Swagger.Api.DeviceApi

All URIs are relative to *https://virtserver.swaggerhub.com/KELVIN18JAHNKE_1/api-web-agendamentos/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDevices**](DeviceApi.md#getdevices) | **GET** /devices | 
[**Register**](DeviceApi.md#register) | **POST** /devices | 

<a name="getdevices"></a>
# **GetDevices**
> List<string> GetDevices (int? skip = null, int? limit = null)



returns all registered devices

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDevicesExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var skip = 56;  // int? | number of records to skip (optional) 
            var limit = 56;  // int? | max number of records to return (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetDevices(skip, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.GetDevices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **skip** | **int?**| number of records to skip | [optional] 
 **limit** | **int?**| max number of records to return | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="register"></a>
# **Register**
> void Register (DeviceRegistrationInfo body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var body = new DeviceRegistrationInfo(); // DeviceRegistrationInfo |  (optional) 

            try
            {
                apiInstance.Register(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.Register: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeviceRegistrationInfo**](DeviceRegistrationInfo.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
