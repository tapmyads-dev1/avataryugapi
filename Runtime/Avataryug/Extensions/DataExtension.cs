using System;
using System.Net;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.Networking;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;
using System.Collections.Generic;

namespace Tapmyads.AvatarYug
{
    [System.Serializable]
    public class ClipThumbnailUrl
    {
        public int device;
        public int texture_size;
        public string thumbnail_url;
    }
    [System.Serializable]
    public class ClipThumbnailUrls
    {
        public List<ClipThumbnailUrl> itemThumbnails = new List<ClipThumbnailUrl>();
    }
    [System.Serializable]
    public class ExpThumbnailUrl
    {
        public int device;
        public int textureLODSize;
        public string thumbnail_url;
        public bool selected;
    }
    [System.Serializable]
    public class ClipArtifact
    {
        public int device;
        public int format;
        public int characterpose;
        public string lod;
        public int normals;
        public string mesh_url;
        public bool selected;
    }
    [System.Serializable]
    public class ClipArtifacts
    {
        public List<ClipArtifact> artifacts = new List<ClipArtifact>();
    }
    [System.Serializable]
    public class ExpThumbnailUrls
    {
        public List<ExpThumbnailUrl> itemThumbnails = new List<ExpThumbnailUrl>();
    }
    [System.Serializable]
    public class EconomyItems
    {
        public string ID;
        public string TemplateID;
        public string ItemCategory;
        public string ItemSubCategory;
        public string DisplayName;
        public string Description;

        public string CustomMetaData;
        public string Style;

        public string Artifacts;

        public string ItemSkin;

        public string CoreBucket;

        public string OccupiedBuckets;
        public string Blendshapes;
        public string MeshData;
        public string BonesPhysics;
        public string BoneAdjustments;

        public int ItemGender;
        public int IsStackable;
        public int IsLimitedEdition;
        public int LimitedEditionIntialCount;
        public int Status;
        public int RealCurrency;
        public ConflictingBuckets ConflictingBuckets = new ConflictingBuckets();
        public Configs Config = new Configs();
        public Entitlements Entitlement = new Entitlements();
        public ItemThumbUrls ItemThumbnailsUrl = new ItemThumbUrls();
        public VirtualCurrencysResult VirtualCurrency = new VirtualCurrencysResult();
        public Tags tags = new Tags();
        public BlendShapes BlendshapeKeys = new BlendShapes();
    }
    public static class ExtensionMethods
    {
        public static float Remap(this float value, float from1, float to1, float from2, float to2)
        {
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }
        public static ContainerSetting GetContainerSetting(this GetEconomyContainersResultDataInner result)
        {
            return JsonUtility.FromJson<ContainerSetting>(result.ContainerSettings);
        }
        public static LinkedAcounts GetLinkedAcounts(this LoginWithAndroidDeviceIDResultData result)
        {
            return JsonUtility.FromJson<LinkedAcounts>("{" + "\"linkedAcounts\":" + result.LinkedAccounts + "}");
        }
        public static LinkedAcounts GetLinkedAcounts(this RegisterUserResponseData result)
        {
            return JsonUtility.FromJson<LinkedAcounts>("{" + "\"linkedAcounts\":" + result.LinkedAccounts + "}");
        }
        public static ContainerBundleContents GetContainerContents(this GetEconomyContainersResultDataInner result)
        {
            return JsonUtility.FromJson<ContainerBundleContents>(result.ContainerContents);
        }
        public static ContainerBundleContents GetContainerContents(this GetEconomyContainerByIDResult result)
        {
            return JsonUtility.FromJson<ContainerBundleContents>(result.Data.ContainerContents);
        }
        public static ContainerBundleContents GetContainerContents(this GetEconomyContainerByIDResultData result)
        {
            return JsonUtility.FromJson<ContainerBundleContents>(result.ContainerContents);
        }
        public static ContainerBundleContents GetItemContents(this GetEconomyContainerByIDResultData result)
        {
            return JsonUtility.FromJson<ContainerBundleContents>(result.ContainerContents);
        }

        public static ContainerBundleContents GetBunldeContents(this GetEconomyBundlesResultDataInner result)
        {
            return JsonUtility.FromJson<ContainerBundleContents>(result.BundleContents);
        }

        public static Wallets GetWallets(this GetUserAccountInfoResultData result)
        {
            return JsonUtility.FromJson<Wallets>("{" + "\"wallets\":" + result.Wallet + "}");
        }
        public static ContainerBundleContents GetBunldeContents(this GetEconomyBundleByIDResultData result)
        {
            return JsonUtility.FromJson<ContainerBundleContents>(result.BundleContents);
        }
        public static VirtualCurrencyReward GetContainerVirtualCurrency(this GetEconomyContainersResultDataInner result)
        {
            return JsonUtility.FromJson<VirtualCurrencyReward>("{" + "\"currencyRewards\":" + result.VirtualCurrency + "}");
        }
        public static VirtualCurrencyReward GetContainerVirtualCurrency(this GetEconomyBundleByIDResultData result)
        {
            return JsonUtility.FromJson<VirtualCurrencyReward>("{" + "\"currencyRewards\":" + result.VirtualCurrency + "}");
        }
        public static VirtualCurrencyReward GetContainerVirtualCurrency(this GetAvatarPresetsResultDataInner result)
        {
            return JsonUtility.FromJson<VirtualCurrencyReward>("{" + "\"currencyRewards\":" + result.VirtualCurrency + "}");
        }

        //public static async void GetThumbnailTexture(this AvatarPresetArtifact result, Action<Texture2D> _result, Action<Exception> _error)
        //{
        //    try
        //    {
        //        UnityWebRequest www = UnityWebRequestTexture.GetTexture(result.thumbnail_url);
        //        var operation = www.SendWebRequest();
        //        while (!operation.isDone)
        //        {
        //            await Task.Yield();
        //        }
        //        if (www.result != UnityWebRequest.Result.Success)
        //            Debug.LogError($"Failed: {www.error}");

        //        var texResult = DownloadHandlerTexture.GetContent(www);
        //        _result.Invoke(texResult);
        //    }
        //    catch (Exception ex)
        //    {
        //        _error?.Invoke(ex);
        //    }
        //}

        public static RewaredAdsRewards GetRewaredAdsRewards(this GetRewardedAdPlacementsResultData result)
        {
            return JsonUtility.FromJson<RewaredAdsRewards>("{" + "\"rewards\":" + result.Rewards + "}");
        }
        //public static MetaConfig GetMetaConfig(this AvatarPresetArtifact result)
        //{
        //    return JsonUtility.FromJson<MetaConfig>(result.meta);
        //}
        public static PropColors GetPropColor(this GetAvatarPresetsResultDataInner result)
        {
            return JsonUtility.FromJson<PropColors>(result.Color);
        }
        public static Props GetPropsD(this GetAvatarPresetsResultDataInner result)
        {
            return JsonUtility.FromJson<Props>("{" + "\"props\":" + JsonConvert.DeserializeObject(result.Props) + "}");
        }
        public static Props GetProps(this GetAvatarPresetsResultDataInner result)
        {
            return JsonUtility.FromJson<Props>("{" + "\"props\":" + result.Props + "}");
        }
        public static AvatarPresetArtifacts GetAvatarPresetArtifacts(this GetAvatarPresetsResultDataInner result)
        {
            return JsonUtility.FromJson<AvatarPresetArtifacts>("{" + "\"artifacts\":" + JsonConvert.DeserializeObject(result.Artifacts) + "}");
            // return JsonUtility.FromJson<AvatarPresetArtifacts>("{" + "\"artifacts\":" + result.Artifacts + "}");
        }
        public static ItemThumbnailsUrls GetItemThumbnailsUrls(this GetAvatarPresetsResultDataInner result)
        {
            return JsonUtility.FromJson<ItemThumbnailsUrls>("{" + "\"itemThumbnails\":" + JsonConvert.DeserializeObject(result.ItemThumbnailsUrl) + "}");
        }

        public static ItemThumbUrls GetItemThumbnUrls(this GetEconomyItemsByIDResult result)
        {
            return JsonUtility.FromJson<ItemThumbUrls>("{" + "\"itemThumbnails\":" + JsonConvert.DeserializeObject(result.Data.ItemThumbnailsUrl) + "}");
        }

        public static ExpThumbnailUrls GetExpThumbnailUrls(this GetExpressionsResponseDataInner result)
        {
            return JsonUtility.FromJson<ExpThumbnailUrls>("{" + "\"itemThumbnails\":" + JsonConvert.DeserializeObject(result.ThumbnailsUrl) + "}");
        }
        public static ClipArtifacts GetClipArtifacts(this GetClipsResponseDataInner result)
        {
            return JsonUtility.FromJson<ClipArtifacts>("{" + "\"artifacts\":" + JsonConvert.DeserializeObject(result.Artifacts) + "}");
        }

        public static ClipThumbnailUrls GetClipThumbnailUrls(this GetClipsResponseDataInner result)
        {
            return JsonUtility.FromJson<ClipThumbnailUrls>("{" + "\"itemThumbnails\":" + JsonConvert.DeserializeObject(result.ThumbnailsUrl) + "}");
        }
        public static BlendShapes GetAvatarPresetBlendShapes(this GetAvatarPresetsResultDataInner result)
        {
            return JsonUtility.FromJson<BlendShapes>("{" + "\"blendShapes\":" + result.BlendshapeKeys + "}");

        }
        public static BlendShapes GetEconomyItemBlendShapes(this GetEconomyItemsResultDataInner result)
        {
            return JsonUtility.FromJson<BlendShapes>("{" + "\"blendShapes\":" + result.BlendshapeKeys + "}");
        }

        public static BlendShapesExp GetBlendShapes(this GetExpressionsResponseDataInner result)
        {
            return JsonUtility.FromJson<BlendShapesExp>("{" + "\"blendShapes\":" + result.BlendshapeKeys + "}");
        }
        public static Configs GetConfig(this GetEconomyItemsResultDataInner result)
        {
            return JsonUtility.FromJson<Configs>(result.Config);
        }
        public static ConflictingBuckets GetConflictingBuckets(this GetEconomyItemsResultDataInner result)
        {
            return JsonUtility.FromJson<ConflictingBuckets>("{" + "\"buckets\":" + result.ConflictingBuckets + "}");
        }

        public static Tags GetTags(this GetAvatarPresetsResultDataInner result)
        {
            return JsonUtility.FromJson<Tags>("{" + "\"tags\":" + result.Tags + "}");
        }
        public static Tags GetTags(this GetEconomyItemsResultDataInner result)
        {
            return JsonUtility.FromJson<Tags>("{" + "\"tags\":" + result.Tags + "}");
        }
        public static ThreeDArtifacts GetThreeDArtifacts(this GetEconomyItemsResultDataInner result)
        {
            return JsonUtility.FromJson<ThreeDArtifacts>("{" + "\"artifacts\":" + result.Artifacts + "}");
        }
        public static ThreeDArtifacts GetThreeDArtifacts(this EconomyItems result)
        {
            return JsonUtility.FromJson<ThreeDArtifacts>("{" + "\"artifacts\":" + result.Artifacts + "}");
        }
        public static TwoDArtifacts GetTwoDArtifacts(this GetEconomyItemsResultDataInner result)
        {
            return JsonUtility.FromJson<TwoDArtifacts>("{" + "\"artifacts\":" + result.Artifacts + "}");
        }
        public static TwoDArtifacts GetTwoDArtifacts(this EconomyItems result)
        {
            return JsonUtility.FromJson<TwoDArtifacts>("{" + "\"artifacts\":" + result.Artifacts + "}");
        }
        public static SkinToneArtifacts GetSkinToneArtifacts(this EconomyItems result)
        {
            return JsonUtility.FromJson<SkinToneArtifacts>("{" + "\"artifacts\":" + result.Artifacts + "}");
        }
        public static CustomMetaDataList GetCustomMetaDataList(this GetEconomyItemsResultDataInner result)
        {
            return JsonUtility.FromJson<CustomMetaDataList>("{" + "\"customMetaData\":" + result.CustomMetaData + "}");
        }
        public static Entitlements GetEntitlement(this GetEconomyItemsResultDataInner result)
        {
            return JsonUtility.FromJson<Entitlements>(result.Entitlement);
        }
        public static VirtualCurrencysResult GetVirtualCurrencys(this GetEconomyBundlesResultDataInner result)
        {
            return JsonUtility.FromJson<VirtualCurrencysResult>("{" + "\"virtualCurrencys\":" + result.VirtualCurrency + "}");
        }

        public static VirtualCurrencysResult GetVirtualCurrencys(this GetEconomyItemsResultDataInner result)
        {
            return JsonUtility.FromJson<VirtualCurrencysResult>("{" + "\"virtualCurrencys\":" + result.VirtualCurrency + "}");
        }

        public static ItemThumbUrls GetItemThumbnailsUrls(this GetEconomyItemsResultDataInner result)
        {
            return JsonUtility.FromJson<ItemThumbUrls>("{" + "\"itemThumbnails\":" + result.ItemThumbnailsUrl + "}");
        }

        public static void GetByteData(this AvatarPresetArtifact artifact, Action<byte[]> _result, Action<Exception> _error)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadDataCompleted += (s, e) => { _result?.Invoke(e.Result); };
                webClient.Headers.Add("Content-Type", "application/json");
                webClient.DownloadDataAsync(new Uri(artifact.mesh_url));
            }
            catch (Exception ex)
            {
                _error?.Invoke(ex);
            }
        }
        public static void GetByteData(this ThreeDArtifact artifact, Action<byte[]> _result, Action<Exception> _error)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadDataCompleted += (s, e) => { _result?.Invoke(e.Result); };
                webClient.Headers.Add("Content-Type", "application/json");
                webClient.DownloadDataAsync(new Uri(artifact.mesh_url));
            }
            catch (Exception ex)
            {
                _error?.Invoke(ex);
            }
        }

        public static async void GetThumbnailTexture(this GetEconomyContainersResultDataInner result, Action<Texture2D> _result, Action<Exception> _error)
        {

            try
            {
                UnityWebRequest www = UnityWebRequestTexture.GetTexture(result.ContainerImageUrl);
                var operation = www.SendWebRequest();
                while (!operation.isDone)
                {
                    await Task.Yield();
                }
                if (www.result != UnityWebRequest.Result.Success)
                    Debug.LogError($"Failed: {www.error}");

                var texResult = DownloadHandlerTexture.GetContent(www);
                _result.Invoke(texResult);
            }
            catch (Exception ex)
            {
                _error?.Invoke(ex);
            }
        }
        public static async void GetThumbnailTexture(this ItemThumUrl result, Action<Texture2D> _result, Action<Exception> _error, Action<float> progress)
        {

            try
            {
                UnityWebRequest www = UnityWebRequestTexture.GetTexture(result.thumbnail_url);
                var operation = www.SendWebRequest();
                while (!operation.isDone)
                {
                    progress?.Invoke(operation.progress);
                    await Task.Yield();
                }
                if (www.result != UnityWebRequest.Result.Success)
                    Debug.LogError($"Failed: {www.error}");

                var texResult = DownloadHandlerTexture.GetContent(www);
                _result.Invoke(texResult);
                progress?.Invoke(operation.progress);
            }
            catch (Exception ex)
            {
                _error?.Invoke(ex);
            }
        }
        public static async void GetThumbnailTexture(this ItemThumbnailsUrl result, Action<Texture2D> _result, Action<Exception> _error)
        {
            Debug.Log(result.thumbnail_url);
            try
            {
                UnityWebRequest www = UnityWebRequestTexture.GetTexture(result.thumbnail_url);
                var operation = www.SendWebRequest();
                while (!operation.isDone)
                {
                    await Task.Yield();
                }
                if (www.result != UnityWebRequest.Result.Success)
                    Debug.LogError($"Failed: {www.error}");

                var texResult = DownloadHandlerTexture.GetContent(www);
                _result.Invoke(texResult);
            }
            catch (Exception ex)
            {
                _error?.Invoke(ex);
            }
        }

        public static Meta GetMeta(this ItemThumbnailsUrl result)
        {
            return JsonUtility.FromJson<Meta>(result.meta);
        }

        public static Platfroms GetPlatfrom(this ItemThumbnailsUrl result)
        {
            return (Platfroms)result.device;
        }
        public static Platfroms GetPlatfrom(this ThreeDArtifact result)
        {
            return (Platfroms)result.device;
        }
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}