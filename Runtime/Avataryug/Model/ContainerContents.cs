using System.Collections.Generic;
namespace Org.OpenAPITools.Model
{
    [System.Serializable]
    public class ContainerBase
    {
        public string Code;
        public string Quantity;
        public string UserID;
        public string containerType;
    }
    //[System.Serializable]
    //public class Bundles : ContainerBase
    //{
    //    public string Quantity;
    //    public string UserID;
    //}

    //[System.Serializable]
    //public class Container : ContainerBase
    //{
    //    public string Quantity;
    //    public string UserID;
    //}

    //[System.Serializable]
    //public class Currency : ContainerBase
    //{
    //    public string Code;
    //    public string Quantity;
    //    public string UserID;
    //}

    //[System.Serializable]
    //public class Droptable : ContainerBase
    //{
    //    public string Quantity;
    //    public string UserID;
    //}

    //[System.Serializable]
    //public class Item : ContainerBase
    //{
    //    public string Quantity;
    //    public string UserID;
    //}

    [System.Serializable]
    public class ContainerBundleContents
    {
        public List<ContainerBase> Bundles = new List<ContainerBase>();
        public List<ContainerBase> Container = new List<ContainerBase>();
        public List<ContainerBase> Currencies = new List<ContainerBase>();
        public List<ContainerBase> Droptable = new List<ContainerBase>();
        public List<ContainerBase> Items = new List<ContainerBase>();
    }

}