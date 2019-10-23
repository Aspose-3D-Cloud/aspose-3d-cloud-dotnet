// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Transform.cs">
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
  /// A transform contains information that allow access to object&#39;s translate/scale/rotation or transform matrix at minimum cost This is used by local transform.             
  /// </summary>
  [DataContract]
  public class Transform 
  {                       
        /// <summary>
        /// Gets or sets the translation
        /// </summary>  
        [DataMember(Name="Translation", EmitDefaultValue=false)] 
        public Vector3 Translation { get; set; }
		
        /// <summary>
        /// Gets or sets the scale
        /// </summary>  
        [DataMember(Name="Scale", EmitDefaultValue=false)] 
        public Vector3 Scale { get; set; }
		
        /// <summary>
        /// Gets or sets the pre-rotation represented in degree
        /// </summary>  
        [DataMember(Name="PreRotation", EmitDefaultValue=false)] 
        public Vector3 PreRotation { get; set; }
		
        /// <summary>
        /// Gets or sets the post-rotation represented in degree
        /// </summary>  
        [DataMember(Name="PostRotation", EmitDefaultValue=false)] 
        public Vector3 PostRotation { get; set; }
		
        /// <summary>
        /// Gets or sets the rotation represented in euler angles, measured in degree             
        /// </summary>  
        [DataMember(Name="EulerAngles", EmitDefaultValue=false)] 
        public Vector3 EulerAngles { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Transform {\n");
          sb.Append("  Translation: ").Append(this.Translation).Append("\n");
          sb.Append("  Scale: ").Append(this.Scale).Append("\n");
          sb.Append("  PreRotation: ").Append(this.PreRotation).Append("\n");
          sb.Append("  PostRotation: ").Append(this.PostRotation).Append("\n");
          sb.Append("  EulerAngles: ").Append(this.EulerAngles).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
