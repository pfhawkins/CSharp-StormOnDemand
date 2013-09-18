using System;
using StormOnDemandAPI;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class APIPing
	{
		string response;
		string desiredResponse = "{\"ping\":\"success\"}";
		string badAuth = "ProtocolError Error";

		[SetUp]
		public void Init ()
		{
			//REAL API INFO REQUIRED FOR THIS TO PASS
			Auth.username = "USER";
			Auth.password = "PASS";
		}

		[Test]
		public void PingRequest()
		{
			// uses ping api method to test api requests/responses
			response = APIMethods.Utilities.Info.Ping ();
			StringAssert.AreNotEqualIgnoringCase (badAuth, response, "Did you forget to set your API auth information?");
			StringAssert.AreEqualIgnoringCase (desiredResponse, response);
		}
	}
}

