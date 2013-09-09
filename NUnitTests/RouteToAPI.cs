using System;
using NUnit.Framework;
using System.Net.NetworkInformation;
using System.Text;
using StormOnDemandAPI;

namespace Tests
{
	//Generic ping request to api to test connection
	[TestFixture]
	public class RouteToAPI
	{
		// variables
		string _hostname;
		Ping _pinger;
		PingOptions _pingerOptions;
		string _data;
		Byte[] _buffer;
		int _timeout;
		PingReply _reply;
		
		[SetUp]
		public void Init()
		{
			// Setup some data
			_hostname = "api.stormondemand.com";
			_pinger = new Ping();
			_pingerOptions = new PingOptions();
			_pingerOptions.DontFragment = true;
			_pingerOptions.Ttl = 128;
			_data = "Junk data";
			_buffer = Encoding.ASCII.GetBytes(_data);
			_timeout = 120;
		}

		[Test]
		public void TestConnection()
		{
			// Pings api.stormondemand.com to check route to API
			_reply = _pinger.Send (_hostname, _timeout, _buffer, _pingerOptions);

			Assert.AreNotEqual (_reply.Status, IPStatus.TimedOut);
			Assert.AreNotEqual ( _reply.Status, IPStatus.TtlExpired);
			Assert.AreNotEqual (_reply.Status, IPStatus.DestinationUnreachable);
			Assert.AreEqual (_reply.Status, IPStatus.Success);
		}
	}
}
