using System.Collections.Generic;
using Blocknet.Lib.Responses.Monero;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter.Monero
{
    [JsonConverter(typeof(ValidOrErrorConverterMonero))]
    public class GetTransactionsResponse : ErrorResponse
    {
        public List<TransactionResponse> Reply { get; set; }
        public string Uuid { get; set; }
    } 
}