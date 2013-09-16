using System;
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods.Network
{
	public static class DNS
	{
		public static class Domain
		{
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Network/DNS/Domain"]["__methods"][method];
			}

			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Domain/list";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Renew (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Domain/renew";
				return APIHandler.Post (method, options, encoding);
			}
		}

		public static class Record
		{
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Network/DNS/Record"]["__methods"][method];
			}

			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/create";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/delete";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/details";
				return APIHandler.Post (method, options, encoding);
			}

			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/list";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/update";
				return APIHandler.Post (method, options, encoding);
			}

			public static class Region
			{
				public static JObject MethodInfo (string method)
				{
					 return Documentation.docs["Network/DNS/Record/Region"]["__methods"][method];
				}

				public static string Create (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Network/DNS/Record/Region/create";
					return APIHandler.Post (method, options, encoding);
				}

				public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Network/DNS/Record/Region/delete";
					return APIHandler.Post (method, options, encoding);
				}

				public static string Update (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Network/DNS/Record/Region/update";
					return APIHandler.Post (method, options, encoding);
				}
			}
		}

		public static class Reverse
		{
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Network/DNS/Reverse"]["__methods"][method];
			}

			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Reverse/delete";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Reverse/update";
				return APIHandler.Post (method, options, encoding);
			}

		}

		public static class Zone
		{
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Network/DNS/Zone"]["__methods"][method];
			}

			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/create";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Delegation (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/delegation";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/delete";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/details";
				return APIHandler.Post (method, options, encoding);
			}

			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/list";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/update";
				return APIHandler.Post (method, options, encoding);
			}
		}
	}	// END OF DNS

	public static class Firewall
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/Firewall"]["__methods"][method];
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/details";
			return APIHandler.Post (method, options, encoding);
		}

		public static string GetBasicOptions (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/getBasicOptions";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Rules (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/rules";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/update";
			return APIHandler.Post (method, options, encoding);
		}

		public static class Ruleset
		{
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Network/Firewall/Ruleset"]["__methods"][method];
			}

			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/create";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/details";
				return APIHandler.Post (method, options, encoding);
			}

			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/list";
				return APIHandler.Post (method, options, encoding);
			}

			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/update";
				return APIHandler.Post (method, options, encoding);
			}
		}
	}	/// <summary>
	/// End of Firewall
	/// </summary>

	public static class IP
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/IP"]["__methods"][method];
		}

		public static string Add (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/add";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/details";
			return APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/list";
			return APIHandler.Post (method, options, encoding);
		}

		public static string ListAccntPublic (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/listAccntPublic";
			return APIHandler.Post (method, options, encoding);
		}

		public static string ListPublic (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/listPublic";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Remove (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/remove";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Request (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/request";
			return APIHandler.Post (method, options, encoding);
		}

	}

	public static class LoadBalancer
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/LoadBalancer"]["__methods"][method];
		}
		public static string AddNode (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/addNode";
			return APIHandler.Post (method, options, encoding);
		}

		public static string AddService (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/addService";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Available (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/available";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/create";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/delete";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/details";
			return APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/list";
			return APIHandler.Post (method, options, encoding);
		}

		public static string PossibleNodes (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/possibleNodes";
			return APIHandler.Post (method, options, encoding);
		}

		public static string RemoveNode (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/removeNode";
			return APIHandler.Post (method, options, encoding);
		}

		public static string RemoveService (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/removeService";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Strategies (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/strategies";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/update";
			return APIHandler.Post (method, options, encoding);
		}

	}

	public static class Pool
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/Pool"]["__methods"][method];
		}
		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/create";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/delete";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/details";
			return APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/list";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/update";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Private
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/Private"]["__methods"][method];
		}

		public static string Attach (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/attach";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Detach (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/detach";
			return APIHandler.Post (method, options, encoding);
		}

		public static string Get (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/get";
			return APIHandler.Post (method, options, encoding);
		}

		public static string GetIP (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/getIP";
			return APIHandler.Post (method, options, encoding);
		}

		public static string IsAttached (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/isAttached";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Zone
	{
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/Zone"]["__methods"][method];
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Zone/details";
			return APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Zone/list";
			return APIHandler.Post (method, options, encoding);
		}

		public static string SetDefault (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Zone/setDefault";
			return APIHandler.Post (method, options, encoding);
		}
	}
}

