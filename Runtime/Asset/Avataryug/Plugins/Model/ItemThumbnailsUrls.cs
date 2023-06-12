using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemThumbnailsUrls
{
    public List<ItemThumbnailsUrl> itemThumbnails = new List<ItemThumbnailsUrl>();
}
[System.Serializable]
public class ItemThumbnailsUrl
{
    public int device;
    public string meta;
    public string skin_id;
    public string template_id;
    public int thumb_size;
    public string thumbnail_url;
}

[System.Serializable]
public class ItemThumbUrls
{
    public List<ItemThumUrl> itemThumbnails = new List<ItemThumUrl>();
}
[System.Serializable]
public class ItemThumUrl
{
    public int device;
    public bool selected;
    public string texture;
    public string thumbnail_url;
}
