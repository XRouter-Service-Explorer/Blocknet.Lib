using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter
{
    public class ConnectResponse : JsonRpcXrError
    {
        public List<ConnectedNodeResponse> Reply { get; set; }
        public string Uuid { get; set; }
        
        [JsonProperty("allreplies")]
		public List<ServiceNodeResponse<List<ConnectedNodeResponse>>> AllReplies { get; set; }
    }

    
}