// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfLightingScheme.cs">
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
  public  enum PdfLightingScheme 
  {  	
		/// <summary>
        /// Enum value Artwork
        /// </summary>            
        Artwork,
		
		/// <summary>
        /// Enum value None
        /// </summary>            
        None,
		
		/// <summary>
        /// Enum value White
        /// </summary>            
        White,
		
		/// <summary>
        /// Enum value Day
        /// </summary>            
        Day,
		
		/// <summary>
        /// Enum value Night
        /// </summary>            
        Night,
		
		/// <summary>
        /// Enum value Hard
        /// </summary>            
        Hard,
		
		/// <summary>
        /// Enum value Primary
        /// </summary>            
        Primary,
		
		/// <summary>
        /// Enum value Blue
        /// </summary>            
        Blue,
		
		/// <summary>
        /// Enum value Red
        /// </summary>            
        Red,
		
		/// <summary>
        /// Enum value Cube
        /// </summary>            
        Cube,
		
		/// <summary>
        /// Enum value CAD
        /// </summary>            
        CAD,
		
		/// <summary>
        /// Enum value Headlamp
        /// </summary>            
        Headlamp
		
  }
}
