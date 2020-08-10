using System.Collections.Generic;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;
using Xrouter.Service.Explorer.BitcoinLib.Services.Coins.Blocknet.XRouter;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter.BitcoinBased
{
    [JsonConverter(typeof(ValidOrErrorConverter))]
    public class GetBlockCountResponse:ErrorResponse
    {
        [JsonProperty("reply")]        
        public int Reply { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    } 
}
