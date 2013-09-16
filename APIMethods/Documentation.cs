using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using StormOnDemandAPI;

namespace APIMethods
{
	public class Documentation
	{
		public static Dictionary<string, dynamic> docs;

		public static Dictionary<string, dynamic> PullAPIDocs ()
		{
			WebClient cli = new WebClient ();

			string tmp = cli.DownloadString ("https://www.stormondemand.com/api/docs/v1/docs.json");

			//Regex removes \n characters that are outside of strings so it will store properly
			return docs = JsonConvert.DeserializeObject<Dictionary<string, dynamic>> (Regex.Replace (tmp, @"[\n]", " "));
		}

		public static JObject MethodInfo (string category, string method)
		{ 
			return docs[category]["__methods"][method]; 
		}

		public static JValue MethodInfo (string category, string method, string section)
		{ 
			return docs[category]["__methods"][method][section]; 
		}
	}
}

