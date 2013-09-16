using System;
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods.Account
{
	public static class Auth 
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Account/Auth"]["__methods"][method];
		}

		public static string ExpireToken (object options, EncodeType encoding = EncodeType.JSON)
		{ 
			string method = "/Account/Auth/expireToken";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Token (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Account/Auth/token";
			return APIHandler.Post (method, options, encoding);
		}
	}

}

