#region License
// Copyright (c) 2013 Michael Upton
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

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
				return APIHandler.Post (method, options, encoding);
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
				return APIHandler.Post (method, options, encoding);
			}
			public static string AddTransactionFeedback (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/addTransactionFeedback";
				return APIHandler.Post (method, options, encoding);
			}
			public static string Authenticate (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/authenticate";
				return APIHandler.Post (method, options, encoding);
			}
			public static string Close (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/close";
				return APIHandler.Post (method, options, encoding);
			}
			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/create";
				return APIHandler.Post (method, options, encoding);
			}
			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/details";
				return APIHandler.Post (method, options, encoding);
			}
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/list";
				return APIHandler.Post (method, options, encoding);
			}
			public static string Reopen (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/reopen";
				return APIHandler.Post (method, options, encoding);
			}
			public static string Reply (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/reply";
				return APIHandler.Post (method, options, encoding);
			}
			public static string Types (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Support/Ticket/types";
				return APIHandler.Post (method, options, encoding);
			}
		}

}

