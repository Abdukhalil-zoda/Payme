using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.CommonExceptions;
/// <summary>
/// error code -32601
/// </summary>
public class RpcMethodNotFoundException : RpcException
{
    public RpcMethodNotFoundException() : base("The requested method was not found in the RPC request.") { }
    public RpcMethodNotFoundException(string message) : base(message) { }
    public RpcMethodNotFoundException(string message, Exception innerException) : base(message, innerException) { }
}
