# IO.Swagger.Api.ZonesApi

All URIs are relative to *https://virtserver.swaggerhub.com/KELVIN18JAHNKE_1/api-web-agendamentos/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetZones**](ZonesApi.md#getzones) | **GET** /zones | 
[**QuietZone**](ZonesApi.md#quietzone) | **GET** /zones/{zoneId}/quiet | 

<a name="getzones"></a>
# **GetZones**
> List<string> GetZones ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetZonesExample
    {
        public void main()
        {
            var apiInstance = new ZonesApi();

            try
            {
                List&lt;string&gt; result = apiInstance.GetZones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZonesApi.GetZones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="quietzone"></a>
# **QuietZone**
> void QuietZone (string zoneId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuietZoneExample
    {
        public void main()
        {
            var apiInstance = new ZonesApi();
            var zoneId = zoneId_example;  // string | 

            try
            {
                apiInstance.QuietZone(zoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZonesApi.QuietZone: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
