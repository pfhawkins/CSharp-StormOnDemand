using System;
using StormOnDemandAPI;

namespace APIMethods
{
	public static class Utilities
	{
		public static class Info
		{
			public static string Ping ( EncodeType encoding = EncodeType.JSON)
			{
				object options = string.Empty;
				string method = "/Utilities/Info/ping";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
			public static string Version ( EncodeType encoding = EncodeType.JSON)
			{
				object options = string.Empty;
				string method = "/Utilities/Info/version";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
		}
	}
}

