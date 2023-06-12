using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VirtualCurrencyResult
{
    public string Amount;
    public string DisplayName;
    public bool Selected;
    public string UserID;
}

[System.Serializable]
public class VirtualCurrencysResult
{
    public List<VirtualCurrencyResult> virtualCurrencys = new List<VirtualCurrencyResult>();
}