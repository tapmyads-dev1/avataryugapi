using System;
using Org.OpenAPITools.Client;

public abstract class Base
{
    public abstract void CallApi(Action<object> result, Action<ApiException> error);
}