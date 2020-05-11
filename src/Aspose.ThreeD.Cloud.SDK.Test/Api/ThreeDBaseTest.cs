
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
        protected string clientId = "****your appsid****";
        protected string clientSecret = "****your appkey****";
        protected string storageType = "First Storage";
        protected static string accesstoken;
        protected ThreeDCloudApi threeDCloudApi;
        protected OAuthApi oauthApi;
        public ThreeDBaseTest()
        {
            threeDCloudApi = new ThreeDCloudApi(grantType, clientId, clientSecret);
            oauthApi = new OAuthApi(grantType, clientId, clientSecret);
        }
    }
}
