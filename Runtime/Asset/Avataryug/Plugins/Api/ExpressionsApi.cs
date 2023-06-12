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
    public interface IExpressionsApi
    {
        /// <summary>
        /// Get Expression By ID 
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>GetExpressionByIDResponse</returns>
        void GetExpressionByID(string userID, Action<GetExpressionByIDResponse> result, Action<ApiException> error);
        /// <summary>
        /// Get Expressions 
        /// </summary>
        /// <returns>GetExpressionsResponse</returns>
        void GetExpressions(Action<GetExpressionsResponse> result, Action<ApiException> error);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ExpressionsApi : IExpressionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ExpressionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExpressionsApi(String basePath)
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
        /// Get Expression By ID 
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>GetExpressionByIDResponse</returns>
        public async void GetExpressionByID(string userID, Action<GetExpressionByIDResponse> result, Action<ApiException> error)
        {

            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling GetExpressionByID");


            var path = "/GetExpressionByID";
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
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetExpressionByID: " + response.Content, response.Content));
                return;
            }
            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetExpressionByID: " + response.ErrorMessage, response.ErrorMessage));
                return;
            }

            result?.Invoke((GetExpressionByIDResponse)ApiClient.Deserialize(response.Content, typeof(GetExpressionByIDResponse), response.Headers));
        }
        /// <summary>
        /// Get Expressions 
        /// </summary>
        /// <returns>GetExpressionsResponse</returns>
        public async void GetExpressions(Action<GetExpressionsResponse> result, Action<ApiException> error)
        {


            var path = "/GetExpressions";
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
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetExpressions: " + response.Content, response.Content));
                return;
            }

            else if (((int)response.StatusCode) == 0)
            {
                error?.Invoke(new ApiException((int)response.StatusCode, "Error calling GetExpressions: " + response.ErrorMessage, response.ErrorMessage));
            }
            result?.Invoke((GetExpressionsResponse)ApiClient.Deserialize(response.Content, typeof(GetExpressionsResponse), response.Headers));
        }
    }
}
