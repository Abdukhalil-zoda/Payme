using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.CommonExceptions;
/// <summary>
/// error code -32700
/// </summary>
public class RpcJsonParsingException : RpcException
{
    public RpcJsonParsingException() : base("Error parsing JSON.") { }
    public RpcJsonParsingException(string message) : base(message) { }
    public RpcJsonParsingException(string message, Exception innerException) : base(message, innerException) { }
}
