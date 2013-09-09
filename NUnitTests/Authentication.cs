using System;
using NUnit.Framework;
using System.Net;
using StormOnDemandAPI;

namespace Tests
{
	[TestFixture]
	public class Authentication
	{
		// variables
		string _testUser;
		string _testPassword;

		[SetUp]
		public void Init ()
		{
			//sets up test data
			_testUser = "NUnitUser";
			_testPassword = "NUnitPassword";
			Auth.username = _testUser;
			Auth.password = _testPassword;
		}

		[Test]
		public void CanSetAuthInfo()
		{
			// Just makes sure its able to set the auth info
			StringAssert.AreEqualIgnoringCase (_testUser, Auth.username);
			StringAssert.AreEqualIgnoringCase (_testPassword, Auth.password);
		}

		[Test]
		public void CheckCredentialsType()
		{
			// checks that the auth credentials are the correct type
			Assert.IsInstanceOf<ICredentials>(Auth.Credentials);

		}
	}
}

