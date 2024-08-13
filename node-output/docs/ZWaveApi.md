# IO.Swagger.Api.ZWaveApi

All URIs are relative to *https://virtserver.swaggerhub.com/KELVIN18JAHNKE_1/api-web-agendamentos/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLightingSummary**](ZWaveApi.md#getlightingsummary) | **GET** /lightingSummary | 
[**GetSwitchState**](ZWaveApi.md#getswitchstate) | **GET** /lighting/switches/{deviceId} | 
[**SetDimmer**](ZWaveApi.md#setdimmer) | **POST** /lighting/dimmers/{deviceId}/{value} | 
[**SetDimmerTimer**](ZWaveApi.md#setdimmertimer) | **POST** /lighting/dimmers/{deviceId}/{value}/timer/{timeunit} | 
[**SetSwitch**](ZWaveApi.md#setswitch) | **POST** /lighting/switches/{deviceId}/{value} | 
[**SetSwitchTimer**](ZWaveApi.md#setswitchtimer) | **POST** /lighting/switches/{deviceId}/{value}/timer/{minutes} | 

<a name="getlightingsummary"></a>
# **GetLightingSummary**
> LightingSummary GetLightingSummary ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLightingSummaryExample
    {
        public void main()
        {
            var apiInstance = new ZWaveApi();

            try
            {
                LightingSummary result = apiInstance.GetLightingSummary();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZWaveApi.GetLightingSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**LightingSummary**](LightingSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getswitchstate"></a>
# **GetSwitchState**
> DeviceState GetSwitchState (string deviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSwitchStateExample
    {
        public void main()
        {
            var apiInstance = new ZWaveApi();
            var deviceId = deviceId_example;  // string | 

            try
            {
                DeviceState result = apiInstance.GetSwitchState(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZWaveApi.GetSwitchState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**|  | 

### Return type

[**DeviceState**](DeviceState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setdimmer"></a>
# **SetDimmer**
> ModelApiResponse SetDimmer (string deviceId, int? value)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetDimmerExample
    {
        public void main()
        {
            var apiInstance = new ZWaveApi();
            var deviceId = deviceId_example;  // string | 
            var value = 56;  // int? | 

            try
            {
                ModelApiResponse result = apiInstance.SetDimmer(deviceId, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZWaveApi.SetDimmer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**|  | 
 **value** | **int?**|  | 

### Return type

[**ModelApiResponse**](ModelApiResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setdimmertimer"></a>
# **SetDimmerTimer**
> ModelApiResponse SetDimmerTimer (string deviceId, int? value, int? timeunit, string units = null)



sets a dimmer to a specific value on a timer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetDimmerTimerExample
    {
        public void main()
        {
            var apiInstance = new ZWaveApi();
            var deviceId = deviceId_example;  // string | 
            var value = 56;  // int? | 
            var timeunit = 56;  // int? | 
            var units = units_example;  // string |  (optional)  (default to milliseconds)

            try
            {
                ModelApiResponse result = apiInstance.SetDimmerTimer(deviceId, value, timeunit, units);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZWaveApi.SetDimmerTimer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**|  | 
 **value** | **int?**|  | 
 **timeunit** | **int?**|  | 
 **units** | **string**|  | [optional] [default to milliseconds]

### Return type

[**ModelApiResponse**](ModelApiResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setswitch"></a>
# **SetSwitch**
> ModelApiResponse SetSwitch (string deviceId, string value)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetSwitchExample
    {
        public void main()
        {
            var apiInstance = new ZWaveApi();
            var deviceId = deviceId_example;  // string | 
            var value = value_example;  // string | 

            try
            {
                ModelApiResponse result = apiInstance.SetSwitch(deviceId, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZWaveApi.SetSwitch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**|  | 
 **value** | **string**|  | 

### Return type

[**ModelApiResponse**](ModelApiResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setswitchtimer"></a>
# **SetSwitchTimer**
> ModelApiResponse SetSwitchTimer (string deviceId, string value, int? minutes)



sets a switch to a specific value on a timer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetSwitchTimerExample
    {
        public void main()
        {
            var apiInstance = new ZWaveApi();
            var deviceId = deviceId_example;  // string | 
            var value = value_example;  // string | 
            var minutes = 56;  // int? | 

            try
            {
                ModelApiResponse result = apiInstance.SetSwitchTimer(deviceId, value, minutes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZWaveApi.SetSwitchTimer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**|  | 
 **value** | **string**|  | 
 **minutes** | **int?**|  | 

### Return type

[**ModelApiResponse**](ModelApiResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
