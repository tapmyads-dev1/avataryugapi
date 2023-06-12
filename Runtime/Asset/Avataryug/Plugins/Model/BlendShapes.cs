using System.Collections.Generic;

namespace Tapmyads.AvatarYug
{
    [System.Serializable]
    public class BlendShapeValue
    {
        public string shapekeys;
        public float sliderValue;
        public int value;
    }
    [System.Serializable]
    public class BlendShapes
    {
        public List<BlendShapeValue> blendShapes = new List<BlendShapeValue>();
    }

    [System.Serializable]
    public class BlendShapeExp
    {
        public string selectedShape;
        public string maincategory;
        public float sliderValue;
        public int value;
    }

    [System.Serializable]
    public class BlendShapesExp
    {
        public List<BlendShapeExp> blendShapes = new List<BlendShapeExp>();
    }

    [System.Serializable]
    public class BlendShapeRender
    {
        public string shapekeys;
        public float value;
    }
    [System.Serializable]
    public class BlendShapeRenderOut
    {
        public List<BlendShapeRender> blendShapes = new List<BlendShapeRender>();
    }
}


