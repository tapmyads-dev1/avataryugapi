using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Accounts
{
    public string Platform;
    public string PlatformUserID;
}

[System.Serializable]
public class LinkedAcounts
{
    public List<Accounts> linkedAcounts = new List<Accounts>();
}