#region License
// Copyright (c) 2013 Michael Upton
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
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods
{
	public static class Notifications
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Notifications"]["__methods"][method];
		}
		public static string All (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Notifications/all";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Current (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Notifications/current";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Notifications/details";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Resolve (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Notifications/resolve";
			return APIHandler.Post (method, options, encoding);
		}
	}
}

