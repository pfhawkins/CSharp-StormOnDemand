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
		string _ret;
		string _desiredOutput;
		Hashtable _hash;
		dynamic _genRequest;
		Dictionary<string, dynamic> de;

		[SetUp]
		public void Init()
		{
			// JSON string sample of API request for /Server/list to compare serialized objects to
			_desiredOutput = "{\"params\":{\"category\":\"provisioned\",\"type\":\"XD.VM\"}}";
		}

		[Test]
		public void SerializeDictionary ()
		{
			de = new Dictionary<string, dynamic>();
			de.Add ("category", "provisioned");
			de.Add ("type", "XD.VM");

			// Converts Dictionary<keys,values> to JSON string
			_ret = JsonConvert.SerializeObject (de);

			// Checks if data is Serialized properly
			Assert.IsInstanceOf<Dictionary<string, dynamic>>(de);
			StringAssert.AreEqualIgnoringCase (_desiredOutput, _ret);
		}

		[Test]
		public void SerializeClass()
		{
			RequestServerList serverList = new RequestServerList ();

			serverList.category = "provisioned";
			serverList.type = "XD.VM";

			// Serializes RequestServerList object properties,values into a JSON string
			_ret = JsonConvert.SerializeObject (serverList);

			// Checks if data is Serialized properly
			Assert.IsInstanceOf<RequestServerList>(serverList);
			StringAssert.AreEqualIgnoringCase (_desiredOutput, _ret);
		}

		[Test]
		public void SerializeHash()
		{
			_hash = new Hashtable ();

			_hash.Add ("category", "provisioned");
			_hash.Add ("type", "XD.VM");

			//Serializes Hashtable<keys,values> into JSON string
			_ret = JsonConvert.SerializeObject (_hash);

			// Checks if data is Serialized properly
			Assert.IsInstanceOf<Hashtable>(_hash);
			StringAssert.AreEqualIgnoringCase (_desiredOutput, _ret);
		}

		[Test]
		public void SerializeGeneric()
		{
			_genRequest = new GenericRequest ();

			_genRequest.Category = "Provisioned";
			_genRequest.Type = "XD.VM";

			// Serializes dynamic object properties,values into JSON string
			_ret = JsonConvert.SerializeObject (_genRequest.properties);

			// Checks if data is Serialized properly
			Assert.IsInstanceOf<GenericRequest>(_genRequest);
			StringAssert.AreEqualIgnoringCase (_desiredOutput, _ret);
		}
	}
}

