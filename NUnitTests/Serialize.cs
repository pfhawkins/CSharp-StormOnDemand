using System;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using StormOnDemandAPI;
using Newtonsoft.Json;

namespace Tests
{
	[TestFixture]
	public class Serialize
	{
		//variables
		string ret;
		string desiredOutput;
		Hashtable hash;
		dynamic genRequest;
		Dictionary<string, dynamic> de;
		IPDetailsRequest ipDetails;

		[SetUp]
		public void Init()
		{
			// JSON string sample of API request for /Server/list to compare serialized objects to
			desiredOutput = "{\"params\":{\"uniq_id\":\"ABCD12\",\"ip\":\"12.34.56.78\"}}";
		}

		[Test]
		public void SerializeDictionary ()
		{
			de = new Dictionary<string, dynamic>();
			de.Add ("uniq_id", "ABCD12");
			de.Add ("ip", "12.34.56.78");

			// Converts Dictionary<keys,values> to JSON string
			ret = JsonConvert.SerializeObject (de);

			// Checks if data is Serialized properly
			Assert.IsInstanceOf<Dictionary<string, dynamic>>(de);
			StringAssert.AreEqualIgnoringCase (desiredOutput, ret);
		}

		[Test]
		public void SerializeClass()
		{
			ipDetails = new IPDetailsRequest ();

			ipDetails.uniq_id = "ABCD12";
			ipDetails.ip = "12.34.56.78";

			// Serializes IPDetailsRequest object properties,values into a JSON string
			ret = JsonConvert.SerializeObject (ipDetails);

			// Checks if data is Serialized properly
			Assert.IsInstanceOf<IPDetailsRequest>(ipDetails);
			StringAssert.AreEqualIgnoringCase (desiredOutput, ret);
		}

		[Test]
		public void SerializeHash()
		{
			hash = new Hashtable ();

			hash.Add ("uniq_id", "ABCD12");
			hash.Add ("ip", "12.34.56.78");

			//Serializes Hashtable<keys,values> into JSON string
			ret = JsonConvert.SerializeObject (hash);

			// Checks if data is Serialized properly
			Assert.IsInstanceOf<Hashtable>(hash);
			StringAssert.AreEqualIgnoringCase (desiredOutput, ret);
		}

		[Test]
		public void SerializeGeneric()
		{
			genRequest = new GenericRequest ();

			genRequest.Uniq_id = "ABCD12";
			genRequest.Ip = "12.34.56.78";

			// Serializes dynamic object properties,values into JSON string
			ret = JsonConvert.SerializeObject (genRequest.properties);

			// Checks if data is Serialized properly
			Assert.IsInstanceOf<GenericRequest>(genRequest);
			StringAssert.AreEqualIgnoringCase (desiredOutput, ret);
		}
	}
}

