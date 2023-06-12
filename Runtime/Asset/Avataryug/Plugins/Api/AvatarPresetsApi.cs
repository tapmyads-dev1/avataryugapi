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
    public interface IAvatarPresetsApi
    {
        /// <summary>
        /// Get Avatar Presets Get all avatar presets
        /// </summary>
        /// <returns>GetAvatarPresetsResult</returns>
        void GetAvatarPresets(Action<GetAvatarPresetsResult> result, Action<ApiException> error);
        /// <summary>
        /// Get AvatarPresets By ID Retrive Avatar preset by ID
        /// </summary>
        /// <param name="avatarPresetID">Unique Identifier for the Avatar Preset which is being requested</param>
        /// <returns>GetAvatarPresetByID200</returns>
        void GetAvatarPresetsByID(string avatarPresetID, Action<GetAvatarPresetByID200> result, Action<ApiException> error);
        /// <summary>
        /// Grant AvatarPreset To User Grants the specified Avatar to the user
        /// </summary>
        /// <param name="grantAvatarToUserRequest"></param>
        /// <returns>GrantAvatarToUserResult</returns>
        void GrantAvatarPresetToUser(GrantAvatarToUserRequest grantAvatarToUserRequest, Action<GrantAvatarToUserResponse> result, Action<ApiException> error);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grantAvatarPresetItemsToUserRequest"></param>
        /// <param name="result"></param>
        /// <param name="error"></param>
        void GrantAvatarPresetItemsToUser(GrantAvatarPresetItemsToUserRequest grantAvatarPresetItemsToUserRequest, Action<GrantAvatarPresetItemsToUserResponse> result, Action<ApiException> error);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AvatarPresetsApi : IAvatarPresetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarPresetsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AvatarPresetsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarPresetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AvatarPresetsApi(String basePath)
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
        /// Get Avatar Presets Get all avatar presets
        /// </summary>
        /// <returns>GetAvatarPresetsResult</returns>
        public async void GetAvatarPresets(Action<GetAvatarPresetsResult> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }


            var path = "/GetAvatarPresets";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetAvatarPresets: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetAvatarPresets: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((GetAvatarPresetsResult)ApiClient.Deserialize(response.Content, typeof(GetAvatarPresetsResult), response.Headers));
        }

        /// <summary>
        /// Get AvatarPresets By ID Retrive Avatar preset by ID
        /// </summary>
        /// <param name="avatarPresetID">Unique Identifier for the Avatar Preset which is being requested</param>
        /// <returns>GetAvatarPresetByID200</returns>
        public async void GetAvatarPresetsByID(string avatarPresetID, Action<GetAvatarPresetByID200> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }

            // verify the required parameter 'avatarPresetID' is set
            if (avatarPresetID == null) throw new ApiException(400, "Missing required parameter 'avatarPresetID' when calling GetAvatarPresetsByID");


            var path = "/GetAvatarPresetsByID";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (avatarPresetID != null) queryParams.Add("AvatarPresetID", ApiClient.ParameterToString(avatarPresetID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetAvatarPresetsByID: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetAvatarPresetsByID: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((GetAvatarPresetByID200)ApiClient.Deserialize(response.Content, typeof(GetAvatarPresetByID200), response.Headers));
        }

        /// <summary>
        /// Grant AvatarPreset To User Grants the specified Avatar to the user
        /// </summary>
        /// <param name="grantAvatarToUserRequest"></param>
        /// <returns>GrantAvatarToUserResult</returns>
        public async void GrantAvatarPresetToUser(GrantAvatarToUserRequest grantAvatarToUserRequest, Action<GrantAvatarToUserResponse> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }


            var path = "/GrantAvatarPresetToUser";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(grantAvatarToUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GrantAvatarToUser: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GrantAvatarToUser: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((GrantAvatarToUserResponse)ApiClient.Deserialize(response.Content, typeof(GrantAvatarToUserResponse), response.Headers));
        }

        /// <summary>
        /// Grant Avatar Preset Items To User 
        /// </summary>
        /// <param name="grantAvatarPresetItemsToUserRequest">Request payload</param>
        /// <returns>GrantAvatarPresetItemsToUserResponse</returns>

        public async void GrantAvatarPresetItemsToUser(GrantAvatarPresetItemsToUserRequest grantAvatarPresetItemsToUserRequest, Action<GrantAvatarPresetItemsToUserResponse> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }


            var path = "/GrantAvatarPresetItemsToUser";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(grantAvatarPresetItemsToUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error.Invoke(new ApiException((int)response.StatusCode, "Error calling GrantAvatarPresetItemsToUser: " + response.Content,
response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error.Invoke(new ApiException((int)response.StatusCode, "Error calling GrantAvatarPresetItemsToUser: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }
            result.Invoke((GrantAvatarPresetItemsToUserResponse)ApiClient.Deserialize(response.Content, typeof(GrantAvatarPresetItemsToUserResponse), response.Headers));
        }
    }
}

