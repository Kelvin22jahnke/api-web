# IO.Swagger.Api.EnvironmentApi

All URIs are relative to *https://virtserver.swaggerhub.com/KELVIN18JAHNKE_1/api-web-agendamentos/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetForecast**](EnvironmentApi.md#getforecast) | **GET** /temperature/forecast/{days} | 
[**GetHeaterState**](EnvironmentApi.md#getheaterstate) | **GET** /temperature/{zoneId}/heater | 
[**GetZoneTemperature**](EnvironmentApi.md#getzonetemperature) | **GET** /temperature/{zoneId} | 
[**SetHeaterState**](EnvironmentApi.md#setheaterstate) | **POST** /temperature/{zoneId}/heater/{state} | 
[**TemperatureSummary**](EnvironmentApi.md#temperaturesummary) | **GET** /temperature | 

<a name="getforecast"></a>
# **GetForecast**
> ForecastResponse GetForecast (int? days)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetForecastExample
    {
        public void main()
        {
            var apiInstance = new EnvironmentApi();
            var days = 56;  // int? | 

            try
            {
                ForecastResponse result = apiInstance.GetForecast(days);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.GetForecast: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **days** | **int?**|  | 

### Return type

[**ForecastResponse**](ForecastResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getheaterstate"></a>
# **GetHeaterState**
> HeaterState GetHeaterState (string zoneId)



gets the state of the heater

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHeaterStateExample
    {
        public void main()
        {
            var apiInstance = new EnvironmentApi();
            var zoneId = zoneId_example;  // string | 

            try
            {
                HeaterState result = apiInstance.GetHeaterState(zoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.GetHeaterState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **string**|  | 

### Return type

[**HeaterState**](HeaterState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getzonetemperature"></a>
# **GetZoneTemperature**
> TemperatueZoneStatus GetZoneTemperature (string zoneId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetZoneTemperatureExample
    {
        public void main()
        {
            var apiInstance = new EnvironmentApi();
            var zoneId = zoneId_example;  // string | 

            try
            {
                TemperatueZoneStatus result = apiInstance.GetZoneTemperature(zoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.GetZoneTemperature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **string**|  | 

### Return type

[**TemperatueZoneStatus**](TemperatueZoneStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setheaterstate"></a>
# **SetHeaterState**
> ModelApiResponse SetHeaterState (string zoneId, string state)



turns the heater on or off

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetHeaterStateExample
    {
        public void main()
        {
            var apiInstance = new EnvironmentApi();
            var zoneId = zoneId_example;  // string | 
            var state = state_example;  // string | 

            try
            {
                ModelApiResponse result = apiInstance.SetHeaterState(zoneId, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.SetHeaterState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **string**|  | 
 **state** | **string**|  | 

### Return type

[**ModelApiResponse**](ModelApiResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="temperaturesummary"></a>
# **TemperatureSummary**
> TemperatureSummary TemperatureSummary ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemperatureSummaryExample
    {
        public void main()
        {
            var apiInstance = new EnvironmentApi();

            try
            {
                TemperatureSummary result = apiInstance.TemperatureSummary();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentApi.TemperatureSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TemperatureSummary**](TemperatureSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
