// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveFormat.cs">
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
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;
  
  /// <summary>
  /// SaveFormat type
  /// </summary>  
  // remove :[JsonConverter(typeof(StringEnumConverter))]
  // jack@aspose.com : enum convert to int rather then string 
  public  enum SaveFormat 
  {  	
		/// <summary>
        /// Enum value AMF
        /// </summary>            
        AMF,
		
		/// <summary>
        /// Enum value ASE
        /// </summary>            
        ASE,
		
		/// <summary>
        /// Enum value Aspose3DWeb
        /// </summary>            
        Aspose3DWeb,
		
		/// <summary>
        /// Enum value Collada
        /// </summary>            
        Collada,
		
		/// <summary>
        /// Enum value Discreet3DS
        /// </summary>            
        Discreet3DS,
		
		/// <summary>
        /// Enum value Draco
        /// </summary>            
        Draco,
		
		/// <summary>
        /// Enum value DXF
        /// </summary>            
        DXF,
		
		/// <summary>
        /// Enum value FBX
        /// </summary>            
        FBX,
		
		/// <summary>
        /// Enum value GLTF
        /// </summary>            
        GLTF,
		
		/// <summary>
        /// Enum value HTML5
        /// </summary>            
        HTML,
		
		/// <summary>
        /// Enum value JT
        /// </summary>            
        JT,
		
		/// <summary>
        /// Enum value Microsoft3MF
        /// </summary>            
        Microsoft3MF,
		
		/// <summary>
        /// Enum value Obj
        /// </summary>            
        Obj,
		
		/// <summary>
        /// Enum value PDF
        /// </summary>            
        PDF,
		
		/// <summary>
        /// Enum value PLY
        /// </summary>            
        PLY,
		
		/// <summary>
        /// Enum value Rvm
        /// </summary>            
        Rvm,
		
		/// <summary>
        /// Enum value STL
        /// </summary>            
        STL,
		
		/// <summary>
        /// Enum value U3D
        /// </summary>            
        U3D,
		
		/// <summary>
        /// Enum value VRML
        /// </summary>            
        VRML,
		
		/// <summary>
        /// Enum value X
        /// </summary>            
        X
		
  }
}
