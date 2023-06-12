using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        /// <summary>
        /// Update Default AvatarID
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateDefaultAvatarIDRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UpdateDefaultAvatarIDResult</returns>
        void UpdateDefaultAvatarID(UpdateDefaultAvatarIDRequest updateDefaultAvatarIDRequest, Action<UpdateDefaultAvatarIDResult> result, Action<ApiException> error);
        /// <summary>
        /// Sync Avatars
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="syncAvatarsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SyncAvatarsResult</returns>
        void SyncAvatars(SyncAvatarsRequest syncAvatarsRequest, Action<string> result, Action<ApiException> error);
        /// <summary>
        /// Delete User  Delete the user User 
        /// </summary>
        /// <returns>DeleteUserResponse</returns>
        void DeleteUser(DeleteUserRequest deleteUserRequest, Action<DeleteUserResponse> result, Action<ApiException> error);
        /// <summary>
        /// Generate Avatar Generate Avatar for the user
        /// </summary>
        /// <param name="generateAvatarRequest"></param>
        /// <returns>GenerateAvatarResult</returns>
        void GenerateAvatar(GenerateAvatarRequest generateAvatarRequest, Action<GenerateAvatarResult> result, Action<ApiException> error);
        /// <summary>
        /// Generate Avatar Mesh This will generated 3D mesh of the Avatar
        /// </summary>
        /// <param name="generateAvatarMeshRequest"></param>
        /// <returns>GenerateAvatarMeshResponse</returns>
        void GenerateAvatarMesh(GenerateAvatarMeshRequest generateAvatarMeshRequest, Action<GenerateAvatarMeshResponse> result, Action<ApiException> error);
        /// <summary>
        /// Get All Bucket Vertices Get vertices for all buckets
        /// </summary>
        /// <param name="platform">Name of the platform. I.e. Unreal, Unity</param>
        /// <returns>GetAllBucketVerticesResult</returns>
        void GetAllBucketVertices(string platform, Action<GetAllBucketVerticesResult> result, Action<ApiException> error);
        /// <summary>
        /// Get Ads Placement 
        /// </summary>
        /// <param name="appID"></param>
        /// <returns>GetAdsPlacementResponse</returns>
        void GetAdsPlacement(string appID, Action<GetAdsPlacementResponse> result, Action<ApiException> error);
        /// <summary>
        /// Record Ads Activity 
        /// </summary>
        /// <param name="recordAdsActivityRequest"></param>
        /// <returns>RecordAdsActivityResponse</returns>
        void RecordAdsActivity(RecordAdsActivityRequest recordAdsActivityRequest, Action<RecordAdsActivityResponse> result, Action<ApiException> error);
        /// <summary>
        /// Grant Ads Reward 
        /// </summary>
        /// <param name="grantAdsRewardRequest"></param>
        /// <returns>GrantAdsRewardResponse</returns>
        void GrantAdsReward(GrantAdsRewardRequest grantAdsRewardRequest, Action<GrantAdsRewardResponse> result, Action<ApiException> error);
        /// <summary>
        /// Update User Demographics 
        /// </summary>
        /// <param name="updateUserDemographicsRequest"></param>
        /// <returns>UpdateUserDemographicsResponse</returns>
        void UpdateUserDemographics(UpdateUserDemographicsRequest updateUserDemographicsRequest, Action<UpdateUserDemographicsResponse> result, Action<ApiException> error);

        /// <summary>
        /// Register User 
        /// </summary>
        /// <param name="registerUserRequest"></param>
        /// <returns>RegisterUserResponse</returns>
        void RegisterUser(RegisterUserRequest registerUserRequest, Action<RegisterUserResponse> result, Action<ApiException> error);

        /// <summary>
        /// Send Account Recovery Email 
        /// </summary>
        /// <param name="sendAccountRecoveryEmailRequset"></param>
        /// <returns>SendAccountRecoveryEmailResponse</returns>
        void SendAccountRecoveryEmail(SendAccountRecoveryEmailRequset sendAccountRecoveryEmailRequset, Action<SendAccountRecoveryEmailResponse> result, Action<ApiException> error);

        /// <summary>
        /// Render Avatar Image 
        /// </summary>
        /// <param name="renderAvatarImageRequest"></param>
        /// <returns>RenderAvatarImageResponse</returns>
        void RenderAvatarImage(RenderAvatarImageRequest renderAvatarImageRequest, Action<RenderAvatarImageResponse> result, Action<ApiException> error);


    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
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

        public async void SyncAvatars(SyncAvatarsRequest syncAvatarsRequest, Action<string> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }



            var path = "/SyncAvatars";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(syncAvatarsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling SyncAvatars: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling SyncAvatars: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }
            result?.Invoke(response.Content);


        }
        /// <summary>
        /// Delete User  Delete the user User 
        /// </summary>
        /// <returns>DeleteUserResponse</returns>
        public async void DeleteUser(DeleteUserRequest deleteUserRequest, Action<DeleteUserResponse> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }



            var path = "/DeleteUser";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(deleteUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling DeleteUser: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling DeleteUser: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }
            result?.Invoke((DeleteUserResponse)ApiClient.Deserialize(response.Content, typeof(DeleteUserResponse), response.Headers));


        }

        /// <summary>
        /// Generate Avatar Generate Avatar for the user
        /// </summary>
        /// <param name="generateAvatarRequest"></param>
        /// <returns>GenerateAvatarResult</returns>
        public void GenerateAvatar(GenerateAvatarRequest generateAvatarRequest, Action<GenerateAvatarResult> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }


            var path = "/GenerateAvatar";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(generateAvatarRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "apiKeyHeader", "apiKeyQuery" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GenerateAvatar: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GenerateAvatar: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }
            result?.Invoke((GenerateAvatarResult)ApiClient.Deserialize(response.Content, typeof(GenerateAvatarResult), response.Headers));
        }
        /// <summary>
        /// Generate Avatar Mesh This will generated 3D mesh of the Avatar
        /// </summary>
        /// <param name="generateAvatarMeshRequest"></param>
        /// <returns>GenerateAvatarMeshResponse</returns>
        public async void GenerateAvatarMesh(GenerateAvatarMeshRequest generateAvatarMeshRequest, Action<GenerateAvatarMeshResponse> result, Action<ApiException> error)
        {


            var path = "/GenerateAvatarMesh";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            postBody = ApiClient.Serialize(generateAvatarMeshRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GenerateAvatarMesh: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GenerateAvatarMesh: " + response.ErrorMessage, response.ErrorMessage));
            }
            result?.Invoke((GenerateAvatarMeshResponse)ApiClient.Deserialize(response.Content, typeof(GenerateAvatarMeshResponse), response.Headers));
        }

        /// <summary>
        /// Get All Bucket Vertices Get vertices for all buckets
        /// </summary>
        /// <param name="platform">Name of the platform. I.e. Unreal, Unity</param>
        /// <returns>GetAllBucketVerticesResult</returns>
        public async void GetAllBucketVertices(string platform, Action<GetAllBucketVerticesResult> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }

            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling GetAllBucketVertices");


            var path = "/GetAllBucketVertices";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (platform != null) queryParams.Add("Platform", ApiClient.ParameterToString(platform)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "apiKeyHeader", "apiKeyQuery" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetAllBucketVertices: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetAllBucketVertices: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }
            //            UnityEngine.Debug.Log("the response-->>" + response.Content);
            result?.Invoke((GetAllBucketVerticesResult)ApiClient.Deserialize(response.Content, typeof(GetAllBucketVerticesResult), response.Headers));
        }

        /// <summary>
        /// Get Ads Placement 
        /// </summary>
        /// <param name="appID"></param>
        /// <returns>GetAdsPlacementResponse</returns>
        public async void GetAdsPlacement(string appID, Action<GetAdsPlacementResponse> result, Action<ApiException> error)
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

            if (appID != null) queryParams.Add("PlacementID", ApiClient.ParameterToString(appID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetAdsPlacement: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetAdsPlacement: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((GetAdsPlacementResponse)ApiClient.Deserialize(response.Content, typeof(GetAdsPlacementResponse), response.Headers));
        }
        /// <summary>
        /// Record Ads Activity 
        /// </summary>
        /// <param name="recordAdsActivityRequest"></param>
        /// <returns>RecordAdsActivityResponse</returns>

        public async void RecordAdsActivity(RecordAdsActivityRequest recordAdsActivityRequest, Action<RecordAdsActivityResponse> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }

            var path = "/RecordAdsActivity";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(recordAdsActivityRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling RecordAdsActivity: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling RecordAdsActivity: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((RecordAdsActivityResponse)ApiClient.Deserialize(response.Content, typeof(RecordAdsActivityResponse), response.Headers));
        }



        /// <summary>
        /// Grant Ads Reward 
        /// </summary>
        /// <param name="grantAdsRewardRequest"></param>
        /// <returns>GrantAdsRewardResponse</returns>
        public async void GrantAdsReward(GrantAdsRewardRequest grantAdsRewardRequest, Action<GrantAdsRewardResponse> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }

            var path = "/GrantAdsReward";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(grantAdsRewardRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GrantAdsReward: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GrantAdsReward: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }
            result?.Invoke((GrantAdsRewardResponse)ApiClient.Deserialize(response.Content, typeof(GrantAdsRewardResponse), response.Headers));
        }

        /// <summary>
        /// Update User Demographics 
        /// </summary>
        /// <param name="updateUserDemographicsRequest"></param>
        /// <returns>UpdateUserDemographicsResponse</returns>
        public async void UpdateUserDemographics(UpdateUserDemographicsRequest updateUserDemographicsRequest, Action<UpdateUserDemographicsResponse> result, Action<ApiException> error)
        {

            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }

            var path = "/UpdateUserDemographics";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(updateUserDemographicsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling UpdateUserDemographics: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling UpdateUserDemographics: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((UpdateUserDemographicsResponse)ApiClient.Deserialize(response.Content, typeof(UpdateUserDemographicsResponse), response.Headers));
        }

        /// <summary>
        /// Register User 
        /// </summary>
        /// <param name="registerUserRequest"></param>
        /// <returns>RegisterUserResponse</returns>
        public async void RegisterUser(RegisterUserRequest registerUserRequest, Action<RegisterUserResponse> result, Action<ApiException> error)
        {


            var path = "/RegisterUser";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(registerUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling RegisterUser: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling RegisterUser: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((RegisterUserResponse)ApiClient.Deserialize(response.Content, typeof(RegisterUserResponse), response.Headers));
        }

        /// <summary>
        /// Send Account Recovery Email 
        /// </summary>
        /// <param name="sendAccountRecoveryEmailRequset"></param>
        /// <returns>SendAccountRecoveryEmailResponse</returns>
        public async void SendAccountRecoveryEmail(SendAccountRecoveryEmailRequset sendAccountRecoveryEmailRequset, Action<SendAccountRecoveryEmailResponse> result, Action<ApiException> error)
        {


            var path = "/SendAccountRecoveryEmail";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(sendAccountRecoveryEmailRequset); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling SendAccountRecoveryEmail: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling SendAccountRecoveryEmail: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }
            result?.Invoke((SendAccountRecoveryEmailResponse)ApiClient.Deserialize(response.Content, typeof(SendAccountRecoveryEmailResponse), response.Headers));
        }

        /// <summary>
        /// Render Avatar Image 
        /// </summary>
        /// <param name="renderAvatarImageRequest"></param>
        /// <returns>RenderAvatarImageResponse</returns>
        public async void RenderAvatarImage(RenderAvatarImageRequest renderAvatarImageRequest, Action<RenderAvatarImageResponse> result, Action<ApiException> error)
        {

            UnityEngine.Debug.Log(renderAvatarImageRequest.ToJson());
            var path = "/RenderAvatarImage";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(renderAvatarImageRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
            UnityEngine.Debug.Log(response.Content);
            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling RenderAvatarImage: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling RenderAvatarImage: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((RenderAvatarImageResponse)ApiClient.Deserialize(response.Content, typeof(RenderAvatarImageResponse), response.Headers));
        }


        public async void UpdateDefaultAvatarID(UpdateDefaultAvatarIDRequest updateDefaultAvatarIDRequest, Action<UpdateDefaultAvatarIDResult> result, Action<ApiException> error)
        {


            var path = "/UpdateDefaultAvatarID";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(updateDefaultAvatarIDRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling UpdateDefaultAvatarID: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling UpdateDefaultAvatarID: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }
            result?.Invoke((UpdateDefaultAvatarIDResult)ApiClient.Deserialize(response.Content, typeof(UpdateDefaultAvatarIDResult), response.Headers));
        }
    }
}