// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using Blocknet.Lib.CoinParameters.Base;
using Blocknet.Lib.Services.RpcServices.RpcExtenderService;
using Blocknet.Lib.Services.RpcServices.RpcService;

namespace Blocknet.Lib.Services.Coins.Base
{
    public interface ICoinService : IRpcService, IRpcExtenderService, ICoinParameters
    {
    }
}