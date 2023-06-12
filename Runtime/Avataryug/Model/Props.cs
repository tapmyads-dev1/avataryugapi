using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Props
{
    public List<Prop> props = new List<Prop>();
}

[System.Serializable]
public class Prop
{
    public string CoreBucket;
    public string ID;
}

