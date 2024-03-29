using Aspose.ThreeD.Cloud.Live.Demos.UI.Models.Common;
using Aspose.ThreeD.Cloud.Live.Demos.UI.Models;
using Aspose.ThreeD.Cloud.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;

namespace Aspose.ThreeD.Cloud.Live.Demos.UI.Controllers
{
	public class ConversionController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];
		
		[HttpPost]
		public Response Conversion(string outputType)
		{
			Response response = null;
			var files = Request.Files;

			foreach (string fileName in Request.Files)
			{
				HttpPostedFileBase postedFile = Request.Files[fileName];

				if (postedFile != null)
				{
					var isFileUploaded = FileManager.UploadFile(postedFile);

					if ((isFileUploaded != null) && (isFileUploaded.FileName.Trim() != ""))
					{
						AsposeThreeDConversion asposeThreeDConversion = new AsposeThreeDConversion();
							 response = asposeThreeDConversion.Convert(isFileUploaded.FileName,  outputType.ToLower().Replace(" ", ""));

						if (response == null)
						{
							throw new Exception(Resources["ResponseTime"]);
						}				

					}
				}

			}

			return response;			
				
		}		

		public ActionResult Conversion()
		{
			var model = new ViewModel(this, "Conversion")
			{
				SaveAsComponent = true,
				SaveAsOriginal = false,
				MaximumUploadFiles = 1
			};

			return View(model);
		}
		

	}
}
