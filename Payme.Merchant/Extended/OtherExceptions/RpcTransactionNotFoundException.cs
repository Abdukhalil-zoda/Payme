using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.OtherExceptions;
/// <summary>
/// Error code -31003: Transaction not found.
/// </summary>
public class RpcTransactionNotFoundException : RpcException
{
    public RpcTransactionNotFoundException() : base("Transaction not found.") { }
    public RpcTransactionNotFoundException(string message) : base(message) { }
    public RpcTransactionNotFoundException(string message, Exception innerException) : base(message, innerException) { }
}

