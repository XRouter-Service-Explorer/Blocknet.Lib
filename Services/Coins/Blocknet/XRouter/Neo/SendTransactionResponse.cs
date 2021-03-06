using System.Collections.Generic;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter.Neo
{
    [JsonConverter(typeof(ValidOrErrorConverterNeo))]
    public class SendTransactionResponse : ErrorResponse
    {
        public string Reply { get; set; }
        public string Uuid { get; set; }
    } 
}