using System.Collections.Generic;
namespace Tapmyads.AvatarYug
{
    [System.Serializable]
    public class AvatarData
    {
        public string UserID;
        public string Race;
        public string AgeRange;
        public int Status;
        public int Gender;
        public string DisplayName;
        public string Description;
        public string CustomMetaData;
        public string ThumbUrl;
        public string MetaData;
        public string MeshUrl;
        public int RealCurrency;
        public PropColors ColorMeta = new PropColors();
        public List<Prop> BucketData = new List<Prop>();
        public List<Blendshape> Blendshapes = new List<Blendshape>();
    }

    [System.Serializable]
    public class Blendshape
    {
        public float value;
        public string shapekeys;
        public float sliderValue;
    }
}