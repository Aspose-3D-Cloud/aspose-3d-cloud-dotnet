// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveOptions.cs">
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
  public class SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets  of the SaveFormat.
        /// </summary>
        [DataMember(Name="SaveFormat", EmitDefaultValue=false)]  
        public SaveFormat? SaveFormat { get; set; }

        /// <summary>
        /// Some files like OBJ depends on external file, the lookup paths will allows Aspose.3D to look for external file to load
        /// </summary>  
        [DataMember(Name="LookupPaths", EmitDefaultValue=false)] 
        public List<string> LookupPaths { get; set; }
		
        /// <summary>
        /// The file name of the exporting/importing scene. This is optional, but useful when serialize external assets like OBJ's material.
        /// </summary>  
        [DataMember(Name="FileName", EmitDefaultValue=false)] 
        public string FileName { get; set; }
		
        /// <summary>
        /// The file format��like FBX,U3D,PDF ....
        /// </summary>  
        [DataMember(Name="FileFormat", EmitDefaultValue=false)] 
        public string FileFormat { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveOptions {\n");
          sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
          sb.Append("  LookupPaths: ").Append(this.LookupPaths).Append("\n");
          sb.Append("  FileName: ").Append(this.FileName).Append("\n");
          sb.Append("  FileFormat: ").Append(this.FileFormat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
