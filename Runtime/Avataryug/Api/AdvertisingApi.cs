using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdvertisingApi
    {
        /// <summary>
        /// Get Rewarded Ad Placements Returns a list of ad placements and a reward for each
        /// </summary>
        /// <param name="appID">The current AppID to use</param>
        /// <returns>GetRewardedAdPlacementsResult</returns>
        void GetAdsPlacement(string appID, Action<GetRewardedAdPlacementsResult> result, Action<ApiException> error);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AdvertisingApi : IAdvertisingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertisingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AdvertisingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertisingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdvertisingApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Get Rewarded Ad Placements Returns a list of ad placements and a reward for each
        /// </summary>
        /// <param name="appID">The current AppID to use</param>
        /// <returns>GetRewardedAdPlacementsResult</returns>
        public async void GetAdsPlacement(string appID, Action<GetRewardedAdPlacementsResult> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }

            // verify the required parameter 'appID' is set
            if (appID == null) throw new ApiException(400, "Missing required parameter 'appID' when calling GetAdsPlacement");


            var path = "/GetAdsPlacement";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (appID != null) queryParams.Add("AppID", ApiClient.ParameterToString(appID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetRewardedAdPlacements: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetRewardedAdPlacements: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }
            result?.Invoke((GetRewardedAdPlacementsResult)ApiClient.Deserialize(response.Content, typeof(GetRewardedAdPlacementsResult), response.Headers));
        }

    }
}
