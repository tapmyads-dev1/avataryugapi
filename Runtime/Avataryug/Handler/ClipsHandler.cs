using System;
using System.Collections;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using UnityEngine;

public class ClipsHandler
{
    public Base baseApiCall;
    public ClipsHandler() { }
    public ClipsHandler(Base _baseApiCall)
    {
        baseApiCall = _baseApiCall;
    }
    public void GetClips(Action<GetClipsResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetClipsResponse)r); }, error);
    }
    public void GetClipsByID(Action<GetClipsByIDResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetClipsByIDResponse)r); }, error);
    }
}
public class GetClips : Base
{
    public string userid;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new ClipsApi().GetClips(result, error); ;
        }
    }
}
public class GetClipsByID : Base
{
    public string userid;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new ClipsApi().GetClipsByID(userid, result, error); ;
        }
    }
}