// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSaveOption.cs">
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
  public class PdfSaveOption : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets to flip the coordinate system of the scene during exporting.
        /// </summary>  
        [DataMember(Name="FlipCoordinateSystem", EmitDefaultValue=false)] 
        public bool? FlipCoordinateSystem { get; set; }
		
        /// <summary>
        /// Render mode specifies the style in which the 3D artwork is rendered.
        /// </summary>  
        [DataMember(Name="RenderMode", EmitDefaultValue=false)] 
        public PdfRenderMode RenderMode { get; set; }
		
        /// <summary>
        /// LightingScheme specifies the lighting to apply to 3D artwork.
        /// </summary>  
        [DataMember(Name="LightingScheme", EmitDefaultValue=false)] 
        public PdfLightingScheme LightingScheme { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfSaveOption {\n");
          sb.Append("  FlipCoordinateSystem: ").Append(this.FlipCoordinateSystem).Append("\n");
          sb.Append("  RenderMode: ").Append(this.RenderMode).Append("\n");
          sb.Append("  LightingScheme: ").Append(this.LightingScheme).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
