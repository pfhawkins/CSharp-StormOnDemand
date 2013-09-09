using System;
using StormOnDemandAPI;

namespace APIMethods.Monitoring
{
	public static class Bandwidth
	{
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

