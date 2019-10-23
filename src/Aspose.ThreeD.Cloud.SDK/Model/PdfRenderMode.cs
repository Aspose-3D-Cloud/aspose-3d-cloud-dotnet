// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfRenderMode.cs">
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
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;
  
  /// <summary>
  /// Render mode specifies the style in which the 3D artwork is rendered.
  /// </summary>  
  // remove :[JsonConverter(typeof(StringEnumConverter))]
  // jack@aspose.com : enum convert to int rather then string 
  public  enum PdfRenderMode 
  {  	
		/// <summary>
        /// Enum value Solid
        /// </summary>            
        Solid,
		
		/// <summary>
        /// Enum value SolidWireframe
        /// </summary>            
        SolidWireframe,
		
		/// <summary>
        /// Enum value Transparent
        /// </summary>            
        Transparent,
		
		/// <summary>
        /// Enum value TransparentWireframe
        /// </summary>            
        TransparentWireframe,
		
		/// <summary>
        /// Enum value BoundingBox
        /// </summary>            
        BoundingBox,
		
		/// <summary>
        /// Enum value TransparentBoundingBox
        /// </summary>            
        TransparentBoundingBox,
		
		/// <summary>
        /// Enum value TransparentBoundingBoxOutline
        /// </summary>            
        TransparentBoundingBoxOutline,
		
		/// <summary>
        /// Enum value Wireframe
        /// </summary>            
        Wireframe,
		
		/// <summary>
        /// Enum value ShadedWireframe
        /// </summary>            
        ShadedWireframe,
		
		/// <summary>
        /// Enum value HiddenWireframe
        /// </summary>            
        HiddenWireframe,
		
		/// <summary>
        /// Enum value Vertices
        /// </summary>            
        Vertices,
		
		/// <summary>
        /// Enum value ShadedVertices
        /// </summary>            
        ShadedVertices,
		
		/// <summary>
        /// Enum value Illustration
        /// </summary>            
        Illustration,
		
		/// <summary>
        /// Enum value SolidOutline
        /// </summary>            
        SolidOutline,
		
		/// <summary>
        /// Enum value ShadedIllustration
        /// </summary>            
        ShadedIllustration
		
  }
}
