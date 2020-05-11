// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Cylinder.cs">
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
  public class Cylinder 
  {                       
        /// <summary>
        /// Gets or sets the name of the cylinder             
        /// </summary>  
        [DataMember(Name="Name", EmitDefaultValue=false)] 
        public string Name { get; set; }
		
        /// <summary>
        /// Gets or sets the radius of cylinder's top cap.
        /// </summary>  
        [DataMember(Name="RadiusTop", EmitDefaultValue=false)] 
        public double? RadiusTop { get; set; }
		
        /// <summary>
        /// Gets or sets the radius bottoof cylinder's bottom cap.             
        /// </summary>  
        [DataMember(Name="RadiusBottom", EmitDefaultValue=false)] 
        public double? RadiusBottom { get; set; }
		
        /// <summary>
        /// Gets or sets the height of the cylinder.
        /// </summary>  
        [DataMember(Name="Height", EmitDefaultValue=false)] 
        public double? Height { get; set; }
		
        /// <summary>
        /// Gets or sets the radial segments.
        /// </summary>  
        [DataMember(Name="RadialSegments", EmitDefaultValue=false)] 
        public int? RadialSegments { get; set; }
		
        /// <summary>
        /// Gets or sets the height segments.
        /// </summary>  
        [DataMember(Name="HeightSegments", EmitDefaultValue=false)] 
        public int? HeightSegments { get; set; }
		
        /// <summary>
        /// Gets or sets a value indicating whether this Aspose.ThreeD.Entities.Cylinder open ended. The default value is false.
        /// </summary>  
        [DataMember(Name="OpenEnded", EmitDefaultValue=false)] 
        public bool? OpenEnded { get; set; }
		
        /// <summary>
        /// Gets or sets the theta start. The default value is 0.             
        /// </summary>  
        [DataMember(Name="ThetaStart", EmitDefaultValue=false)] 
        public double? ThetaStart { get; set; }
		
        /// <summary>
        /// Gets or sets the length of the theta. The default value is 2p.
        /// </summary>  
        [DataMember(Name="ThetaLength", EmitDefaultValue=false)] 
        public double? ThetaLength { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Cylinder {\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  RadiusTop: ").Append(this.RadiusTop).Append("\n");
          sb.Append("  RadiusBottom: ").Append(this.RadiusBottom).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  RadialSegments: ").Append(this.RadialSegments).Append("\n");
          sb.Append("  HeightSegments: ").Append(this.HeightSegments).Append("\n");
          sb.Append("  OpenEnded: ").Append(this.OpenEnded).Append("\n");
          sb.Append("  ThetaStart: ").Append(this.ThetaStart).Append("\n");
          sb.Append("  ThetaLength: ").Append(this.ThetaLength).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
