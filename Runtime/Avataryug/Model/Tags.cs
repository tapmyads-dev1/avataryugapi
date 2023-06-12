using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tag
{
    public string name;
}

[System.Serializable]
public class Tags
{
    public List<Tag> tags = new List<Tag>();
}