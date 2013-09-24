#region License
// Copyright (c) 2013 mupton@liquidweb.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.Dynamic;

namespace StormOnDemandAPI
{
	public class GenericRequest : DynamicObject
	{
		/// <summary>
		/// The inner Dictionary of values
		/// </summary>
		public Dictionary<string, dynamic> values = new Dictionary<string, dynamic> ();

		/// <summary>
		/// Returns number of elements in the dictionary list.
		/// </summary>
		public int Count {
			get {
				return values.Count;
			}
		}

		/// <summary>
		/// Called if you try to get the value of a property undefined in the class
		/// </summary>
		public override bool TryGetMember (
        GetMemberBinder binder, out object result)
		{
			// Converting the property name to lowercase 
			// so that property names become case-insensitive. 
			string name = binder.Name.ToLower ();

			// If the property name is found in a dictionary, 
			// set the result parameter to the property value and return true. 
			// Otherwise, return false. 
			return values.TryGetValue (name, out result);
		}

		// If you try to set a value of a property that is 
		// not defined in the class, this method is called. 

		/// <summary>
		/// Called if you attempt to set a value of a property undefined in the class
		/// </summary>
		public override bool TrySetMember (
        SetMemberBinder binder, object value)
		{
			// Converting the property name to lowercase 
			// so that property names become case-insensitive.
			values [binder.Name.ToLower ()] = value;

			// You can always add a value to a dictionary, 
			// so this method always returns true. 
			return true;
		}
	}
}

