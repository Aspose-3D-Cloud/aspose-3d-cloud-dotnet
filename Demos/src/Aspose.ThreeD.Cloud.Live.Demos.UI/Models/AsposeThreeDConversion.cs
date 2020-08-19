using System.Threading.Tasks;
using System.IO;
using System.Web.Http;
using Aspose.ThreeD.Cloud.Live.Demos.UI.Models;
using System.Diagnostics;
using Aspose.ThreeD.Cloud.SDK.Model;
using Aspose.ThreeD.Cloud.SDK.Api;
using Aspose.ThreeD.Cloud.SDK.Client;

namespace Aspose.ThreeD.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// Aspose.3D Cloud API convert method to convert word document file to other format
	///</Summary>
	
	public class AsposeThreeDConversion : AsposeThreeDCloudBase
    {        
        
		///<Summary>
		/// Convert method to convert file to other format
		///</Summary>
		public Response Convert(string fileName,  string outputType)
        {
			string fileNamewithOutExtension = Path.GetFileNameWithoutExtension(fileName);
			string outputFileName = fileNamewithOutExtension + "." + outputType;
			bool foundSaveOption = true;
			SaveOptions saveOptions = new SaveOptions();
			

			switch (outputType)
			{
				case "fbx":
					//saveOptions = new FBXSaveOption();
					saveOptions.SaveFormat = SaveFormat.FBX;
					break;
				case "obj":
					//saveOptions = new ObjSaveOption();
					saveOptions.SaveFormat = SaveFormat.Obj;
					break;
				case "pdf":
					//saveOptions = new PdfSaveOption();
					saveOptions.SaveFormat = SaveFormat.PDF;
					break;
				case "drc":
					//saveOptions = new DracoSaveOption();
					saveOptions.SaveFormat = SaveFormat.Draco;
					break;
				case "amf":
					//saveOptions = new AMFSaveOption();
					saveOptions.SaveFormat = SaveFormat.AMF;
					break;
				case "rvm":
					//saveOptions = new RvmSaveOption();
					saveOptions.SaveFormat = SaveFormat.Rvm;
					break;
				case "dae":
					//saveOptions = new ColladaSaveOption();
					saveOptions.SaveFormat = SaveFormat.Collada;
					break;
				case "dxf":
					//saveOptions = new ColladaSaveOption();
					saveOptions.SaveFormat = SaveFormat.Collada;
					break;
				case "gltf":
					//saveOptions = new GLTFSaveOption();	
					saveOptions.SaveFormat = SaveFormat.GLTF;
					break;
				case "glb":
					//saveOptions = new GLTFSaveOption();
					saveOptions.SaveFormat = SaveFormat.GLTF;
					break;				
				case "ply":
					//saveOptions = new PlySaveOption();
					saveOptions.SaveFormat = SaveFormat.PLY;
					break;
				case "stl":
					//saveOptions = new STLSaveOption();
					saveOptions.SaveFormat = SaveFormat.STL;
					break;
				case "u3d":
					//saveOptions = new U3DSaveOption();
					saveOptions.SaveFormat = SaveFormat.U3D;
					break;
				case "3ds":
					//saveOptions = new Discreet3DSSaveOption();
					saveOptions.SaveFormat = SaveFormat.Discreet3DS;
					break;
				case "html":
					//saveOptions = new HTMLSaveOption();
					saveOptions.SaveFormat = SaveFormat.HTML;
					break;
				default:
					foundSaveOption = false;
					break;
			}

			if (threeDCloudApi != null)
			{
				if (foundSaveOption)
				{
					var response = threeDCloudApi.PostConvertByOptWithHttpInfo(fileName, saveOptions, outputFileName, null, true, null);
				}

				return new Response
				{
					FileName = outputFileName,
					Status = "OK",
					StatusCode = 200,
				};
			}			
			return new Response
			{
				FileName = null,
				Status = "Output type not found",
				StatusCode = 500
			};
			
		}
		
    }
}
