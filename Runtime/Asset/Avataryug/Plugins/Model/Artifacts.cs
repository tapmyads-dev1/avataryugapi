using System.Collections.Generic;

[System.Serializable]

public class SkinToneArtifact
{
    public string body_path;
    public int device;
    public string face_path;
    public bool selected;
    public int texture_size;
}
[System.Serializable]
public class SkinToneArtifacts
{
    public List<SkinToneArtifact> artifacts = new List<SkinToneArtifact>();
}


[System.Serializable]
public class ThreeDArtifact
{
    public int device;
    public int format;
    public int lod;
    public string mesh_url;
    public string meta;
    public int normals;
    public string skin_id;
    public string template_id;
    public int texture_size;

}

[System.Serializable]
public class ThreeDArtifacts
{
    public List<ThreeDArtifact> artifacts = new List<ThreeDArtifact>();
}

[System.Serializable]
public class AvatarPresetArtifact
{
    public int device;
    public int format;
    public int texture_size;
    public int lod;
    public int normals;
    public string mesh_url;
    public bool selected;
    public string meta;
}

[System.Serializable]
public class AvatarPresetArtifacts
{
    public List<AvatarPresetArtifact> artifacts = new List<AvatarPresetArtifact>();
}

[System.Serializable]
public class TwoDArtifacts
{
    public List<TwoDArtifact> artifacts = new List<TwoDArtifact>();
}
[System.Serializable]
public class TwoDArtifact
{
    public int device;
    public int format;
    public string link;
    public int lod;
    public int normals;
    public bool selected;
    public int texture_size;
}