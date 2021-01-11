using Blocknet.Lib.Services.Coins.Blocknet.XBridge;
using System.Collections.Generic;

namespace Blocknet.Lib.Services.Coins.Blocknet
{
    public interface IXBridgeService
    {
        List<string> dxGetNetworkTokens();

        List<GetTradingDataResponse> dxGetTradingData(int blocks, bool errors);
        List<GetOrdersResponse> dxGetOrders();
    }
}
