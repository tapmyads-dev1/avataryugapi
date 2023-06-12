namespace Tapmyads.AvatarYug
{
    [System.Serializable]
    public class Configs
    {
        public int isNormalUpload;
        public int isOpacityUpload;
        public int isMetallicUpload;
        public int isEmissionUpload;
        public int isRoughnessUpload;
        public int isZipUpload;
        public int isTwoD;
        public int isTransparent;
        public int isGrid;
        public int isDiffuse;
    }

    [System.Serializable]
    public class Config
    {
        public string lod;
        public int device;
        public int format;
        public int textureLODSize;
        public int normals;
        public int rig;
        public int isWithThumb;
        public int characterpose;
        public int isAtlas;
        public int facialblendshape;
    }
    [System.Serializable]
    public class MetaConfig
    {
        public Config config = new Config();
    }
}



