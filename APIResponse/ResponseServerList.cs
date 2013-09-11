using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace StormOnDemandAPI
{
	//http://stackoverflow.com/questions/9452901/cannot-deserialize-json-array-into-type-json-net

	public class ResponseServerList
	{
		public uint item_count { get; set; }
		public uint item_total { get; set; }
		//public string items { get; set; }
		public Items items { get; set; }
		public uint page_num { get; set; }
		public uint page_size { get; set; }
		public uint page_total { get; set; }
	}

	public class Items
	{
		public int accnt { get; set; }
		public bool active { get; set; }
		public string capabilities { get; set; }
		public string categories { get; set; }
		public string description { get; set; }
		public string domain { get; set; }
		public string features { get; set; }
		public string ip { get; set; }
		public int region_id { get; set; }
		public string type { get; set; }
		public string uniq_id { get; set; }
		public string username { get; set; }
		public string valid_source_hvs { get; set; }
	}
}

