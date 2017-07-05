# Iatec.Apis.Acms.Membership.v1.Client.Api.ChurchsApi

All URIs are relative to *https://sad-us-fm-1.acms.live.ws.acmsnet.org/public/api/Membership/V1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMany**](ChurchsApi.md#getmany) | **GET** /Church | Get many churchs


<a name="getmany"></a>
# **GetMany**
> List<ChurchModel> GetMany (Guid? id = null, string abbreviation = null, string lastUpdateDate = null)

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
    public class GetManyExample
    {
        public void main()
        {
            
            var apiInstance = new ChurchsApi();
            var id = id_example;  // Guid? | The specific ID of a church. Do not provide when providing an abbreviation. (optional) 
            var abbreviation = abbreviation_example;  // string | Search by this abbreviation. Do not provide when providing an id. (optional) 
            var lastUpdateDate = lastUpdateDate_example;  // string | Filter by the date of the last update. Only filters when abbreviation is provided. (optional) 

            try
            {
                // Get many churchs
                List&lt;ChurchModel&gt; result = apiInstance.GetMany(id, abbreviation, lastUpdateDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChurchsApi.GetMany: " + e.Message );
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
 **lastUpdateDate** | **string**| Filter by the date of the last update. Only filters when abbreviation is provided. | [optional] 

### Return type

[**List<ChurchModel>**](ChurchModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

