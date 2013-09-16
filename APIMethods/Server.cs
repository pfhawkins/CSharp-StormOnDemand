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


