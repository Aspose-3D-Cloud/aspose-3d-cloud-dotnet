using Aspose.ThreeD.Cloud.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.ThreeD.Cloud.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "C# REST API to Perform 3D Modeling, Conversion (in the Cloud)";
			ViewBag.MetaDescription = "spose.3D Cloud for cURL helps developers use easy cURL commands to create &amp; process 3D models, objects and 3D entities (3D Box, 3D Cylinder, 3D Sphere, 3D Torus, 3D Plane) in the cloud. Perform parametric modeling of 3D objects. Extract 3D contents from a 3D PDF file. Use cURL to convert 3D objects to supports formats in the cloud.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
