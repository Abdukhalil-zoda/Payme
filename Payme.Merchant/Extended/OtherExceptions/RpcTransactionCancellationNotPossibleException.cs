using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.OtherExceptions;
/// <summary>
/// Error code -31007: Unable to cancel the transaction. The goods or services have already been provided to the consumer in full.
/// </summary>
public class RpcTransactionCancellationNotPossibleException : RpcException
{
    public RpcTransactionCancellationNotPossibleException() : base("Unable to cancel the transaction. Goods or services have already been provided to the consumer.") { }
    public RpcTransactionCancellationNotPossibleException(string message) : base(message) { }
    public RpcTransactionCancellationNotPossibleException(string message, Exception innerException) : base(message, innerException) { }
}

