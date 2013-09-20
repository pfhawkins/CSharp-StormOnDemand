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

namespace APIMethods.Storage
{
	public static class Block
	{
		public static class Cluster
		{
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Storage/Block/Cluster"]["__methods"][method];
			}

			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Cluster/list";
				return APIHandler.Post (method, options, encoding);
			}
		}

		public static class Volume
		{
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Storage/Block/Volume"]["__methods"][method];
			}

			public static string Attach(object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/attach";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Create(object options, EncodeType encoding = EncodeType.JSON ) {
				string method = "/Storage/Block/Volume/create";
				return APIHandler.Post(method, options, encoding);
			}

			public static string Detach (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/detach";
				return APIHandler.Post(method, options, encoding);
			}
			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/delete";
				return APIHandler.Post(method, options, encoding);
			}
			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/details";
				return APIHandler.Post(method, options, encoding);
			}
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/list";
				return APIHandler.Post(method, options, encoding);
			}
			public static string Resize (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/resize";
				return APIHandler.Post(method, options, encoding);
			}
			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/update";
				return APIHandler.Post(method, options, encoding);
			}
		}
	}
}


