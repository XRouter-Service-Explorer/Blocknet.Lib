using System.Collections.Generic;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter
{
    [JsonConverter(typeof(ValidOrErrorConverter))]
    public class ServiceResponse : ErrorResponse
    {
        public object Reply { get; set; }
        public string Uuid { get; set; }
    }

    
}