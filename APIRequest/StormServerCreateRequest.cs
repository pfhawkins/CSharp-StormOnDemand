using System;
using APIMethods.Storm;

namespace StormOnDemandAPI
{
	public class StormServerCreateRequest
	{
		public BackupEnabled backup_enabled { get; set; }
		public int config_id { get; set; }
		public string domain { get; set; }
		public int ip_count { get; set; }
		public string password { get; set; }
		public string template { get; set; }
		public int zone { get; set; }
		public string public_ssh_key { get; set; }

		public StormServerCreateRequest ()
		{
			backup_enabled = 0;
			config_id = 114; // 1G instance
			domain = "host.default.test.net";
			ip_count = 1;
			password = "changeme";
			template = "CENTOS_62_COREMANAGED";
			zone = 12; // zone B
		}
	}
}

