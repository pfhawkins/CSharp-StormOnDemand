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
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace APIMethods
{
	public static class Server
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Server"]["__methods"][method];
		}

		public static string Available (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/available";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Clone (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/clone";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/create";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Destroy (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/destroy";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/details";
			return APIHandler.Post (method, options, encoding);
		}
		public static string History (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/history";
			return APIHandler.Post (method, options, encoding);
		}
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/list";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Reboot (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/reboot";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Resize (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/resize";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Shutdown (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/shutdown";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Start (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/start";
			return APIHandler.Post (method, options, encoding);
		}
		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/update";
			return APIHandler.Post (method, options, encoding);
		}

		public static class Virtual
		{
			public static class Domain
			{
				public static JObject MethodInfo (string method)
				{
					 return Documentation.docs["Server/VirtualDomain"]["__methods"][method];
				}

				public static string Create (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/create";
					return APIHandler.Post (method, options, encoding);
				}
				public static string FreeCount (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/freecount";
					return APIHandler.Post (method, options, encoding);
				}
				public static string List (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/list";
					return APIHandler.Post (method, options, encoding);
				}
				public static string ListOrphans (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/listOrphans";
					return APIHandler.Post (method, options, encoding);
				}
				public static string ReLink (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/relink";
					return APIHandler.Post (method, options, encoding);
				}
			}
		}
	}
}


