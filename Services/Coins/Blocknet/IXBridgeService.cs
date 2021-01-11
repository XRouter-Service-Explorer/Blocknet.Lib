using Blocknet.Lib.Services.Coins.Blocknet.XBridge;
using System.Collections.Generic;

namespace Blocknet.Lib.Services.Coins.Blocknet
{
    public interface IXBridgeService
    {
        List<string> xrGetLocalTokens();

        List<GetTradingDataResponse> xrGetTradingData(int blocks, bool errors);
        List<GetOrdersResponse> xrGetOrders();
    }
}
