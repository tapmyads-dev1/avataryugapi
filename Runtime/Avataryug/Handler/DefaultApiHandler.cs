using System;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;



public class UpdateDefaultAvatarID : Base
{
    public string Avatarid;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new DefaultApi();
            authApi.UpdateDefaultAvatarID(new UpdateDefaultAvatarIDRequest()
            {
                DefualtAvatarID = Avatarid
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class UpdateUserDemographics : Base
{
    public string Gender;
    public string AgeRange;
    public string Race;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new DefaultApi();
            authApi.UpdateUserDemographics(new UpdateUserDemographicsRequest()
            {
                AgeRange = AgeRange,
                Gender = Gender,
                Race = Race
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class SyncAvatars : Base
{
    public bool Image;
    public bool Mesh;
    public string Platform;
    public string UserID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new DefaultApi();
            authApi.SyncAvatars(new SyncAvatarsRequest()
            {
                Image = Image,
                Mesh = Mesh,
                Platform = Platform,
                UserID = UserID
            }
            , (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class GetAdsPlacement : Base
{
    public string appID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new DefaultApi();
            authApi.GetAdsPlacement(appID, (res) => { result?.Invoke(res); }, error);
        }
    }
}
public class RecordAdsActivity : Base
{
    public string RevenueCurrency;
    public int AdRevenue;
    public string PlacementID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new DefaultApi();
            authApi.RecordAdsActivity(new RecordAdsActivityRequest()
            {
                AdRevenue = AdRevenue,
                PlacementID = PlacementID,
                RevenueCurrency = RevenueCurrency
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class GetAllBucketVertices : Base
{
    public string platform;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new DefaultApi().GetAllBucketVertices(platform, result, error);
        }
    }
}
public class GrantAdsReward : Base
{
    public string PlacementID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new DefaultApi().GrantAdsReward(new GrantAdsRewardRequest() { PlacementID = PlacementID }, result, error);
        }
    }
}


public class DeleteUser : Base
{
    public string UserID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var auth = new DefaultApi();
            auth.DeleteUser(new DeleteUserRequest() { UserID = UserID }, result, error);
        }
    }
}


public class RegisterUser : Base
{
    public string AddDisplayName;
    public string EmailID;
    public string Password;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var auth = new DefaultApi();
            auth.RegisterUser(new RegisterUserRequest()
            {
                Password = Password,
                DisplayName = AddDisplayName,
                EmailID = EmailID
            }, (res) =>
            {
                Configuration.AccessToken = res.Data.AccessToken;
                result?.Invoke(res);
            }, error);
        }
    }
}

public class SendAccountRecoveryEmail : Base
{
    public string EmailID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var auth = new DefaultApi();
            auth.SendAccountRecoveryEmail(new SendAccountRecoveryEmailRequset()
            {
                EmailID = EmailID
            }, result, error); ;
        }
    }
}
public class RenderAvatarImage : Base
{
    public string AvatarID;
    public string Platform;

    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var auth = new DefaultApi();
            auth.RenderAvatarImage(new RenderAvatarImageRequest()
            {
                AvatarID = AvatarID,
                Platform = Platform,
            }, result, error);
        }
    }
}
public class GenerateAvatarMesh : Base
{
    public string AvatarID;
    public string Platform;

    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var auth = new DefaultApi();
            auth.GenerateAvatarMesh(new GenerateAvatarMeshRequest()
            {
                AvatarID = AvatarID,
                Platform = Platform,
            }, result, error);
        }
    }
}


public class DefaultApiHandler
{
    public Base baseApiCall;
    public DefaultApiHandler() { }
    public DefaultApiHandler(Base _baseApiCall)
    {
        baseApiCall = _baseApiCall;
    }
    public void GetAllBucketVertices(Action<GetAllBucketVerticesResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetAllBucketVerticesResult)r); }, error);
    }
    public void DeleteUser(Action<DeleteUserResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((DeleteUserResponse)r); }, error);
    }
    public void GenerateAvatar(GenerateAvatarRequest generateAvatarRequest, Action<GenerateAvatarResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { }, error);
    }
    public void RecordAdsActivity(Action<RecordAdsActivityResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((RecordAdsActivityResponse)r); }, error);
    }
    public void GrantAdsReward(Action<GrantAdsRewardResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GrantAdsRewardResponse)r); }, error);
    }
    public void UpdateUserDemographics(Action<UpdateUserDemographicsResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UpdateUserDemographicsResponse)r); }, error);
    }
    public void RegisterUser(Action<RegisterUserResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((RegisterUserResponse)r); }, error);
    }
    public void SendAccountRecoveryEmail(Action<SendAccountVerificationEmailResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((SendAccountVerificationEmailResponse)r); }, error);
    }
    public void GetAdsPlacement(Action<GetAdsPlacementResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetAdsPlacementResponse)r); }, error);
    }
    public void RenderAvatarImage(Action<RenderAvatarImageResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((RenderAvatarImageResponse)r); }, error);
    }
    public void GenerateAvatarMesh(Action<GenerateAvatarMeshResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GenerateAvatarMeshResponse)r); }, error);
    }
    public void SyncAvatars(Action<string> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((string)r); }, error);
    }
    public void UpdateDefaultAvatarID(Action<UpdateDefaultAvatarIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UpdateDefaultAvatarIDResult)r); }, error);
    }

}