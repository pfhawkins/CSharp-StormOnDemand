using System;
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods
{
	public static class VPN
	{
		public static JObject MethodInfo (string method)
		{
			 return APIMethods.Documentation.docs["VPN"]["__methods"][method];
		}

		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/VPN/create";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/VPN/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/VPN/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/VPN/update";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}
}

