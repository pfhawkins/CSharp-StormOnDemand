using System;
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods.Monitoring
{
	public static class Bandwidth
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Monitoring/Bandwidth"]["__methods"][method];
		}

		public static string Graph (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Bandwidth/graph";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Stats (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Bandwidth/stats";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}

	public static class Load
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Monitoring/Load"]["__methods"][method];
		}

		public static string Graph (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Load/graph";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Stats (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Load/stats";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}

	public static class Services
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Monitoring/Services"]["__methods"][method];
		}

		public static string Get (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Services/get";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string MonitoringIPs (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Services/monitoringIps";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Status (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Services/status";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Monitoring/Services/update";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}
}

