// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Entity.cs">
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
  /// Entity class             
  /// </summary>
  [DataContract]
  public class Entity 
  {                       
        /// <summary>
        /// Box/Cylinder/Sphere/Torus/Plane
        /// </summary>  
        [DataMember(Name="Type", EmitDefaultValue=false)] 
        public string Type { get; set; }
		
        /// <summary>
        /// Gets or sets Box entity
        /// </summary>  
        [DataMember(Name="Box", EmitDefaultValue=false)] 
        public Box Box { get; set; }
		
        /// <summary>
        /// Gets or sets Cylinder entity
        /// </summary>  
        [DataMember(Name="Cylinder", EmitDefaultValue=false)] 
        public Cylinder Cylinder { get; set; }
		
        /// <summary>
        /// Gets or sets Sphere entity
        /// </summary>  
        [DataMember(Name="Sphere", EmitDefaultValue=false)] 
        public Sphere Sphere { get; set; }
		
        /// <summary>
        /// Gets or sets Torus entity
        /// </summary>  
        [DataMember(Name="Torus", EmitDefaultValue=false)] 
        public Torus Torus { get; set; }
		
        /// <summary>
        /// Gets or sets Plane entity
        /// </summary>  
        [DataMember(Name="Plane", EmitDefaultValue=false)] 
        public Plane Plane { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Entity {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Box: ").Append(this.Box).Append("\n");
          sb.Append("  Cylinder: ").Append(this.Cylinder).Append("\n");
          sb.Append("  Sphere: ").Append(this.Sphere).Append("\n");
          sb.Append("  Torus: ").Append(this.Torus).Append("\n");
          sb.Append("  Plane: ").Append(this.Plane).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
