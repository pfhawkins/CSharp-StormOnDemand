using System;

namespace APIMethods.Helper
{
		/// <summary>
	/// Helper for storm config list
	/// </summary>
	public enum Category {
		storm,
		ssd,
		baremetal,
		all };

	public enum BandwidthQuota {
		AsYouGo = 0,
	};

	public enum BackupEnabled {
		No = 0,
		Yes = 1
	};

	public enum SkipFSResize {
		No = 0,
		Yes = 1
	};

	public enum Force {
		No = 0,
		Yes = 1
	}
}

