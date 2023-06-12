using System.Collections.Generic;

[System.Serializable]
public class ConflictingBuckets
{
    public List<Bucket> buckets = new List<Bucket>();
}

[System.Serializable]
public class Bucket
{
    public string name;
}

