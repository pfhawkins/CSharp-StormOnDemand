using System;
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods
{
	public static class Utilities
	{
		public static class Info
		{
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Utilities/Info"]["__methods"][method];
			}

			public static string Ping ( EncodeType encoding = EncodeType.JSON)
			{
				object options = string.Empty;
				string method = "/Utilities/Info/ping";
				return APIHandler.Post (method, options, encoding);
			}
			public static string Version ( EncodeType encoding = EncodeType.JSON)
			{
				object options = string.Empty;
				string method = "/Utilities/Info/version";
				return APIHandler.Post (method, options, encoding);
			}
		}
	}
}

