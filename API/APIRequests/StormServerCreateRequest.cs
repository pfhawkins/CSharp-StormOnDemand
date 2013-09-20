#region License
// Copyright (c) 2013 Michael Upton
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

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

