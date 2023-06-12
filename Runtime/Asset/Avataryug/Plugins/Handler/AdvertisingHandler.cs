using System;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;



public class AdvertisingHandler
{
    private Base baseApiCall;
    public AdvertisingHandler() { }
    public AdvertisingHandler(Base _baseApiCall)
    {
        baseApiCall = _baseApiCall;
    }
    public void GetAdsPlacement(Action<GetRewardedAdPlacementsResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetRewardedAdPlacementsResult)r); }, error);
    }

}