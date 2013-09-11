using System;
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods.Support
{

		public static class Alert
		{
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Support/Alert"]["__methods"][method];
			}

			public static string GetActive (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Alert/getActive";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
		}

		public static class Ticket
		{
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Support/Ticket"]["__methods"][method];
			}

			public static string AddFeedback (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/addFeedback";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
			public static string AddTransactionFeedback (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/addTransactionFeedback";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
			public static string Authenticate (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/authenticate";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
			public static string Close (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/close";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/create";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/details";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/list";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
			public static string Reopen (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/reopen";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
			public static string Reply (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/reply";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
			public static string Types (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/types";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
		}

}

