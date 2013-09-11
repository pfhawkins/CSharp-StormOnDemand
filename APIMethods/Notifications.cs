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
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Current (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Notifications/current";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Notifications/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Resolve (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Notifications/resolve";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}
}

