using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using System.Diagnostics;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserItemManagementApi
    {
        /// <summary>
        /// Add Virtual Currency to User Increments the user&#39;s balance of the specified virtual currency by the stated amount
        /// </summary>
        /// <param name="addVirtualCurrencyToUserRequest"></param>
        /// <returns>AddVirtualCurrencyToUserResult</returns>
        void AddVirtualCurrencyToUser(AddVirtualCurrencyToUserRequest addVirtualCurrencyToUserRequest, Action<AddVirtualCurrencyToUserResult> result, Action<ApiException> error);
        /// <summary>
        /// ConsumeInstance Consume uses of a consumable item. When all uses are consumed, it will be removed from the user&#39;s inventory.
        /// </summary>
        /// <param name="consumeInstanceRequest"></param>
        /// <returns>ConsumeInstanceResult</returns>
        void ConsumeInstance(ConsumeInstanceRequest consumeInstanceRequest, Action<ConsumeInstanceResult> result, Action<ApiException> error);
        /// <summary>
        /// Get User Inventory Retrieves the user&#39;s current inventory of virtual goods
        /// </summary>
        /// <param name="userID">Unique AvatarYug identifier of the user whose info is being requested. Optional, defaults to the authenticated user if no other lookup identifier set.</param>
        /// <returns>GetUserInventoryResult</returns>
        void GetUserInventory(string userID, Action<GetUserInventoryResult> result, Action<ApiException> error);
        /// <summary>
        /// Grant Items To User Adds the specified items to the specified user&#39;s inventory
        /// </summary>
        /// <param name="grantInstanceToUserRequest"></param>
        /// <returns>GrantInstanceToUserResult</returns>
        void GrantInstanceToUser(GrantInstanceToUserRequest grantInstanceToUserRequest, Action<GrantInstanceToUserResult> result, Action<ApiException> error);
        /// <summary>
        /// Purchase Instance Buys a single item with virtual currency. You must specify both the virtual currency to use to purchase, as well as what the client believes the price to be. This lets the server fail the purchase if the price has changed.
        /// </summary>
        /// <param name="purchaseInstanceRequest"></param>
        /// <returns></returns>
        void PurchaseInstance(PurchaseInstanceRequest purchaseInstanceRequest, Action<object> result, Action<ApiException> error);
        /// <summary>
        /// Subtract User Virtual Currency Decrements the user&#39;s balance of the specified virtual currency by the stated amount. It is possible to make a VC balance negative with this API.
        /// </summary>
        /// <param name="subtractUserVirtualCurrencyRequest"></param>
        /// <returns></returns>
        void SubtractUserVirtualCurrency(SubtractUserVirtualCurrencyRequest subtractUserVirtualCurrencyRequest, Action result, Action<ApiException> error);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserItemManagementApi : IUserItemManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserItemManagementApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserItemManagementApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserItemManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserItemManagementApi(String basePath)
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
        /// Add Virtual Currency to User Increments the user&#39;s balance of the specified virtual currency by the stated amount
        /// </summary>
        /// <param name="addVirtualCurrencyToUserRequest"></param>
        /// <returns>AddVirtualCurrencyToUserResult</returns>
        public async void AddVirtualCurrencyToUser(AddVirtualCurrencyToUserRequest addVirtualCurrencyToUserRequest, Action<AddVirtualCurrencyToUserResult> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }


            var path = "/AddVirtualCurrencyToUser";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(addVirtualCurrencyToUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling AddVirtualCurrencyToUser: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling AddVirtualCurrencyToUser: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((AddVirtualCurrencyToUserResult)ApiClient.Deserialize(response.Content, typeof(AddVirtualCurrencyToUserResult), response.Headers));
        }

        /// <summary>
        /// ConsumeInstance Consume uses of a consumable item. When all uses are consumed, it will be removed from the user&#39;s inventory.
        /// </summary>
        /// <param name="consumeInstanceRequest"></param>
        /// <returns>ConsumeInstanceResult</returns>
        public async void ConsumeInstance(ConsumeInstanceRequest consumeInstanceRequest, Action<ConsumeInstanceResult> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }


            var path = "/ConsumeInstance";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(consumeInstanceRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling ConsumeInstance: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling ConsumeInstance: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((ConsumeInstanceResult)ApiClient.Deserialize(response.Content, typeof(ConsumeInstanceResult), response.Headers));
        }

        /// <summary>
        /// Get User Inventory Retrieves the user&#39;s current inventory of virtual goods
        /// </summary>
        /// <param name="userID">Unique AvatarYug identifier of the user whose info is being requested. Optional, defaults to the authenticated user if no other lookup identifier set.</param>
        /// <returns>GetUserInventoryResult</returns>
        public async void GetUserInventory(string userID, Action<GetUserInventoryResult> result, Action<ApiException> error)
        {

            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }

            var path = "/GetUserInventory";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (userID != null) queryParams.Add("UserID", ApiClient.ParameterToString(userID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetUserInventory: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetUserInventory: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }
            result?.Invoke((GetUserInventoryResult)ApiClient.Deserialize(response.Content, typeof(GetUserInventoryResult), response.Headers));
        }

        /// <summary>
        /// Grant Items To User Adds the specified items to the specified user&#39;s inventory
        /// </summary>
        /// <param name="grantInstanceToUserRequest"></param>
        /// <returns>GrantInstanceToUserResult</returns>
        public async void GrantInstanceToUser(GrantInstanceToUserRequest grantInstanceToUserRequest, Action<GrantInstanceToUserResult> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }

            UnityEngine.Debug.Log(grantInstanceToUserRequest.ToJson());
            var path = "/GrantInstanceToUser";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(grantInstanceToUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GrantInstanceToUser: " + response.Content, response.Content));
                return;
            }

            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GrantInstanceToUser: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((GrantInstanceToUserResult)ApiClient.Deserialize(response.Content, typeof(GrantInstanceToUserResult), response.Headers));
        }

        /// <summary>
        /// Purchase Instance Buys a single item with virtual currency. You must specify both the virtual currency to use to purchase, as well as what the client believes the price to be. This lets the server fail the purchase if the price has changed.
        /// </summary>
        /// <param name="purchaseInstanceRequest"></param>
        /// <returns></returns>
        public async void PurchaseInstance(PurchaseInstanceRequest purchaseInstanceRequest, Action<object> result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }


            var path = "/PurchaseInstance";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(purchaseInstanceRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling PurchaseInstance: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling PurchaseInstance: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke(response.Content);



        }

        /// <summary>
        /// Subtract User Virtual Currency Decrements the user&#39;s balance of the specified virtual currency by the stated amount. It is possible to make a VC balance negative with this API.
        /// </summary>
        /// <param name="subtractUserVirtualCurrencyRequest"></param>
        /// <returns></returns>
        public async void SubtractUserVirtualCurrency(SubtractUserVirtualCurrencyRequest subtractUserVirtualCurrencyRequest, Action result, Action<ApiException> error)
        {
            if (!Configuration.ProjectIdPresent)
            {
                UnityEngine.Debug.LogError("ProjectId is not present");
                return;
            }


            var path = "/SubtractUserVirtualCurrency";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(subtractUserVirtualCurrencyRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)await ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling SubtractUserVirtualCurrency: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling SubtractUserVirtualCurrency: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke();

        }

    }
}
