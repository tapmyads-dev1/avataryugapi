using System;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using UnityEngine;

public class LoginWithCustomID : Base
{
    public string CustomID;
    public bool CreateAccount;

    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();

            authApi.LoginWithCustomID(new LoginWithCustomIDRequest()
            {
                CreateAccount = CreateAccount,
                CustomID = CustomID
            },
            (res) =>
            {
                Configuration.AccessToken = res.Data.AccessToken;
                result?.Invoke(res);
            }, error);
        }
    }
}

public class LoginWithEmailAddress : Base
{
    public string EmailID;
    public string Password;
    public bool CreateAccount;

    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();
            authApi.LoginWithEmailAddress(new LoginWithEmailAddressRequest()
            {
                CreateAccount = CreateAccount,
                EmailID = EmailID,
                Password = Password
            }, (res) =>
            {
                Debug.Log("Login2" + res);
                Configuration.AccessToken = res.Data.AccessToken;
                result?.Invoke(res);
            }, error);
        }
    }
}

public class LoginWithAndroidDeviceID : Base
{
    public string AndroidDeviceID;
    public bool CreateAccount;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();
            authApi.LoginWithAndroidDeviceID(new LoginWithAndroidDeviceIDRequest()
            {
                AndroidDeviceID = AndroidDeviceID,
                CreateAccount = CreateAccount
            }, (res) =>
            {
                Configuration.AccessToken = res.Data.AccessToken;
                result?.Invoke(res);
            }, error);
        }
    }
}

public class LoginWithApple : Base
{
    public string AppleID;
    public string AppleIdentityToken;
    public bool CreateAccount;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();
            authApi.LoginWithApple(new LoginWithAppleRequest()
            {
                AppleID = AppleID,
                AppleIdentityToken = AppleIdentityToken,
                CreateAccount = CreateAccount
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class LoginWithFacebook : Base
{
    public bool CreateAccount;
    public string FbAccessToken;
    public string FacebookID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();
            authApi.LoginWithFacebook(new LoginWithFacebookRequest()
            {
                CreateAccount = CreateAccount,
                FbAccessToken = FbAccessToken,
                FacebookID = FacebookID
            }, (res) => { Configuration.AccessToken = res.Data.AccessToken; result?.Invoke(res); }, error);
        }
    }
}

public class LoginWithGoogle : Base
{
    public bool CreateAccount;
    public string GoogleServerAuthCode;
    public string GoogleID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();
            authApi.LoginWithGoogle(new LoginWithGoogleRequest()
            {
                CreateAccount = CreateAccount,
                GoogleServerAuthCode = GoogleServerAuthCode,
                GoogleID = GoogleID
            }, (res) => { Configuration.AccessToken = res.Data.AccessToken; result?.Invoke(res); }, error);
        }
    }
}

public class LoginWithIOSDeviceID : Base
{
    public bool CreateAccount;
    public string IOSDeviceID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();
            authApi.LoginWithIOSDeviceID(new LoginWithIOSDeviceIDRequest()
            {
                CreateAccount = CreateAccount,
                IOSDeviceID = IOSDeviceID
            }, (res) => { Configuration.AccessToken = res.Data.AccessToken; result?.Invoke(res); }, error);
        }
    }
}

public class UpdateEmailPassword : Base
{
    public string EmailID;
    public string Password;
    public string VerificationCode;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();

            authApi.UpdateEmailPassword(new UpdateEmailPasswordRequest()
            {
                EmailID = EmailID,
                Password = Password,
                VerificationCode = VerificationCode

            }, (res) => { result?.Invoke(res); }, error);

        }
    }
}

public class VerifyUserWithEmail : Base
{
    public string UserID;
    public string VerificationCode;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();

            authApi.VerifyUserWithEmail(new VerifyUserWithEmailRequest()
            {
                UserID = UserID,
                VerificationCode = VerificationCode
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class SendAccountVerificationEmail : Base
{
    public string EmailID;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();
            authApi.SendAccountVerificationEmail(new SendAccountVerificationEmailRequest()
            {
                EmailID = EmailID
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}


public class ChangePassword : Base
{
    public string OldPassword;
    public string NewPassword;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            var authApi = new AuthenticationApi();

            authApi.ChangePassword(new ChangePasswordRequest()
            {
                OldPassword = OldPassword,
                NewPassword = NewPassword
            }, (res) => { result?.Invoke(res); }, error);
        }
    }
}

public class AuthenticateHandler
{
    private Base baseApiCall;
    public AuthenticateHandler() { }
    public AuthenticateHandler(Base _baseApiCall)
    {
        baseApiCall = _baseApiCall;
    }
    public void LoginWithCustomID(Action<LoginWithCustomIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LoginWithCustomIDResult)r); }, error);
    }
    public void LoginWithEmailAddress(Action<LoginWithEmailAddressResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LoginWithEmailAddressResult)r); }, error);
    }
    public void LoginWithAndroidDeviceID(Action<LoginWithAndroidDeviceIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LoginWithAndroidDeviceIDResult)r); }, error);
    }
    public void LoginWithApple(Action<LoginWithAppleResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LoginWithAppleResult)r); }, error);
    }
    public void LoginWithFacebook(Action<LoginWithFacebookResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LoginWithFacebookResult)r); }, error);
    }
    public void LoginWithGoogle(Action<LoginWithGoogleResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LoginWithGoogleResult)r); }, error);
    }
    public void LoginWithIOSDeviceID(Action<LoginWithIOSDeviceIDResult> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((LoginWithIOSDeviceIDResult)r); }, error);
    }
    public void UpdateEmailPassword(Action<UpdateEmailPasswordResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((UpdateEmailPasswordResponse)r); }, error);
    }
    public void VerifyUserWithEmail(Action<VerifyUserWithEmailResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((VerifyUserWithEmailResponse)r); }, error);
    }

    public void SendAccountVerificationEmail(Action<SendAccountRecoveryEmailResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((SendAccountRecoveryEmailResponse)r); }, error);
    }

    public void ChangePassword(Action<ChangePasswordResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((ChangePasswordResponse)r); }, error);
    }
}
