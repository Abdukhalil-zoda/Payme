using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.CommonExceptions;
/// <summary>
/// error code -32504
/// </summary>
public class RpcInsufficientPrivilegesException : RpcException
{
    public RpcInsufficientPrivilegesException() : base("Insufficient privileges to execute the requested method.") { }
    public RpcInsufficientPrivilegesException(string message) : base(message) { }
    public RpcInsufficientPrivilegesException(string message, Exception innerException) : base(message, innerException) { }
}
