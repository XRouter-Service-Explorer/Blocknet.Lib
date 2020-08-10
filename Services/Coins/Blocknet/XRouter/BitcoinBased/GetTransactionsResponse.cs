using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.RPC.Connector;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter.BitcoinBased
{
    [JsonConverter(typeof(ValidOrErrorConverter))]
    public class GetTransactionsResponse:ErrorResponse
    {
        [JsonProperty("reply")]
        public List<RawTransactionResponse> Reply { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }     
    }
}