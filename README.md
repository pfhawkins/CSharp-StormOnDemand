StormOnDemandAPI
================

C# Library to assist with using the Storm On Demand API.

Uses Newtonsoft's JSON library, Modified for Storm API
Compatible with .Net 3.5 on Linux and .Net 3.0, 3.5, 4, 4.5 on Windows

Can deserialize/serialize Classes, Hashtables, Dictionarys, Objects, Dynamic Objects to and from JSON or XML format.

## Examples 

### Serialize 

The following show how to serialize by the specific object type into a JSON string

#### Each of the following serialize methods will output the following ret string below , escape sequences removed for readability 
ret = {"params":{"category":"provisioned","type":"XD.VM"}}

	public class RequestServerList
	{
		public string category { get; set; };
		public string type { get; set; };
	}

	public void SerializeDictionary ()
	{
		Dictionary<string, dynamic> de = new Dictionary<string, dynamic>();
		de.Add ("category", "provisioned");
		de.Add ("type", "XD.VM");

	        string ret = JsonConvert.SerializeObject (de);
	}

	public void SerializeClass()
	{
		RequestServerList serverList = new RequestServerList ();

		serverList.category = "provisioned";
		serverList.type = "XD.VM";

		string ret = JsonConvert.SerializeObject (serverList);
	}

	public void SerializeHash()
	{
		Hashtable hash = new Hashtable ();

		hash.Add ("category", "provisioned");
		hash.Add ("type", "XD.VM");

		string ret = JsonConvert.SerializeObject (hash);
	}

	public void SerializeGeneric()
	{
		dynamic genRequest = new GenericRequest ();

		genRequest.Category = "Provisioned";
		genRequest.Type = "XD.VM";

		string ret = JsonConvert.SerializeObject (genRequest.properties);
	}


### Deserialize

The following show how to deserialize a JSON string to store in object types. 

#### Class used in the deserialize class example
	
	public class ResponseIPDetails
	{
		public string broadcast { get; set; }
		public string gateway{ get; set; }
		public string ip { get; set; }
		public string netmask { get; set; }
		public string id { get; set; }
	}

	string testData = "{"broadcast":"12.34.56.255","gateway":"12.34.254.1","ip":"64.91.254.81","netmask":"255.255.254.0","id":"987654"}";

	public void DeserializeClass ()
	{
		ResponseIPDetails ipde = new ResponseIPDetails ();
		// Deserialize JSON string into a class objects properties->values
		ipde = JsonConvert.DeserializeObject<ResponseIPDetails> (testData);
	}
	
	public void DeserializeDictionary()
	{
		Dictionary<string, dynamic> de = new Dictionary<string, dynamic> ();
		// Deserialize JSON string into a Dictionary<string, dynamic>
		de = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, dynamic>> (testData)
	}

	public void DeserializeHash ()
	{
		Hashtable hash = new Hashtable ();

		// Deserialize JSON string in a Hashtable object
		hash = Newtonsoft.Json.JsonConvert.DeserializeObject<Hashtable> (testData);
	}


