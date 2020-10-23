![](https://img.shields.io/badge/REST%20API-v3.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/Aspose.3d-Cloud) ![Nuget](https://img.shields.io/nuget/dt/Aspose.3d-Cloud) [![GitHub license](https://img.shields.io/github/license/aspose-3d-cloud/aspose-3d-cloud-dotnet)](https://github.com/aspose-3d-cloud/aspose-3d-cloud-dotnet/blob/master/LICENSE) ![GitHub last commit](https://img.shields.io/github/last-commit/Aspose-3D-Cloud/aspose-3d-cloud-dotnet)

# .NET SDK for 3D File Formats

.NET SDK wraps Aspose.3D Cloud APIs so you could create, edit and convert 3D files in your cloud-based .NET applications with zero initial cost.

## Process 3D Objects & Files in the Cloud

- [Convert between 3D formats](https://docs.aspose.cloud/3d/converting-between-formats-using-aspose-3d-cloud/) without requring any additional tools or rendering software.
- Modeling and data processing, including parametric modeling and object deletion from scene.
- Utilities such as extract 3D contens from PDF file and triangulate meshes.

## Read & Write 3D Formats

AMF, 3DS, RVM, DRC, DAE, DXF, FBX, OBJ, PDF, PLY, STL, U3D, GLTF, HTML

## Read-Only Formats

JT, X (DirectX), 3MF, ASE

## Integratd Storage API

It gives you an ability to:

- Upload, download, copy, move and delete files, including versions handling (if you are using Cloud storage that supports this feature - true by default).
- Create, copy, move and delete folders.
- Copy and move files and folders accross separate storages in scope of a single operation.
- Check if certain file, folder or storage exists.

## Get Started with Aspose.3D Cloud SDK for .NET

Register an account at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) to get you application information. Next, execute `Install-Package Aspose.3d-Cloud` from the Package Manager Console in Visual Studio to fetch & reference Aspose.3D Cloud SDK assembly in your project. If you already have Aspose.3D Cloud SDK for .NET and want to upgrade it, please execute `Update-Package Aspose.3D-Cloud` to get the latest version. You may alternatively install the package from command line as `nuget install Aspose.3D-Cloud`.

## Convert a 3D File to PDF in the Cloud

```csharp
var threeDCloudApi = new ThreeDCloudApi(grantType,AppKey, AppSid);//grantType is "client_credentials"
string name = "srcFile";
string newformat = "pdf";
string newfilename = "saveasformat.pdf";
string folder = "3DTest";
bool isOverwrite = true;
string storage = "First Storage";
var response = threeDCloudApi.PostConvertByFormatWithHttpInfo(name, newformat, newfilename, folder, isOverwrite, storage);
```

## Aspose.3D Cloud SDKs in Popular Languages

| Java |
|---|
| [GitHub](https://github.com/aspose-3d-cloud/aspose-3d-cloud-java) |
| [Maven](https://repository.aspose.cloud/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-3d-cloud) |

[Home](https://www.aspose.cloud) | [Product Page](https://products.aspose.cloud/3d/net) | [Documentation](https://docs.aspose.cloud/3d/) | [Live Demo](https://products.aspose.app/3d/family) | [API Reference](https://apireference.aspose.cloud/3d/) | [Code Samples](https://github.com/Aspose-3D-Cloud/aspose-3d-cloud-dotnet/tree/master/src/Aspose.ThreeD.Cloud.SDK.Test) | [Blog](https://blog.aspose.cloud/category/3d/) | [Free Support](https://forum.aspose.cloud/c/3d) | [Free Trial](https://dashboard.aspose.cloud/#/apps)
