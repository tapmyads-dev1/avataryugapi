using System;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using System.Threading.Tasks;
namespace Tapmyads.AvatarYug
{
    public class FileDownloder
    {
        public static void GetByteData(string url, Action<byte[]> _result, Action<Exception> _error, Action<DownloadProgressChangedEventArgs> downloadProgress = null)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadProgressChanged += (s, p) => { downloadProgress?.Invoke(p); };
                webClient.DownloadDataCompleted += (s, e) => { _result?.Invoke(e.Result); };
                webClient.DownloadDataAsync(new Uri(url));
            }
            catch (Exception ex)
            {
                _error?.Invoke(ex);
            }
        }


        public static async void GetNetworkTexture(string url, Action<Texture2D> _result, Action<Exception> _error)
        {

            try
            {
                UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
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
    }
}