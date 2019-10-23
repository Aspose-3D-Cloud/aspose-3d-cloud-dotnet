// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Torus.cs">
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
  /// The Torus Entity class
  /// </summary>
  [DataContract]
  public class Torus 
  {                       
        /// <summary>
        /// Gets or sets the Name of the torus.
        /// </summary>  
        [DataMember(Name="Name", EmitDefaultValue=false)] 
        public string Name { get; set; }
		
        /// <summary>
        /// Gets or sets the radius of the torus.             
        /// </summary>  
        [DataMember(Name="Radius", EmitDefaultValue=false)] 
        public double? Radius { get; set; }
		
        /// <summary>
        /// Gets or sets the radius of the tube.
        /// </summary>  
        [DataMember(Name="Tube", EmitDefaultValue=false)] 
        public double? Tube { get; set; }
		
        /// <summary>
        /// Gets or sets the radial segments.
        /// </summary>  
        [DataMember(Name="RadialSegments", EmitDefaultValue=false)] 
        public int? RadialSegments { get; set; }
		
        /// <summary>
        /// Gets or sets the tubular segments.
        /// </summary>  
        [DataMember(Name="TubularSegments", EmitDefaultValue=false)] 
        public int? TubularSegments { get; set; }
		
        /// <summary>
        /// Gets or sets the arc.
        /// </summary>  
        [DataMember(Name="Arc", EmitDefaultValue=false)] 
        public double? Arc { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Torus {\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Radius: ").Append(this.Radius).Append("\n");
          sb.Append("  Tube: ").Append(this.Tube).Append("\n");
          sb.Append("  RadialSegments: ").Append(this.RadialSegments).Append("\n");
          sb.Append("  TubularSegments: ").Append(this.TubularSegments).Append("\n");
          sb.Append("  Arc: ").Append(this.Arc).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
