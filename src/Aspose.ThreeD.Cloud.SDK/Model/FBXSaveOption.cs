// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FBXSaveOption.cs">
//   Copyright (c) 2018 Aspose.ThreeD for Cloud
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
  public class FBXSaveOption : SaveOptions 
  {                       
        /// <summary>
        ///  Compression large binary data in the FBX file, default value is true
        /// </summary>  
        [DataMember(Name="EnableCompression", EmitDefaultValue=false)] 
        public bool? EnableCompression { get; set; }
		
        /// <summary>
        /// Gets or sets whether reuse repeated curve data by increasing last data's ref count
        /// </summary>  
        [DataMember(Name="FoldRepeatedCurveData", EmitDefaultValue=false)] 
        public bool? FoldRepeatedCurveData { get; set; }
		
        /// <summary>
        /// Gets or sets whether export legacy material properties, used for back compatibility. This option is turned on by default
        /// </summary>  
        [DataMember(Name="ExportLegacyMaterialProperties", EmitDefaultValue=false)] 
        public bool? ExportLegacyMaterialProperties { get; set; }
		
        /// <summary>
        /// Gets or sets whether generate a Video instance for Aspose.ThreeD.Shading.Texture when exporting as FBX.
        /// </summary>  
        [DataMember(Name="VideoForTexture", EmitDefaultValue=false)] 
        public bool? VideoForTexture { get; set; }
		
        /// <summary>
        /// Gets or sets whether always generate a Aspose.ThreeD.Entities.VertexElementMaterial for geometries if the attached node contains materials. This is turned off by default.
        /// </summary>  
        [DataMember(Name="GenerateVertexElementMaterial", EmitDefaultValue=false)] 
        public bool? GenerateVertexElementMaterial { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FBXSaveOption {\n");
          sb.Append("  EnableCompression: ").Append(this.EnableCompression).Append("\n");
          sb.Append("  FoldRepeatedCurveData: ").Append(this.FoldRepeatedCurveData).Append("\n");
          sb.Append("  ExportLegacyMaterialProperties: ").Append(this.ExportLegacyMaterialProperties).Append("\n");
          sb.Append("  VideoForTexture: ").Append(this.VideoForTexture).Append("\n");
          sb.Append("  GenerateVertexElementMaterial: ").Append(this.GenerateVertexElementMaterial).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
