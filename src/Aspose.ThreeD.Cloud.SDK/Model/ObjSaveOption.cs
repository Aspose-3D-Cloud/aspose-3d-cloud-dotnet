// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ObjSaveOption.cs">
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
  public class ObjSaveOption : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets whether generate comments for each section.
        /// </summary>  
        [DataMember(Name="Verbose", EmitDefaultValue=false)] 
        public bool? Verbose { get; set; }
		
        /// <summary>
        /// Gets or sets whether serialize W component in model's vertex position.
        /// </summary>  
        [DataMember(Name="SerializeW", EmitDefaultValue=false)] 
        public bool? SerializeW { get; set; }
		
        /// <summary>
        /// Gets or sets whether import/export materials for each object.
        /// </summary>  
        [DataMember(Name="EnableMaterials", EmitDefaultValue=false)] 
        public bool? EnableMaterials { get; set; }
		
        /// <summary>
        /// Gets or sets whether flip coordinate system of control points/normal during importing/exporting.
        /// </summary>  
        [DataMember(Name="FlipCoordinateSystem", EmitDefaultValue=false)] 
        public bool? FlipCoordinateSystem { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ObjSaveOption {\n");
          sb.Append("  Verbose: ").Append(this.Verbose).Append("\n");
          sb.Append("  SerializeW: ").Append(this.SerializeW).Append("\n");
          sb.Append("  EnableMaterials: ").Append(this.EnableMaterials).Append("\n");
          sb.Append("  FlipCoordinateSystem: ").Append(this.FlipCoordinateSystem).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
