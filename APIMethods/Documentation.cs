using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

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

		public static string FindValue (string val)
		{ 
			foreach (KeyValuePair<string, dynamic> en in docs) { 
				if (en.Key.ToString () == val) 
					return en.Value.ToString ();
			}
				return string.Format ("{0} not found", val); 
		}
	}
}

