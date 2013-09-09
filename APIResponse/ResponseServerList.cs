using System;
using System.Collections;

namespace StormOnDemandAPI
{
	public class ResponseServerList
	{
		public uint item_count { get; set; }
		public uint item_total{ get; set; }
		public ArrayList items { get; set; }
		public uint page_num { get; set; }
		public uint page_size { get; set; }
		public uint page_total { get; set; }

		public ResponseServerList ()
		{
		}
	}
}

