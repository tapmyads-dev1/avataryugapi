using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wallet
{
    public string VirtualCurrency;
    public int Amount;
}
[System.Serializable]
public class Wallets
{
    public List<Wallet> wallets = new List<Wallet>();
}