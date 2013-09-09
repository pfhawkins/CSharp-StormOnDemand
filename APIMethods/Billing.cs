using System;
using StormOnDemandAPI;

namespace APIMethods.Billing
{
	public static class Invoice
	{
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
		public static string Make (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Billing/Payment/make";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}
}

