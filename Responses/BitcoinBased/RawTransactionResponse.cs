using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.Responses.SharedComponents;

namespace Blocknet.Lib.Responses
{
    public class RawTransactionResponse : GetRawTransactionResponse
    {
        public int Size { get; set; }
    }
}