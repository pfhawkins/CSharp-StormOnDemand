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

#### With APIMethods helper classes 

#### Without APIMethods helper classes
