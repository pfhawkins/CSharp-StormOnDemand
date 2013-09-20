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

namespace APIMethods.Storm
{
		public enum Category {
		storm,
		ssd,
		baremetal,
		all };

	public enum BandwidthQuota {
		AsYouGo = 0,
	};

	public enum BackupEnabled {
		No = 0,
		Yes = 1
	};

	public enum SkipFSResize {
		No = 0,
		Yes = 1
	};

	public enum Force {
		No = 0,
		Yes = 1
	}

	public static class Backup
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Backup"]["__methods"][method];
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Backup/details";
			return APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Backup/list";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Restore (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Backup/restore";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Config
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Config"]["__methods"][method];
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Config/details";
			return APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Config/list";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Image
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Image"]["__methods"][method];
		}

		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/create";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/delete";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/details";
			return APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/list";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Restore (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/restore";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/update";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Server
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Server"]["__methods"][method];
		}

		public static string Clone (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/clone";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/create";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Destroy (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/destroy";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/details";
			return APIHandler.Post (method, options, encoding);
		}

		public static string History (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/history";
			return APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/list";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Reboot (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/reboot";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Resize (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/resize";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Shutdown (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/shutdown";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Start (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/start";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Status (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/status";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/update";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Template
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Template"]["__methods"][method];
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Template/details";
			return APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Template/list";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Restore (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Template/restore";
			return APIHandler.Post (method, options, encoding);
		}
	}
}

