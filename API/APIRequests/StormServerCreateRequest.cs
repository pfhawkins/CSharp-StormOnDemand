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
		/// <summary>
		/// Enable backups on the server, uses APIMethods.Storm enum helper.
		/// </summary>
		public BackupEnabled backup_enabled { get; set; }

		/// <summary>
		/// Sets the config_id used when deploying.
		/// Config ID's are viewable with APIMethods.Storm.Config.list
		/// </summary>
		public int config_id { get; set; }

		/// <summary>
		/// Sets the Hostname for the instance.
		/// </summary>
		public string domain { get; set; }

		/// <summary>
		/// Sets the amount of IP's allocated to the instance.
		/// </summary>
		public int ip_count { get; set; }

		/// <summary>
		/// Sets the password for the instance.
		/// </summary>
		public string password { get; set; }

		/// <summary>
		/// Sets what LiquidWeb image to use, viewable with APIMethods.Storm.Template.list.
		/// </summary>
		public string template { get; set; }

		/// <summary>
		/// Sets the zone for the deploy. Lansing XEN, Lansing KVM or phoenix KVM
		/// Defaults to Lansing KVM
		/// </summary>
		public int zone { get; set; }

		/// <summary>
		/// Add a id_rsa.pub here to automatically deploy it on the instance during creation.
		/// </summary>
		public string public_ssh_key { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="StormOnDemandAPI.StormServerCreateRequest"/> class.
		/// </summary>
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

