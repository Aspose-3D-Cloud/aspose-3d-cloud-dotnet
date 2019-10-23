// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="U3DSaveOption.cs">
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
  public class U3DSaveOption : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets whether flip coordinate system of control points/normal during importing/exporting.
        /// </summary>  
        [DataMember(Name="FlipCoordinateSystem", EmitDefaultValue=false)] 
        public bool? FlipCoordinateSystem { get; set; }
		
        /// <summary>
        /// Gets or sets whether to enable mesh data compression.
        /// </summary>  
        [DataMember(Name="MeshCompression", EmitDefaultValue=false)] 
        public bool? MeshCompression { get; set; }
		
        /// <summary>
        /// Gets or sets whether to export normal data.
        /// </summary>  
        [DataMember(Name="ExportNormals", EmitDefaultValue=false)] 
        public bool? ExportNormals { get; set; }
		
        /// <summary>
        /// Gets or sets whether to export texture coordinates.
        /// </summary>  
        [DataMember(Name="ExportTextureCoordinates", EmitDefaultValue=false)] 
        public bool? ExportTextureCoordinates { get; set; }
		
        /// <summary>
        /// Gets or sets whether to export vertex's diffuse color.
        /// </summary>  
        [DataMember(Name="ExportVertexDiffuse", EmitDefaultValue=false)] 
        public bool? ExportVertexDiffuse { get; set; }
		
        /// <summary>
        /// Gets or sets whether to export vertex' specular color.
        /// </summary>  
        [DataMember(Name="ExportVertexSpecular", EmitDefaultValue=false)] 
        public bool? ExportVertexSpecular { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class U3DSaveOption {\n");
          sb.Append("  FlipCoordinateSystem: ").Append(this.FlipCoordinateSystem).Append("\n");
          sb.Append("  MeshCompression: ").Append(this.MeshCompression).Append("\n");
          sb.Append("  ExportNormals: ").Append(this.ExportNormals).Append("\n");
          sb.Append("  ExportTextureCoordinates: ").Append(this.ExportTextureCoordinates).Append("\n");
          sb.Append("  ExportVertexDiffuse: ").Append(this.ExportVertexDiffuse).Append("\n");
          sb.Append("  ExportVertexSpecular: ").Append(this.ExportVertexSpecular).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
