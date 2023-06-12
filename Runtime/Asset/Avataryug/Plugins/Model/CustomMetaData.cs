using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CustomMetaData
{
    public string key;
    public bool selected;
    public string value;
}

[System.Serializable]
public class CustomMetaDataList
{
    public List<CustomMetaData> customMetaData = new List<CustomMetaData>();
}