using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.XBridge
{
    public class GetTradingDataResponse
    {
        public long Timestamp { get; set; }
        [JsonProperty("fee_txid")]
        public string FeeTxId { get; set; }
        public string NodePubKey { get; set; }
        public string Id { get; set; }
        public string Taker { get; set; }
        [JsonProperty("taker_size")]
        public decimal TakerSize { get; set; }
        public string Maker { get; set; }
        [JsonProperty("maker_size")]
        public decimal MakerSize { get; set; }
    }
}
