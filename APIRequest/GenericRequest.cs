using System;
using System.Collections.Generic;
using System.Dynamic;

namespace StormOnDemandAPI
{
	public class GenericRequest : DynamicObject
	{
		// The inner dictionary.
		public Dictionary<string, dynamic> values
        = new Dictionary<string, dynamic> ();

		// This property returns the number of elements 
		// in the dictionary. 
		public int Count {
			get {
				return values.Count;
			}
		}

		// If you try to get a value of a property  
		// not defined in the class, this method is called. 
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

