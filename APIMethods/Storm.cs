using System;
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods.Storm
{
//		public enum Category {
//		storm,
//		ssd,
//		baremetal,
//		all };
//
//	public enum BandwidthQuota {
//		AsYouGo = 0,
//	};
//
//	public enum BackupEnabled {
//		No = 0,
//		Yes = 1
//	};
//
//	public enum SkipFSResize {
//		No = 0,
//		Yes = 1
//	};
//
//	public enum Force {
//		No = 0,
//		Yes = 1
//	}

	public static class Backup
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Storm/Backup"]["__methods"][method];
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Backup/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Backup/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Restore (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Backup/restore";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
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
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Config/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
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
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/delete";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Restore (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/restore";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Image/update";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
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
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/create";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Destroy (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/destroy";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string History (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/history";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Reboot (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/reboot";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Resize (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/resize";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Shutdown (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/shutdown";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Start (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/start";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Status (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/status";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Server/update";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
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
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Template/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Restore (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Storm/Template/restore";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}
}

