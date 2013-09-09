using System;
using StormOnDemandAPI;

namespace APIMethods.Account
{
	public static class Auth
	{
		public static string ExpireToken (object options, EncodeType encoding = EncodeType.JSON)
		{ 
			string method = "/Account/Auth/expireToken";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Token (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Account/Auth/token";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}

}

