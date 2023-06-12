using System;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

public class EconomyHandler
{
    private Base baseApiCall;
    public EconomyHandler() { }
    public EconomyHandler(Base _baseApiCall)
    {
        baseApiCall = _baseApiCall;
    }
    public void GetEconomyBundleByID(Action<GetEconomyBundleByIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetEconomyBundleByIDResult)r); }, error);
    }
    public void GetEconomyBundles(Action<GetEconomyBundlesResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetEconomyBundlesResult)r); }, error);
    }
    public void GetEconomyContainerByID(Action<GetEconomyContainerByIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetEconomyContainerByIDResult)r); }, error);
    }
    public void GetEconomyContainers(Action<GetEconomyContainersResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetEconomyContainersResult)r); }, error);
    }
    public void GetEconomyItems(Action<GetEconomyItemsResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetEconomyItemsResult)r); }, error);
    }
    public void GetEconomyItemsByID(Action<GetEconomyItemsByIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetEconomyItemsByIDResult)r); }, error);
    }
    public void GetEconomyStores(Action<GetEconomyStoresResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetEconomyStoresResult)r); }, error);
    }
    public void GetStoreItemsByID(Action<GetStoreItemsByIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetStoreItemsByIDResult)r); }, error);
    }
    public void UnlockContainerInstance(Action<UnlockContainerInstanceResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UnlockContainerInstanceResult)r); }, error);
    }
}

public class GetEconomyBundleByID : Base
{
    public string bundleID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new EconomyApi().GetEconomyBundleByID(bundleID, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class GetEconomyBundles : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new EconomyApi().GetEconomyBundles((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class GetEconomyContainerByID : Base
{
    public string containerID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        new EconomyApi().GetEconomyContainerByID(containerID, (res) => { result?.Invoke(res); }, error);
    }
}

public class GetEconomyContainers : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new EconomyApi().GetEconomyContainers((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class GetEconomyItems : Base
{
    public string category;
    public int status;
    public int gender;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new EconomyApi().GetEconomyItems(category, status, gender, (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class GetEconomyItemsByID : Base
{
    public string itemID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new EconomyApi().GetEconomyItemsByID(itemID, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class GetEconomyStores : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new EconomyApi().GetEconomyStores((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class GetStoreItemsByID : Base
{
    public string storeID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        new EconomyApi().GetStoreItemsByID(storeID, (res) => { result?.Invoke(res); }, error);
    }
}

public class UnlockContainerInstance : Base
{
    public string ContainerInstanceID;
    public string KeyInstanceID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new EconomyApi().UnlockContainerInstance(new UnlockContainerInstanceRequest()
            { ContainerInstanceID = ContainerInstanceID, KeyInstanceID = KeyInstanceID }, (res) => { result?.Invoke(res); }, error);
        }
    }
}
