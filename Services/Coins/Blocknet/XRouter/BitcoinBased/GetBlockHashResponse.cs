using System.Collections.Generic;
using Blocknet.Lib.RPC.Connector;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter.BitcoinBased
{
    [JsonConverter(typeof(ValidOrErrorConverter))]
    public class GetBlockHashResponse:ErrorResponse
    {
        [JsonProperty("reply")]
        public string Reply { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    } 
}