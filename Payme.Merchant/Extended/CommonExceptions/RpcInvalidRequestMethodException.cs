using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.CommonExceptions;
/// <summary>
/// error code -32300
/// </summary>
public class RpcInvalidRequestMethodException : RpcException
{
    public RpcInvalidRequestMethodException() : base("The RPC request is missing required fields or the field types do not match the specification.") { }
    public RpcInvalidRequestMethodException(string message) : base(message) { }
    public RpcInvalidRequestMethodException(string message, Exception innerException) : base(message, innerException) { }
}

