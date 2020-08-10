using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.Responses.Ethereum;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter.Ethereum
{
    [JsonConverter(typeof(ValidOrErrorConverterEthereum))]
    public class GetTransactionResponse : ErrorResponse
    {
        public TransactionResponse Reply { get; set; }
        public string Uuid { get; set; }
    }
}