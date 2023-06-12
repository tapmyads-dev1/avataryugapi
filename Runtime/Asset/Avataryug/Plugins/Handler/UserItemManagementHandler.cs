using System;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Collections.Generic;
using Tapmyads.AvatarYug;
public class UserItemManagementHandler
{
    private Base baseApiCall;
    public UserItemManagementHandler() { }
    public UserItemManagementHandler(Base _baseApiCall)
    {
        baseApiCall = _baseApiCall;
    }
    public void AddVirtualCurrencyToUser(Action<AddVirtualCurrencyToUserResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((AddVirtualCurrencyToUserResult)r); }, error);
    }
    public void ConsumeInstance(Action<ConsumeInstanceResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((ConsumeInstanceResult)r); }, error);
    }
    public void GetUserInventory(Action<GetUserInventoryResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetUserInventoryResult)r); }, error);
    }
    public void GrantInstanceToUser(Action<GrantInstanceToUserResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GrantInstanceToUserResult)r); }, error);
    }
    public void PurchaseInstance(Action<object> result, Action<ApiException> error)
    {
        baseApiCall.CallApi(result, error);
    }
    public void SubtractUserVirtualCurrency(Action result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke(); }, error);
    }
}

public class AddVirtualCurrencyToUser : Base
{
    public int Amount;
    public string VirtualCurrency;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        var authApi = new UserItemManagementApi();
        authApi.AddVirtualCurrencyToUser(new AddVirtualCurrencyToUserRequest()
        {
            Amount = Amount,
            VirtualCurrency = VirtualCurrency
        }, (res) => { result?.Invoke(res); }, error);
    }
}
public class ConsumeInstance : Base
{
    public int InstanceCount;
    public string ID;
    public string UserID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserItemManagementApi();
            authApi.ConsumeInstance(new ConsumeInstanceRequest()
            {
                ID = ID,
                InstanceCount = InstanceCount,
                UserID = UserID
            }
            , (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class GetUserInventory : Base
{
    public string userID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserItemManagementApi();
            authApi.GetUserInventory(userID, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class GrantInstanceToUser : Base
{
    public List<GrantInstanceToUserRequestInstanceIDsInner> InstanceIDs;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserItemManagementApi();
            authApi.GrantInstanceToUser(new GrantInstanceToUserRequest() { InstanceIDs = InstanceIDs }, (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class PurchaseInstance : Base
{
    public InstanceType instanceType;
    public string InstanceID;
    public int Price;
    public string VirtualCurrency;
    public string StoreID;
    public string UserID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserItemManagementApi();
            authApi.PurchaseInstance(new PurchaseInstanceRequest()
            {
                InstanceID = InstanceID,
                UserID = UserID,
                VirtualCurrency = VirtualCurrency,
                InstanceType = instanceType.ToString(),
                Price = Price,
                StoreID = StoreID
            }, result, error);
        }
    }
}
public class SubtractUserVirtualCurrency : Base
{
    public int Amount;
    public string VirtualCurrency;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserItemManagementApi();
            authApi.SubtractUserVirtualCurrency(new SubtractUserVirtualCurrencyRequest() { Amount = Amount, VirtualCurrency = VirtualCurrency }, () => { result?.Invoke("CurrencyAdded"); }, (err) => { });
        }
    }
}
