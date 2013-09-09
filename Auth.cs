using System;
using System.Net;

namespace StormOnDemandAPI
{
	public static class Auth
	{
		public static string username = string.Empty;
		public static string password = string.Empty;

		public static System.Net.ICredentials Credentials { get { return new System.Net.NetworkCredential (username, password); } }

	}
}

