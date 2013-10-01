StormOnDemandAPI
================

C# Library to assist with using the Storm On Demand API.

Uses Newtonsoft's JSON library, Modified for Liquid Web's Storm API
Compatible with .Net 3.5 on Linux and .Net 3.0, 3.5, 4, 4.5 on Windows

Can deserialize/serialize Classes, Hashtables, Dictionarys, Objects, Dynamic Objects to and from JSON or XML format.

The APIMethods folder isn't required. It's just a set of helper classes there to make it easier when using an IDE 
with intellisense to remember the methods Along with the commenting that will display as tooltips for each method.

The APIRequests/APIResponses folders also aren't required. The dynamic classes will however be needed if your building
objects to post to the api dynamically. The other classes are just examples of how you can serialize/deserialize classes
properties->values into valid JSON strings.

## Examples 

The following examples show how to build API requests with and without the helper classes or dynamic classes.
Throughout the examples its implied you set the username and password in the auth.cs via

Auth.username = user;
Auth.password = password; 

All of the below use the APIMethods helper classes, you can get the same output without using them simply using APIHandler.Post and passing in the method with the object. ie: string result = APIHandler.Post( "/Storm/Config/list", configList);

#### using GenericRequest dynamic object class
 
	// Storm/Config/list example

	dynamic configList = new GenericRequest();
	configList.category = "storm";	// will parse this into json as { "category" : "storm" }

	string result = APIMethods.Storm.Config.List( configList.values );

#### Using Dictionarys or Hashtables instead of a dynamic object

	// Storm/Config/list example

	Dictionary<string, dynamic> configList = new Dictionary<string, dynamic>();
	configList.Add ("category", "storm");

	string result = APIMethods.Storm.Config.List( configList );

#### Using a defined class object to serialize into JSON

	public class StormConfigList
	{
		public string category { get; set; }
	}

	StormConfigList stormConfig = new StormConfigList();
	stormConfig.category = "storm";

	string result = APIMethods.Storm.Config.List( stormConfig );
