// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Vector3.cs">
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
  /// A vector with three components.             
  /// </summary>
  [DataContract]
  public class Vector3 
  {                       
        /// <summary>
        /// The x component.
        /// </summary>  
        [DataMember(Name="x", EmitDefaultValue=false)] 
        public double? X { get; set; }
		
        /// <summary>
        /// The y component.
        /// </summary>  
        [DataMember(Name="y", EmitDefaultValue=false)] 
        public double? Y { get; set; }
		
        /// <summary>
        /// The z component.
        /// </summary>  
        [DataMember(Name="z", EmitDefaultValue=false)] 
        public double? Z { get; set; }
		
        /// <summary>
        /// Gets the square of the length.             
        /// </summary>  
        [DataMember(Name="Length2", EmitDefaultValue=false)] 
        public double? Length2 { get; set; }
		
        /// <summary>
        /// Gets the length of this vector.
        /// </summary>  
        [DataMember(Name="Length", EmitDefaultValue=false)] 
        public double? Length { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Vector3 {\n");
          sb.Append("  X: ").Append(this.X).Append("\n");
          sb.Append("  Y: ").Append(this.Y).Append("\n");
          sb.Append("  Z: ").Append(this.Z).Append("\n");
          sb.Append("  Length2: ").Append(this.Length2).Append("\n");
          sb.Append("  Length: ").Append(this.Length).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
