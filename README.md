![](https://img.shields.io/badge/REST%20API-v3.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/Aspose.3d-Cloud) ![Nuget](https://img.shields.io/nuget/dt/Aspose.3d-Cloud) [![GitHub license](https://img.shields.io/github/license/aspose-3d-cloud/aspose-3d-cloud-dotnet)](https://github.com/aspose-3d-cloud/aspose-3d-cloud-dotnet/blob/master/LICENSE) ![GitHub last commit](https://img.shields.io/github/last-commit/Aspose-3D-Cloud/aspose-3d-cloud-dotnet)

# .NET SDK for 3D File Formats

[Aspose.3D Cloud SDK for .NET](https://products.aspose.cloud/3d/net) wraps 3D REST APIs so you may easily create, edit and convert 3D files in your own cloud-based .NET applications. With zero initial cost!

## Process 3D Objects & Files in the Cloud

- [Convert between 3D formats](https://docs.aspose.cloud/3d/converting-between-formats-using-aspose-3d-cloud/) without requring any additional tools or rendering software.
- [Create 3D entities](https://docs.aspose.cloud/3d/create-a-new-entity-with-size/) with size such as a Box, Cylinder, Sphere, Torus or Plane.
- [Extract 3D scene](https://docs.aspose.cloud/3d/extract-and-save-a-scene-in-a-different-format/) and save in different formats.
- Triangulate 3D file or just a scene.
- [Extract 3D PDF data](https://docs.aspose.cloud/3d/extract-raw-data-from-a-pdf-file/) and save in any format.

## Read & Write 3D Formats

**Additive Manufacturing Format** AMF, **3D Studio** 3DS, **AVEVA** RVM, **Google Draco** DRC, **Collada** DAE, **AutoCAD** DXF, **Autodesk** FBX, **Wavefront** OBJ, **3D** PDF, **Polygon File Format** PLY, **Standard Triangle Language** STL, **Universal3D** U3D, **GL Transmission Format** GLTF

## Read-Only Formats

**Siemens** JT, **DirectX** X, **3D Manufacturing Format** 3MF, **3D Studio Max** ASE

## Integrated Storage API

- Upload, download, copy, move and delete files, including versions handling (if you are using Cloud storage that supports this feature - true by default).
- Create, copy, move and delete folders.
- Copy and move files and folders accross separate storages.
- Check if certain file, folder or storage exists.
## Enhancements Version 20.5
- Added support to read/write more file formats.
- Added support for HTML file format conversion.
- New feature added to Triangulate part of the scene (Specified by OAP) and save the scene to a different file.


## Get Started with Aspose.3D Cloud SDK for .NET

Register an account at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) to get you application information. Next, execute `Install-Package Aspose.3d-Cloud` from the Package Manager Console in Visual Studio to fetch & reference Aspose.3D Cloud SDK assembly in your project. If you already have Aspose.3D Cloud SDK for .NET, execute `Update-Package Aspose.3D-Cloud` to get the latest version. You may alternatively install the package from command line as `nuget install Aspose.3D-Cloud`.

## Convert 3D to PDF in C# .Net

```csharp
	// Get your ClientId and ClientSecret from https://dashboard.aspose.cloud (free registration required).

	ThreeDCloudApiApi threeDCloudApi = new ThreeDCloudApi("client_credentials", "MY_CLIENT_ID", "MY_CLIENT_SECRET");

	string name = "sample.3d";
	string newformat = "pdf";
	string newfilename = "saveasformat.pdf";
	string folder = "3DToPdf";
	bool isOverwrite = true;
	string storage = "My_Storage_Name";

	var response = threeDCloudApi.PostConvertByFormat(name, newformat, newfilename, folder, isOverwrite, storage);
```
## Aspose.3D Cloud SDKs in Popular Languages

| Java | PHP | Python | Ruby | Node.js | Swift | Perl | GO |
|---|---|---|---|---|---|---|---|
| [GitHub](https://github.com/aspose-3d-cloud/aspose-3d-cloud-java) | [GitHub](https://github.com/Aspose-3D-Cloud/aspose-3d-cloud-php) | [GitHub](https://github.com/Aspose-3D-Cloud/aspose-3d-cloud-python) | [GitHub](https://github.com/Aspose-3D-Cloud/aspose-3d-cloud-ruby)  | [GitHub](https://github.com/Aspose-3D-Cloud/aspose-3d-cloud-node) | [GitHub](https://github.com/aspose-3d-cloud/aspose-3d-cloud-swift) | [GitHub](https://github.com/Aspose-3D-Cloud/aspose-3d-cloud-perl) | [GitHub](https://github.com/Aspose-3D-Cloud/aspose-3d-cloud-go) |
| [Maven](https://repository.aspose.cloud/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-3d-cloud) | [Composer](https://packagist.org/packages/aspose/3d-sdk-php) | [PIP](https://pypi.org/project/aspose3dcloud/) | [GEM](https://rubygems.org/gems/aspose_3d_cloud)  | [NPM](https://www.npmjs.com/package/aspose3dcloud) | [POD](https://cocoapods.org/pods/Aspose3DCloud) |  [CPAN](https://metacpan.org/release/AsposeThreeDCloud-ThreeDCloudApi) | [GO](https://pkg.go.dev/github.com/Aspose-3D-Cloud/aspose-3d-cloud-go/v20?tab=overview) |

[Home](https://www.aspose.cloud) | [Product Page](https://products.aspose.cloud/3d/net) | [Documentation](https://docs.aspose.cloud/3d/) | [Live Demo](https://products.aspose.app/3d/family) | [API Reference](https://apireference.aspose.cloud/3d/) | [Code Samples](https://github.com/Aspose-3D-Cloud/aspose-3d-cloud-dotnet/tree/master/src/Aspose.ThreeD.Cloud.SDK.Test) | [Blog](https://blog.aspose.cloud/category/3d/) | [Free Support](https://forum.aspose.cloud/c/3d) | [Free Trial](https://dashboard.aspose.cloud/#/apps)
