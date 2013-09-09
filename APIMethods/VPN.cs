using System;
using StormOnDemandAPI;

namespace APIMethods
{
	public static class VPN
	{
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

