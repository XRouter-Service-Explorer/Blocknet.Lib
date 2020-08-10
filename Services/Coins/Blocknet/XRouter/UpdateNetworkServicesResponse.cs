using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter
{
    public class UpdateNetworkServicesResponse : JsonRpcXrError
    {
        public string Reply { get; set; }
    }

    
}