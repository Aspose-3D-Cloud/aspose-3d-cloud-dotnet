// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileSystem.cs">
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
  /// FileSystemType in Aspose.3D.Cloud
  /// </summary>
  [DataContract]
  public class FileSystem 
  {                       
        /// <summary>
        /// Gets or sets  of the FileSystem Type.
        /// </summary>  
        [DataMember(Name="FileSystemType", EmitDefaultValue=false)] 
        public FileSystemType FileSystemType { get; set; }
		
        /// <summary>
        /// path to construct FileSystem 
        /// </summary>  
        [DataMember(Name="Directory", EmitDefaultValue=false)] 
        public string Directory { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FileSystem {\n");
          sb.Append("  FileSystemType: ").Append(this.FileSystemType).Append("\n");
          sb.Append("  Directory: ").Append(this.Directory).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
