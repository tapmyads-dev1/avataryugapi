using System;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

public class UserAccountManagementHandle
{
    private Base baseApiCall;
    public UserAccountManagementHandle() { }
    public UserAccountManagementHandle(Base _baseApiCall)
    {
        baseApiCall = _baseApiCall;
    }
    public void AddEmailPassword(Action<AddEmailPasswordResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((AddEmailPasswordResult)r); }, error);
    }
    public void AddGenericServiceID(Action<AddGenericServiceIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((AddGenericServiceIDResult)r); }, error);
    }
    public void AddUserAvatar(Action<AddUserAvatarResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((AddUserAvatarResult)r); }, error);
    }
    public void DeleteUserAvatar(Action<DeleteUserAvatarResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((DeleteUserAvatarResult)r); }, error);
    }
    public void GetUserAccountInfo(Action<GetUserAccountInfoResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetUserAccountInfoResult)r); }, error);
    }
    public void GetUserProfile(Action<GetUserProfileResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetUserProfileResult)r); }, error);
    }
    public void GetUsersAllAvatars(Action<GetUsersAllAvatarsResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetUsersAllAvatarsResult)r); }, error);
    }
    public void LinkAndroidDeviceID(Action<LinkAndroidDeviceIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LinkAndroidDeviceIDResult)r); }, error);
    }
    public void LinkApple(Action<LinkAppleResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LinkAppleResult)r); }, error);
    }
    public void LinkCustomID(Action<LinkCustomIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LinkCustomIDResult)r); }, error);
    }
    public void LinkFacebookAccount(Action<LinkFacebookAccountResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LinkFacebookAccountResult)r); }, error);
    }
    public void LinkGoogleAccount(Action<LinkGoogleAccountResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LinkGoogleAccountResult)r); }, error);
    }
    public void LinkIOSDeviceID(Action<LinkIOSDeviceIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LinkIOSDeviceIDResult)r); }, error);
    }
    public void RemoveGenericServiceID(Action<RemoveGenericServiceIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((RemoveGenericServiceIDResult)r); }, error);
    }
    public void UnlinkAndroidDeviceID(Action<UnlinkAndroidDeviceIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UnlinkAndroidDeviceIDResult)r); }, error);
    }
    public void UnlinkApple(Action<UnlinkAppleResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UnlinkAppleResult)r); }, error);
    }
    public void UnlinkCustomID(Action<UnlinkCustomIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UnlinkCustomIDResult)r); }, error);
    }
    public void UnlinkFacebookAccount(Action<UnlinkFacebookAccountResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UnlinkFacebookAccountResult)r); }, error);
    }
    public void UnlinkGoogleAccount(Action<UnlinkGoogleAccountResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UnlinkGoogleAccountResult)r); }, error);
    }
    public void UnlinkIOSDeviceID(Action<UnlinkIOSDeviceIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UnlinkIOSDeviceIDResult)r); }, error);
    }
    public void UpdateAvatarUrl(Action<UpdateAvatarUrlResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UpdateAvatarUrlResult)r); }, error);
    }
    public void UpdateImageAvatarUrl(Action<UpdateImageAvatarUrlResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UpdateImageAvatarUrlResult)r); }, error);
    }
    public void UpdateUserAvatar(Action<UpdateUserAvatarResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UpdateUserAvatarResult)r); }, error);
    }
    public void UpdateUserProjectDisplayName(Action<UpdateUserProjectDisplayNameResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UpdateUserProjectDisplayNameResult)r); }, error);
    }
}

public class AddEmailPassword : Base
{
    public string EmailID;
    public string Password;
    public string UserID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.AddEmailPassword(new AddEmailPasswordRequest()
            {
                EmailID = EmailID,
                Password = Password,
                UserID = UserID
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class AddGenericServiceID : Base
{
    public string GenericServiceID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.AddGenericServiceID(new AddGenericServiceIDRequest()
            {
                GenericServiceID = GenericServiceID
            }
            , (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class AddUserAvatar : Base
{
    public string AvatarUrl;
    public string ThumbUrl;
    public string UserID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.AddUserAvatar(new AddUserAvatarRequest()
            {
                //  AvatarUrl = AvatarUrl,
                //  ThumbUrl = ThumbUrl,
                UserID = UserID
            }
            , (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class DeleteUserAvatar : Base
{
    public string AvatarID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.DeleteUserAvatar(new DeleteUserAvatarRequest() { AvatarID = AvatarID }
            , (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class GetUserAccountInfo : Base
{
    public string userID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.GetUserAccountInfo(userID, (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class GetUserProfile : Base
{
    public string userID;
    public bool showDisplayName;
    public bool showThumbUrl;
    public bool showAvatarUrl;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new UserAccountManagementApi().GetUserProfile(userID, showDisplayName, showThumbUrl, showAvatarUrl, (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class GetUsersAllAvatars : Base
{
    public string userID;

    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.GetUsersAllAvatars(userID, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class LinkAndroidDeviceID : Base
{
    public string AndroidDeviceID;
    public bool ForceLink;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.LinkAndroidDeviceID(new LinkAndroidDeviceIDRequest()
            {
                AndroidDeviceID = AndroidDeviceID,
                ForceLink = ForceLink
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class LinkApple : Base
{
    public string AppleID;
    public bool ForceLink;
    public string IdentityToken;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.LinkApple(new LinkAppleRequest()
            {
                AppleID = AppleID,
                ForceLink = ForceLink,
                IdentityToken = IdentityToken
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class LinkCustomID : Base
{
    public string CustomID;
    public bool ForceLink;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.LinkCustomID(new LinkCustomIDRequest()
            {
                CustomID = CustomID,
                ForceLink = ForceLink
            }
        , (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class LinkFacebookAccount : Base
{
    public string FacebookID;
    public bool ForceLink;
    public string AccessToken;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.LinkFacebookAccount(new LinkFacebookAccountRequest()
            {
                AccessToken = AccessToken,
                FacebookID = FacebookID,
                ForceLink = ForceLink
            }
        , (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class LinkGoogleAccount : Base
{
    public string GoogleServerAuthCode;
    public bool ForceLink;
    public string GoogleID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.LinkGoogleAccount(new LinkGoogleAccountRequest()
            {
                GoogleServerAuthCode = GoogleServerAuthCode,
                ForceLink = ForceLink,
                GoogleID = GoogleID
            }
        , (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class LinkIOSDeviceID : Base
{
    public string DeviceID;
    public bool ForceLink;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.LinkIOSDeviceID(new LinkIOSDeviceIDRequest() { DeviceID = DeviceID, ForceLink = ForceLink }
        , (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class RemoveGenericServiceID : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.RemoveGenericServiceID((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class UnlinkAndroidDeviceID : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.UnlinkAndroidDeviceID((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class UnlinkApple : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.UnlinkApple((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class UnlinkCustomID : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.UnlinkCustomID((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class UnlinkFacebookAccount : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.UnlinkFacebookAccount((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class UnlinkGoogleAccount : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.UnlinkGoogleAccount((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class UnlinkIOSDeviceID : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.UnlinkIOSDeviceID((res) => { result?.Invoke(res); }, error);
        }
    }
}

public class UpdateAvatarUrl : Base
{
    public string MeshUrl;
    public string UserID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.UpdateAvatarUrl(new UpdateAvatarUrlRequest()
            {
                MeshUrl = MeshUrl,
                UserID = UserID
            },
            (res) =>
            {
                result?.Invoke(res);
            }, error);
        }
    }
}

public class UpdateImageAvatarUrl : Base
{
    public string ImageUrl;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.UpdateImageAvatarUrl(new UpdateImageAvatarUrlRequest() { ImageUrl = ImageUrl },
            (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class UpdateUserAvatar : Base
{
    public string AvatarID;
    public string AvatarUrl;
    public string ThumbUrl;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.UpdateUserAvatar(new UpdateUserAvatarRequest() { AvatarID = AvatarID, AvatarUrl = AvatarUrl, ThumbUrl = ThumbUrl },
            (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class UpdateUserProjectDisplayName : Base
{
    public string DisplayName;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new UserAccountManagementApi();
            authApi.UpdateUserProjectDisplayName(new UpdateUserProjectDisplayNameRequest() { DisplayName = DisplayName },
            (res) => { result?.Invoke(res); }, error);
        }
    }
}
