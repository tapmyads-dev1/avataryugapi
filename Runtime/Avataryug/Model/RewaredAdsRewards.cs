using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActionArray
{
    public MetaData metaData = new MetaData();
    public string quantity;
    public string type;
}

[System.Serializable]
public class MetaData
{
    public string item;
}

[System.Serializable]
public class RewaredAdsRewards
{
    public List<Rewards> rewards = new List<Rewards>();
}

[System.Serializable]
public class Rewards
{
    public string Odds;
    public List<ActionArray> actionArray = new List<ActionArray>();
    public bool @checked;
    public string description;
    public int id;
    public string name;
    public object rewardurl;
    public bool selected;
    public string value;
}



