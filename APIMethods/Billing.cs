using System;
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods.Billing
{
	public static class Invoice
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Billing/Invoice"]["__methods"][method];
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Billing/Invoice/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Billing/Invoice/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Next (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Billing/Invoice/next";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}

	public static class Payment
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Billing/Payment"]["__methods"][method];
		}

		public static string Make (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Billing/Payment/make";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}
}

