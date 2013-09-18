using System;

namespace StormOnDemandAPI
{
	public class StormConfigListResponse
	{
		public int disk { get; set; }
		public bool active { get; set; }
		public string description { get; set; }
		public string[] zone_availability { get; set; }
		public string memory { get; set; }
		public int id { get; set; }
		public string category { get; set; }
		public int vcpu { get; set; }
		public bool available { get; set; }
	}
}

