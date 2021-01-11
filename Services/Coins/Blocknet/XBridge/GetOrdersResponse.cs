using Newtonsoft.Json;

namespace Blocknet.Lib.Services.Coins.Blocknet.XBridge
{
    public class GetOrdersResponse
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        [JsonProperty("maker_size")]
        public string MakerSize { get; set; }
        public string Taker { get; set; }
        [JsonProperty("taker_size")]
        public string TakerSoze { get; set; }
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("order_type")]
        public string OrderType { get; set; }
        [JsonProperty("partial_minimum")]
        public string PartialMinimum { get; set; }
        [JsonProperty("partial_repost")]
        public bool PartialRepost { get; set; }
        public string Status { get; set; }
    }
}
