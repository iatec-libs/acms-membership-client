# Iatec.Apis.Acms.Membership.v1.Client.Api.ChurchsApi

All URIs are relative to *https://sad-us-fm-1.acms.live.ws.acmsnet.org/public/api/Membership/V1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetManyChurches**](ChurchsApi.md#getmanychurches) | **GET** /Church | Get many churchs


<a name="getmanychurches"></a>
# **GetManyChurches**
> List<ChurchModel> GetManyChurches (Guid? id = null, string abbreviation = null, DateTime? lastUpdateDate = null)

Get many churchs

At least the id or the abbreviation must be provided, and both parameters cannot work together.

### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Apis.Acms.Membership.v1.Client.Api;
using Iatec.Apis.Acms.Membership.v1.Client.Client;
using Iatec.Apis.Acms.Membership.v1.Client.Model;

namespace Example
{
    public class GetManyChurchesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("app-key", "Bearer");

            var apiInstance = new ChurchsApi();
            var id = id_example;  // Guid? | The specific ID of a church. Do not provide when providing an abbreviation. (optional) 
            var abbreviation = abbreviation_example;  // string | Search by this abbreviation. Do not provide when providing an id. (optional) 
            var lastUpdateDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter by the date of the last update. Only filters when abbreviation is provided. (optional) 

            try
            {
                // Get many churchs
                List&lt;ChurchModel&gt; result = apiInstance.GetManyChurches(id, abbreviation, lastUpdateDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChurchsApi.GetManyChurches: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid?**| The specific ID of a church. Do not provide when providing an abbreviation. | [optional] 
 **abbreviation** | **string**| Search by this abbreviation. Do not provide when providing an id. | [optional] 
 **lastUpdateDate** | **DateTime?**| Filter by the date of the last update. Only filters when abbreviation is provided. | [optional] 

### Return type

[**List<ChurchModel>**](ChurchModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

