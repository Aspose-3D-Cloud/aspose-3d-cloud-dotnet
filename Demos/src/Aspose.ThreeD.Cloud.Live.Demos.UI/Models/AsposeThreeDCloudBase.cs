using System;
using System.IO;
using System.Web.Http;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Drawing;
using System.Drawing.Imaging;
using Aspose.ThreeD.Cloud.SDK.Api;

namespace  Aspose.ThreeD.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeThreeDCloudBase class to have base methods
	///</Summary>

	public abstract class AsposeThreeDCloudBase : ApiController
    {
		protected ThreeDCloudApi threeDCloudApi = new ThreeDCloudApi(Config.Configuration.GrantType, Config.Configuration.AppSID, Config.Configuration.AppKey);
		///<Summary>
		/// Get File extension
		///</Summary>
		protected string GetoutFileExtension(string fileName, string folderName)
        {
			string sourceFolder = Config.Configuration.WorkingDirectory + folderName;
            fileName = sourceFolder + "\\" + fileName;
            return Path.GetExtension(fileName);
        }
		
       
		
    }
}
