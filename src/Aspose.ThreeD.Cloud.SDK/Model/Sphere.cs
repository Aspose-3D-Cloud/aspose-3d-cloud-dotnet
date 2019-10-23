// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Sphere.cs">
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
  /// The Sphere Entity
  /// </summary>
  [DataContract]
  public class Sphere 
  {                       
        /// <summary>
        /// Gets or sets the Name of Sphere.
        /// </summary>  
        [DataMember(Name="Name", EmitDefaultValue=false)] 
        public string Name { get; set; }
		
        /// <summary>
        /// Gets or sets the width segments.
        /// </summary>  
        [DataMember(Name="WidthSegments", EmitDefaultValue=false)] 
        public int? WidthSegments { get; set; }
		
        /// <summary>
        /// Gets or sets the height segments.             
        /// </summary>  
        [DataMember(Name="HeightSegments", EmitDefaultValue=false)] 
        public int? HeightSegments { get; set; }
		
        /// <summary>
        /// Gets or sets the phi start.             
        /// </summary>  
        [DataMember(Name="PhiStart", EmitDefaultValue=false)] 
        public double? PhiStart { get; set; }
		
        /// <summary>
        /// Gets or sets the length of the phi.
        /// </summary>  
        [DataMember(Name="PhiLength", EmitDefaultValue=false)] 
        public double? PhiLength { get; set; }
		
        /// <summary>
        /// Gets or sets the theta start.             
        /// </summary>  
        [DataMember(Name="ThetaStart", EmitDefaultValue=false)] 
        public double? ThetaStart { get; set; }
		
        /// <summary>
        /// Gets or sets the length of the theta.
        /// </summary>  
        [DataMember(Name="ThetaLength", EmitDefaultValue=false)] 
        public double? ThetaLength { get; set; }
		
        /// <summary>
        /// Gets or sets the radius 
        /// </summary>  
        [DataMember(Name="Radius", EmitDefaultValue=false)] 
        public double? Radius { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Sphere {\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  WidthSegments: ").Append(this.WidthSegments).Append("\n");
          sb.Append("  HeightSegments: ").Append(this.HeightSegments).Append("\n");
          sb.Append("  PhiStart: ").Append(this.PhiStart).Append("\n");
          sb.Append("  PhiLength: ").Append(this.PhiLength).Append("\n");
          sb.Append("  ThetaStart: ").Append(this.ThetaStart).Append("\n");
          sb.Append("  ThetaLength: ").Append(this.ThetaLength).Append("\n");
          sb.Append("  Radius: ").Append(this.Radius).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
