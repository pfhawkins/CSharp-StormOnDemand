using System;
using StormOnDemandAPI;

namespace APIMethods
{
	public static class Server
	{
		public static string Available (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/available";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Clone (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/clone";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/create";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Destroy (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/destroy";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string History (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/history";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Reboot (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/reboot";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Resize (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/resize";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Shutdown (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/shutdown";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Start (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/start";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Server/update";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static class Virtual
		{
			public static class Domain
			{
				public static string Create (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/create";
					return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
				}
				public static string FreeCount (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/freecount";
					return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
				}
				public static string List (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/list";
					return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
				}
				public static string ListOrphans (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/listOrphans";
					return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
				}
				public static string ReLink (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Server/VirtualDomain/relink";
					return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
				}
			}
		}
	}
}


