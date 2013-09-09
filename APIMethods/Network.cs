using System;
using StormOnDemandAPI;

namespace APIMethods.Network
{
	public static class DNS
	{
		public static class Domain
		{
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Domain/list";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Renew (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Domain/renew";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
		}

		public static class Record
		{
			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/create";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/delete";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/details";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/list";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/update";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static class Region
			{
				public static string Create (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Network/DNS/Record/Region/create";
					return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
				}

				public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Network/DNS/Record/Region/delete";
					return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
				}

				public static string Update (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Network/DNS/Record/Region/update";
					return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
				}
			}
		}

		public static class Reverse
		{
			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Reverse/delete";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Reverse/update";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

		}

		public static class Zone
		{
			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/create";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Delegation (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/delegation";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/delete";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/details";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/list";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/update";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
		}
	}	// END OF DNS

	public static class Firewall
	{
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string GetBasicOptions (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/getBasicOptions";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Rules (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/rules";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/update";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static class Ruleset
		{
			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/create";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/details";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/list";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}

			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/update";
				return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
			}
		}
	}	/// <summary>
	/// End of Firewall
	/// </summary>

	public static class IP
	{
		public static string Add (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/add";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string ListAccntPublic (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/listAccntPublic";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string ListPublic (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/listPublic";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Remove (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/remove";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Request (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/request";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

	}

	public static class LoadBalancer
	{
		public static string AddNode (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/addNode";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string AddService (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/addService";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Available (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/available";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/create";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/delete";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string PossibleNodes (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/possibleNodes";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string RemoveNode (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/removeNode";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string RemoveService (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/removeService";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Strategies (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/strategies";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/update";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

	}

	public static class Pool
	{
		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/create";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/delete";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/update";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}

	public static class Private
	{
		public static string Attach (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/attach";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Detach (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/detach";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string Get (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/get";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string GetIP (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/getIP";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string IsAttached (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/isAttached";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}

	public static class Zone
	{
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Zone/details";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Zone/list";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}

		public static string SetDefault (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Zone/setDefault";
			return StormOnDemandAPI.APIHandler.Post (method, options, encoding);
		}
	}
}

