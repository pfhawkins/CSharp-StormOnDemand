using System;
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods
{
	public static class Product
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Product"]["__methods"][method];
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Product/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string GetProductCodeFromPath (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Product/getProductCodeFromPath";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Product/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Price (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Product/price";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string StartingPrice (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Product/startingPrice";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}
}

