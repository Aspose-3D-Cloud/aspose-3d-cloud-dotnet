// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Discreet3DSSaveOption.cs">
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
  public class Discreet3DSSaveOption : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets whether export all lights in the scene.
        /// </summary>  
        [DataMember(Name="ExportLight", EmitDefaultValue=false)] 
        public bool? ExportLight { get; set; }
		
        /// <summary>
        /// Gets or sets whether export all cameras in the scene
        /// </summary>  
        [DataMember(Name="ExportCamera", EmitDefaultValue=false)] 
        public bool? ExportCamera { get; set; }
		
        /// <summary>
        /// The separator between object's name and the duplicated counter, default value is \"_\". When scene contains objects that use the same name, Aspose.3D 3DS exporter will generate a different name for the object. For example there's two nodes named \"Box\", the first node will have a name \"Box\", and the second node will get a new name \"Box_2\" using the default configuration
        /// </summary>  
        [DataMember(Name="DuplicatedNameSeparator", EmitDefaultValue=false)] 
        public string DuplicatedNameSeparator { get; set; }
		
        /// <summary>
        /// The counter used by generating new name for duplicated names
        /// </summary>  
        [DataMember(Name="DuplicatedNameCounterBase", EmitDefaultValue=false)] 
        public int? DuplicatedNameCounterBase { get; set; }
		
        /// <summary>
        /// The format of the duplicated counter, default value is empty string.
        /// </summary>  
        [DataMember(Name="DuplicatedNameCounterFormat", EmitDefaultValue=false)] 
        public string DuplicatedNameCounterFormat { get; set; }
		
        /// <summary>
        /// Gets or sets the master scale used in exporting.
        /// </summary>  
        [DataMember(Name="MasterScale", EmitDefaultValue=false)] 
        public double? MasterScale { get; set; }
		
        /// <summary>
        /// Gets or sets the GammaCorrectedColor.
        /// </summary>  
        [DataMember(Name="GammaCorrectedColor", EmitDefaultValue=false)] 
        public bool? GammaCorrectedColor { get; set; }
		
        /// <summary>
        /// Gets or sets flip coordinate system of control points/normal during importing/exporting..
        /// </summary>  
        [DataMember(Name="FlipCoordinateSystem", EmitDefaultValue=false)] 
        public bool? FlipCoordinateSystem { get; set; }
		
        /// <summary>
        /// Gets or sets the HighPreciseColor.
        /// </summary>  
        [DataMember(Name="HighPreciseColor", EmitDefaultValue=false)] 
        public bool? HighPreciseColor { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Discreet3DSSaveOption {\n");
          sb.Append("  ExportLight: ").Append(this.ExportLight).Append("\n");
          sb.Append("  ExportCamera: ").Append(this.ExportCamera).Append("\n");
          sb.Append("  DuplicatedNameSeparator: ").Append(this.DuplicatedNameSeparator).Append("\n");
          sb.Append("  DuplicatedNameCounterBase: ").Append(this.DuplicatedNameCounterBase).Append("\n");
          sb.Append("  DuplicatedNameCounterFormat: ").Append(this.DuplicatedNameCounterFormat).Append("\n");
          sb.Append("  MasterScale: ").Append(this.MasterScale).Append("\n");
          sb.Append("  GammaCorrectedColor: ").Append(this.GammaCorrectedColor).Append("\n");
          sb.Append("  FlipCoordinateSystem: ").Append(this.FlipCoordinateSystem).Append("\n");
          sb.Append("  HighPreciseColor: ").Append(this.HighPreciseColor).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
