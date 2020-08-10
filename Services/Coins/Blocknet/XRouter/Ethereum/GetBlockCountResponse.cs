using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;
using Xrouter.Service.Explorer.BitcoinLib.Services.Coins.Blocknet.XRouter;
using Blocknet.Lib.Services.Coins.Blocknet;
using Blocknet.Lib.RPC.Deserializer;

namespace Blocknet.Lib.Services.Coins.Blocknet.Xrouter.Ethereum
{
    [JsonConverter(typeof(ValidOrErrorConverterEthereum))]
    public class GetBlockCountResponse : ErrorResponse
    {
        public string Reply { get; set; }
        public string Uuid { get; set; }
    }
}
