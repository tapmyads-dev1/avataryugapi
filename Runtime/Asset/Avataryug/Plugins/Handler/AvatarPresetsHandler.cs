using System;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Collections.Generic;


public class AvatarPresetsHandler
{
    private Base baseApiCall;
    public AvatarPresetsHandler() { }
    public AvatarPresetsHandler(Base _baseApiCall)
    {
        baseApiCall = _baseApiCall;
    }
    public void GetAvatarPresets(Action<GetAvatarPresetsResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetAvatarPresetsResult)r); }, error);
    }
    public void GetAvatarPresetsByID(Action<GetAvatarPresetByID200> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetAvatarPresetByID200)r); }, error);
    }
    public void GrantAvatarPresetToUser(Action<GrantAvatarToUserResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GrantAvatarToUserResponse)r); }, error);
    }
    public void GrantAvatarPresetItemsToUser(Action<GrantAvatarPresetItemsToUserResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GrantAvatarPresetItemsToUserResponse)r); }, error);
    }
}


public class GrantAvatarPresetItemsToUser : Base
{
    public List<string> itemId = new List<string>();
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            GrantAvatarPresetItemsToUserRequest grantAvatarPreset = new GrantAvatarPresetItemsToUserRequest();
            grantAvatarPreset.ItemIDs = new List<GrantAvatarPresetItemsToUserRequestItemIDsInner>();
            foreach (var item in itemId)
            {
                grantAvatarPreset.ItemIDs.Add(new GrantAvatarPresetItemsToUserRequestItemIDsInner() { ItemID = item });
            }
            new AvatarPresetsApi().GrantAvatarPresetItemsToUser(grantAvatarPreset, (res) => { result?.Invoke(res); }, error);
        }
    }
}


public class GetAvatarPresets : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new AvatarPresetsApi().GetAvatarPresets((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class GetAvatarPresetsByID : Base
{
    public string avatarPresetID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new AvatarPresetsApi().GetAvatarPresetsByID(avatarPresetID, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class GrantAvatarPresetToUser : Base
{
    //public string AvatarUrl;
    //public string ThumbUrl;
    public string UserID;
    public string AvatarData;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new AvatarPresetsApi().GrantAvatarPresetToUser(new GrantAvatarToUserRequest()
            {
                //                AvatarUrl = AvatarUrl,
                //    ThumbUrl = ThumbUrl,
                UserID = UserID,
                AvatarData = AvatarData
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}
