# Aspose.3D Cloud SDK for .NET [![NuGet](https://img.shields.io/nuget/v/Aspose.3D-Cloud.svg)](https://www.nuget.org/packages/Aspose.3D-Cloud/)

- API version: 3.0
- SDK version: 20.5

This repository contains Aspose.3D Cloud SDK for .NET source code. This SDK allows you to work with Aspose.3D Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.



# Key Features

- Conversion between various document-related formats (10+ formats supported)

- Modeling and Data Processing,including parametric modeling and delete object from scene 

- Utilities,including extract 3D contens from PDF file and triangulate meshes 



See [API Reference](https://apireference.aspose.cloud/3d/) for full API specification.



# File,folder and storage API support


It gives you an ability to:

- Upload, download, copy, move and delete files, including versions handling (if you are using Cloud storage that supports this feature - true by default)
- Create, copy, move and delete folders
- Copy and move files and folders accross separate storages in scope of a single operation
- Check if certain file, folder or storage exists

# Licensing

All Aspose.3D Cloud SDKs are licensed under [MIT License](https://github.com/aspose-3d-cloud/aspose-3d-cloud-dotnet/blob/master/LICENSE).



# How to use the SDK?

The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/Aspose.3D-Cloud/) (recommended). For more details, please visit our [documentation website](https://docs.aspose.cloud/cells/available-sdks/).

 

### Prerequisites

 

To use Aspose.3D Cloud SDK you need to register an account with [Aspose Cloud](https://www.aspose.cloud/) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.aspose.cloud/#/apps). There is free quota available. For more details, see [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing).

 

### Installation

 

#### Install Aspose.3D-Cloud via NuGet

 

From the command line:

 

```
nuget install Aspose.3D-Cloud
```

 

From Package Manager:

 

```
PM> Install-Package Aspose.3D-Cloud
```

 

From within Visual Studio:

1. Open the Solution Explorer.

2. Right-click on a project within your solution.

3. Click on *Manage NuGet Packages...*

4. Click on the *Browse* tab and search for "Aspose.3D-Cloud".

5. Click on the Aspose.3D-Cloud package, select the appropriate version in the right-tab and click *Install*.

### Sample usage

    

   The examples below show how your application have to initiate and convert whole file into different format with format parameter using Aspose.3D-Cloud library:

    

   ```
    var threeDCloudApi = new ThreeDCloudApi(grantType,AppKey, AppSid);//grantType is "client_credentials"
    string name = "srcFile";
    string newformat = "pdf";
    string newfilename = "saveasformat.pdf";
    string folder = "3DTest";
    bool isOverwrite = true;
    string storage = "First Storage";
    var response = threeDCloudApi.PostConvertByFormatWithHttpInfo(name, newformat, newfilename, folder, isOverwrite, storage);
   ```



# Tests

[Tests](https://github.com/aspose-3D-cloud/aspose-3D-cloud-dotnet/tree/master/Aspose.3D.Cloud.SDK.Test) contain various examples of using the SDK.



# Contact Us

Your feedback is very important to us. Please feel free to contact via

- [**Free Support Forum**](https://forum.aspose.cloud/c/3d)
- [**Paid Support Helpdesk**](https://helpdesk.aspose.cloud/)

# Resources

- [**Web API reference**](https://apireference.aspose.cloud/3d/)
- [**Website**](https://www.aspose.cloud)
- [**Product Home**](https://products.aspose.cloud/3d)
- [**Documentation**](https://docs.aspose.cloud/3d/)
- [**Blog**](https://blog.aspose.cloud/category/3d/)
