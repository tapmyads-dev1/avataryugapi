using System;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;


public class ExpressionsHandler
{
    public Base baseApiCall;
    public ExpressionsHandler() { }
    public ExpressionsHandler(Base _baseApiCall)
    {
        baseApiCall = _baseApiCall;
    }
    public void GetExpressionByID(Action<GetExpressionByIDResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetExpressionByIDResponse)r); }, error);
    }
    public void GetExpressions(Action<GetExpressionsResponse> result, Action<ApiException> error)
    {
        baseApiCall.CallApi((r) => { result?.Invoke((GetExpressionsResponse)r); }, error);
    }
}

public class GetExpressionByID : Base
{
    public string userid;
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new ExpressionsApi().GetExpressionByID(userid, result, error); ;
        }
    }
}

public class GetExpressions : Base
{
    public override void CallApi(Action<object> result, Action<ApiException> error)
    {
        if (Configuration.ProjectIdPresent)
        {
            Configuration.SetApi();
            new ExpressionsApi().GetExpressions(result, error); ;
        }
    }
}

