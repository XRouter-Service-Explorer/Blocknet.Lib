using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;
using Xrouter.Service.Explorer.BitcoinLib.Services.Coins.Blocknet.XRouter;
using Blocknet.Lib.Services.Coins.Blocknet;
using Blocknet.Lib.RPC.Deserializer;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter.Monero
{
    [JsonConverter(typeof(ValidOrErrorConverterMonero))]
    public class GetBlockCountResponse : ErrorResponse
    {
        public int Reply { get; set; }
        public string Uuid { get; set; }
    }
}
