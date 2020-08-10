using System;
using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter
{
	public class ServiceNodeInfoResponse
	{
		public string SNodeKey { get; set; }
        public int Score { get; set; }
        public string Tier { get; set; }
        public string Address { get; set; }
        public bool Exr { get; set; }
        public string Status { get; set; }
        public long TimeLastSeen { get; set; }
        public DateTime TimeLastSeenStr { get; set; }
        public List<string> Services { get; set; }

    }
}
