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
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
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
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Create(object options, EncodeType encoding = EncodeType.JSON ) {
				string method = "/Storage/Block/Volume/create";
				return StormOnDemandAPI.APIHandler.Post(method, options, encoding);
			}

			public static string Detach (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/detach";
				return StormOnDemandAPI.APIHandler.Post(method, options, encoding);
			}
			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/delete";
				return StormOnDemandAPI.APIHandler.Post(method, options, encoding);
			}
			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/details";
				return StormOnDemandAPI.APIHandler.Post(method, options, encoding);
			}
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/list";
				return StormOnDemandAPI.APIHandler.Post(method, options, encoding);
			}
			public static string Resize (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/resize";
				return StormOnDemandAPI.APIHandler.Post(method, options, encoding);
			}
			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Storage/Block/Volume/update";
				return StormOnDemandAPI.APIHandler.Post(method, options, encoding);
			}
		}
	}
}


