using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.RPC.Connector;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;
using Xrouter.Service.Explorer.BitcoinLib.Services.Coins.Blocknet.XRouter;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter.BitcoinBased
{
    [JsonConverter(typeof(ValidOrErrorConverter))]
    public class GetBlockResponse : ErrorResponse
    {
        [JsonProperty("reply")]
        public BlockResponse Reply { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}
