using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.CommonExceptions;
/// <summary>
/// error code -32600
/// </summary>
public class RpcInvalidRequestException : RpcException
{
    public RpcInvalidRequestException() : base("The RPC request is missing required fields or contains invalid field types.") { }
    public RpcInvalidRequestException(string message) : base(message) { }
    public RpcInvalidRequestException(string message, Exception innerException) : base(message, innerException) { }
}
