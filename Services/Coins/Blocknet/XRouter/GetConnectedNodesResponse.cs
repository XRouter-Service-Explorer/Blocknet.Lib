using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter
{
    public class GetConnectedNodesResponse : JsonRpcXrError
    {
        public List<ConnectedNodeResponse> Reply { get; set; }
        public string Uuid { get; set; }
    }

    
}