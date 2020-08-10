using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter
{
    public class ConfigResponse : JsonRpcXrError
    {
        public string NodePubKey { get; set; }
        public string PaymentAddress { get; set; }
        public string Config { get; set; }
        public Dictionary<string,string> Plugins { get; set; }
    }

    
}