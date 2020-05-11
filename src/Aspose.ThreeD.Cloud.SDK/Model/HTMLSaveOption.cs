// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HTMLSaveOption.cs">
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
  public class HTMLSaveOption : SaveOptions 
  {                       
        /// <summary>
        ///  Display a grid in the scene. Default value is true.
        /// </summary>  
        [DataMember(Name="ShowGrid", EmitDefaultValue=false)] 
        public bool? ShowGrid { get; set; }
		
        /// <summary>
        ///  Display rulers of x/y/z axises in the scene to measure the model. Default value is false
        /// </summary>  
        [DataMember(Name="ShowRulers", EmitDefaultValue=false)] 
        public bool? ShowRulers { get; set; }
		
        /// <summary>
        /// Display a simple UI in the scene. Default value is true
        /// </summary>  
        [DataMember(Name="ShowUI", EmitDefaultValue=false)] 
        public bool? ShowUI { get; set; }
		
        /// <summary>
        /// Display a orientation box. Default value is true.
        /// </summary>  
        [DataMember(Name="OrientationBox", EmitDefaultValue=false)] 
        public bool? OrientationBox { get; set; }
		
        /// <summary>
        /// Gets or sets the up vector, value can be \"x\"/\"y\"/\"z\", default value is \"y\".
        /// </summary>  
        [DataMember(Name="UpVector", EmitDefaultValue=false)] 
        public string UpVector { get; set; }
		
        /// <summary>
        /// Gets or sets the far plane of the camera, default value is 1000
        /// </summary>  
        [DataMember(Name="FarPlane", EmitDefaultValue=false)] 
        public double? FarPlane { get; set; }
		
        /// <summary>
        /// Gets or sets the near plane of the camera, default value is 1
        /// </summary>  
        [DataMember(Name="NearPlane", EmitDefaultValue=false)] 
        public double? NearPlane { get; set; }
		
        /// <summary>
        /// Gets or sets the default look at position, default value is (0, 0, 0)
        /// </summary>  
        [DataMember(Name="LookAt", EmitDefaultValue=false)] 
        public Vector3 LookAt { get; set; }
		
        /// <summary>
        /// Gets or sets the initial position of the camera, default value is (10, 10, 10)
        /// </summary>  
        [DataMember(Name="CameraPosition", EmitDefaultValue=false)] 
        public Vector3 CameraPosition { get; set; }
		
        /// <summary>
        ///  Gets or sets the field of the view, default value is 45, measured in degree
        /// </summary>  
        [DataMember(Name="FieldOfView", EmitDefaultValue=false)] 
        public double? FieldOfView { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HTMLSaveOption {\n");
          sb.Append("  ShowGrid: ").Append(this.ShowGrid).Append("\n");
          sb.Append("  ShowRulers: ").Append(this.ShowRulers).Append("\n");
          sb.Append("  ShowUI: ").Append(this.ShowUI).Append("\n");
          sb.Append("  OrientationBox: ").Append(this.OrientationBox).Append("\n");
          sb.Append("  UpVector: ").Append(this.UpVector).Append("\n");
          sb.Append("  FarPlane: ").Append(this.FarPlane).Append("\n");
          sb.Append("  NearPlane: ").Append(this.NearPlane).Append("\n");
          sb.Append("  LookAt: ").Append(this.LookAt).Append("\n");
          sb.Append("  CameraPosition: ").Append(this.CameraPosition).Append("\n");
          sb.Append("  FieldOfView: ").Append(this.FieldOfView).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
