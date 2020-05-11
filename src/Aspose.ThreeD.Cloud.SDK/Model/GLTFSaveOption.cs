// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GLTFSaveOption.cs">
//   Copyright (c) 2020 Aspose.ThreeD for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System; 

namespace Aspose.ThreeD.Cloud.SDK.Model 
{
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class GLTFSaveOption : SaveOptions 
  {                       
        /// <summary>
        /// The JSON content of GLTF file is indented for human reading, default value is false.
        /// </summary>  
        [DataMember(Name="PrettyPrint", EmitDefaultValue=false)] 
        public bool? PrettyPrint { get; set; }
		
        /// <summary>
        /// Embed all external assets as base64 into single file in ASCII mode, default value is false.
        /// </summary>  
        [DataMember(Name="EmbedAssets", EmitDefaultValue=false)] 
        public bool? EmbedAssets { get; set; }
		
        /// <summary>
        /// Serialize materials using KHR common material extensions, default value is false. Set this to false will cause Aspose.3D export a set of vertex/fragment shader if Aspose.ThreeD.Formats.GLTFSaveOptions.ExportShaders
        /// </summary>  
        [DataMember(Name="UseCommonMaterials", EmitDefaultValue=false)] 
        public bool? UseCommonMaterials { get; set; }
		
        /// <summary>
        /// Flip texture coordinate v(t) component, default value is true.
        /// </summary>  
        [DataMember(Name="FlipTexCoordV", EmitDefaultValue=false)] 
        public bool? FlipTexCoordV { get; set; }
		
        /// <summary>
        /// The file name of the external buffer file used to store binary data. If this file is not specified, Aspose.3D will generate a name for you. This is ignored when export glTF in binary mode.
        /// </summary>  
        [DataMember(Name="BufferFile", EmitDefaultValue=false)] 
        public bool? BufferFile { get; set; }
		
        /// <summary>
        /// Save scene object's dynamic properties into 'extra' fields in the generated glTF file. This is useful to provide application-specific data. Default value is false..
        /// </summary>  
        [DataMember(Name="SaveExtras", EmitDefaultValue=false)] 
        public bool? SaveExtras { get; set; }
		
        /// <summary>
        /// Gets or sets whether to enable draco compression.
        /// </summary>  
        [DataMember(Name="DracoCompression", EmitDefaultValue=false)] 
        public bool? DracoCompression { get; set; }
		
        /// <summary>
        /// Gets or sets  of the FileContent type.
        /// </summary>  
        [DataMember(Name="FileContentType", EmitDefaultValue=false)] 
        public FileContentType FileContentType { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class GLTFSaveOption {\n");
          sb.Append("  PrettyPrint: ").Append(this.PrettyPrint).Append("\n");
          sb.Append("  EmbedAssets: ").Append(this.EmbedAssets).Append("\n");
          sb.Append("  UseCommonMaterials: ").Append(this.UseCommonMaterials).Append("\n");
          sb.Append("  FlipTexCoordV: ").Append(this.FlipTexCoordV).Append("\n");
          sb.Append("  BufferFile: ").Append(this.BufferFile).Append("\n");
          sb.Append("  SaveExtras: ").Append(this.SaveExtras).Append("\n");
          sb.Append("  DracoCompression: ").Append(this.DracoCompression).Append("\n");
          sb.Append("  FileContentType: ").Append(this.FileContentType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
