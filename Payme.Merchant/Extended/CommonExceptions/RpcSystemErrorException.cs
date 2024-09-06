using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.CommonExceptions;
/// <summary>
/// error code -32400
/// </summary>
public class RpcSystemErrorException : RpcException
{
    public RpcSystemErrorException() : base("A system error occurred (e.g., database failure, file system failure).") { }
    public RpcSystemErrorException(string message) : base(message) { }
    public RpcSystemErrorException(string message, Exception innerException) : base(message, innerException) { }
}
