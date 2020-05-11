// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DracoSaveOption.cs">
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
  public class DracoSaveOption : SaveOptions 
  {                       
        /// <summary>
        /// Quantization bits for position, default value is 14
        /// </summary>  
        [DataMember(Name="PositionBits", EmitDefaultValue=false)] 
        public int? PositionBits { get; set; }
		
        /// <summary>
        /// Quantization bits for texture coordinate, default value is 12
        /// </summary>  
        [DataMember(Name="TextureCoordinateBits", EmitDefaultValue=false)] 
        public int? TextureCoordinateBits { get; set; }
		
        /// <summary>
        /// Quantization bits for vertex color, default value is 10
        /// </summary>  
        [DataMember(Name="ColorBits", EmitDefaultValue=false)] 
        public int? ColorBits { get; set; }
		
        /// <summary>
        /// Quantization bits for normal vectors, default value is 10
        /// </summary>  
        [DataMember(Name="NormalBits", EmitDefaultValue=false)] 
        public int? NormalBits { get; set; }
		
        /// <summary>
        /// Compression level, default value is Aspose.ThreeD.Formats.DracoCompressionLevel.Standard.
        /// </summary>  
        [DataMember(Name="CompressionLevel", EmitDefaultValue=false)] 
        public DracoCompressionLevel CompressionLevel { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DracoSaveOption {\n");
          sb.Append("  PositionBits: ").Append(this.PositionBits).Append("\n");
          sb.Append("  TextureCoordinateBits: ").Append(this.TextureCoordinateBits).Append("\n");
          sb.Append("  ColorBits: ").Append(this.ColorBits).Append("\n");
          sb.Append("  NormalBits: ").Append(this.NormalBits).Append("\n");
          sb.Append("  CompressionLevel: ").Append(this.CompressionLevel).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
