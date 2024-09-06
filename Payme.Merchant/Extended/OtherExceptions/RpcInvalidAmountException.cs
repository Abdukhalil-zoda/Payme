using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.OtherExceptions;
/// <summary>
/// Error code -31001: Invalid amount. This error occurs when the transaction amount does not match the order amount. It is relevant for one-time invoices.
/// </summary>
public class RpcInvalidAmountException : RpcException
{
    public RpcInvalidAmountException() : base("Invalid amount. The transaction amount does not match the order amount.") { }
    public RpcInvalidAmountException(string message) : base(message) { }
    public RpcInvalidAmountException(string message, Exception innerException) : base(message, innerException) { }
}
