using Blocknet.Lib.RPC.Specifications;
using Blocknet.Lib.Services.Coins.Blocknet.XBridge;
using System.Collections.Generic;

namespace Blocknet.Lib.Services.Coins.Blocknet
{
    /// <summary>
    /// Mostly the same functionality as <see cref="BitcoinService"/>, just adds a bunch more features
    /// for handling InstantSend and PrivateSend, plus better raw tx generation support.
    /// </summary>
    public class XBridgeService : BlocknetService, IXBridgeService
    {
        public XBridgeService(bool useTestnet = false) : base(useTestnet) { }

        public XBridgeService(string daemonUrl, string rpcUsername, string rpcPassword,
            string walletPassword) : base(daemonUrl, rpcUsername, rpcPassword, walletPassword) { }

        public XBridgeService(string daemonUrl, string rpcUsername, string rpcPassword,
            string walletPassword, short rpcRequestTimeoutInSeconds) : base(daemonUrl, rpcUsername,
            rpcPassword, walletPassword, rpcRequestTimeoutInSeconds)
        { }

        public List<string> dxGetNetworkTokens()
        {
            return _rpcConnector.MakeRequest<List<string>>(RpcMethods.dxGetNetworkTokens);
        }

        public List<GetTradingDataResponse> dxGetTradingData(int blocks, bool errors = false)
        {
            return _rpcConnector.MakeRequest<List<GetTradingDataResponse>>(RpcMethods.dxGetTradingData, blocks, errors);
        }

        public List<GetOrdersResponse> dxGetOrders()
        {
            return _rpcConnector.MakeRequest<List<GetOrdersResponse>>(RpcMethods.dxGetOrders);
        }
    }
}
