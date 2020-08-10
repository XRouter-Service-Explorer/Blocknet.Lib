using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.Responses.Neo;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter.Neo
{
    [JsonConverter(typeof(ValidOrErrorConverterNeo))]
    public class GetTransactionResponse : ErrorResponse
    {
        public TransactionResponse Reply { get; set; }
        public string Uuid { get; set; }
    }
}