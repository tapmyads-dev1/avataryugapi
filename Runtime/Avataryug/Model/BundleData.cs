using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bundle
{
    public string BundleCategory;
    public string DisplayName;
    public string Description;
    public string VirtualCurrency;
    public int RealCurrency;
    public string Tags;
    public string Entitlement;
    public int IsStackable;
    public string BundleImageUrl;
    public int IsLimitedEdition;
    public int LimitedEditionIntialCount;
    public string CustomMetaData;
    public string BundleContents;
    public int Status;
    public string ID;
}
[System.Serializable]
public class BundleData
{
    public int Code;
    public string Status;
    public List<Bundle> Data = new List<Bundle>();
}