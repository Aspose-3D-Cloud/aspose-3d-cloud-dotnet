
namespace Aspose.ThreeD.Cloud.SDK.Test
{
    using NUnit.Framework;
    using Aspose.ThreeD.Cloud.SDK.Client;
    using Aspose.ThreeD.Cloud.SDK.Api;
    using Aspose.ThreeD.Cloud.SDK.Model;
    using System.IO;
    using System.Collections.Generic;
    public class ThreeDBaseTest
    {
        protected ApiClient client;
        protected Configuration config;
        protected static OAuthApi oauth2 = null;
        protected string grantType = "client_credentials";
        /**************************************
        Use the appsid(clientId) and appkey(clientSecret) of yourself
        ***************************************/
        protected string clientId = "xxxxxx";
        protected string clientSecret = "yyyyyyyy";
        protected string storageType = "First Storage";
        protected static string accesstoken;

        protected FileApi fileApi;
        protected FolderApi folderApi;
        protected StorageApi storageApi;
        protected ThreeDCloudApi threeDCloudApi;
        protected OAuthApi oauthApi;

        public ThreeDBaseTest()
        {
            fileApi = new FileApi(grantType, clientId, clientSecret);
            folderApi = new FolderApi(grantType, clientId, clientSecret);
            storageApi = new StorageApi(grantType, clientId, clientSecret);
            threeDCloudApi = new ThreeDCloudApi(grantType, clientId, clientSecret);
            oauthApi = new OAuthApi(grantType, clientId, clientSecret);
        }
#if  OldWay
         //old way
         {
             if (oauth2 == null)
             {
                 oauth2 = new OAuthApi("https://api.aspose.cloud");
                 var oauth2response = oauth2.OAuthPost(grantType, clientId, clientSecret);
                 accesstoken = oauth2response.AccessToken;
                 if (accesstoken == null)
                     throw new ApiException(401, "Get accesstoken failed!");
                 refreshtoken = oauth2response.RefreshToken;
             }
             Dictionary<string, string> headerParameters = new Dictionary<string, string>();
             headerParameters.Add("Authorization", "Bearer " + accesstoken);
             client = new ApiClient();
             if (this.GetType().Name == "OAuthApiTests")
             {
                 //if dontdo this the RestClient is https://api.aspose.cloud/v3.0/
                 //this will return error 
                 client.RestClient = new RestSharp.RestClient("https://api.aspose.cloud/");
             }
             config = new Configuration(client, headerParameters);
             return config;
         }
#endif
    }
}
