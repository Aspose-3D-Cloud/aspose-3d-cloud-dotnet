// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ModelData.cs">
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
  /// Parametric Modeling
  /// </summary>
  [DataContract]
  public class ModelData 
  {                       
        /// <summary>
        /// e.g Node
        /// </summary>  
        [DataMember(Name="Type", EmitDefaultValue=false)] 
        public string Type { get; set; }
		
        /// <summary>
        /// Gets or sets Transform
        /// </summary>  
        [DataMember(Name="Transform", EmitDefaultValue=false)] 
        public Transform Transform { get; set; }
		
        /// <summary>
        /// Gets or sets Entity
        /// </summary>  
        [DataMember(Name="Entity", EmitDefaultValue=false)] 
        public Entity Entity { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ModelData {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Transform: ").Append(this.Transform).Append("\n");
          sb.Append("  Entity: ").Append(this.Entity).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
