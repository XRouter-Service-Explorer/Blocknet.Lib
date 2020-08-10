using System.Collections.Generic;
using Blocknet.Lib.CoinParameters.Blocknet;
using Blocknet.Lib.Services.Coins.Base;
using Blocknet.Lib.Services.Coins.Blocknet;
using Blocknet.Lib.Services.Coins.Blocknet.Xrouter;
using Blocknet.Lib.Services.Coins.Blocknet.Xrouter.BitcoinBased;
using Xrouter.Service.Explorer.BitcoinLib.Services.Coins.Blocknet.XRouter;

public interface IXCloudService : ICoinService, IBlocknetConstants{
    ServiceResponse xrService(string service, object[] parameters);
}
