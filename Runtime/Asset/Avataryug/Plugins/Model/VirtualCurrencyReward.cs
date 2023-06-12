using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VirtualCurrencyReward
{
    public List<CurrencyPrise> currencyRewards = new List<CurrencyPrise>();
}

[System.Serializable]
public class CurrencyPrise
{
    public string Amount;
    public string DisplayName;
    public bool Selected;
    public string UserID;
}
