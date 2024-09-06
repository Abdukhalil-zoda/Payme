using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.OtherExceptions;
/// <summary>
/// Error code -31008: Unable to perform the operation. This error occurs if the transaction state does not allow the operation to be performed.
/// </summary>
public class RpcTransactionOperationNotPossibleException : RpcException
{
    public RpcTransactionOperationNotPossibleException() : base("Unable to perform the operation. The transaction state does not allow this operation.") { }
    public RpcTransactionOperationNotPossibleException(string message) : base(message) { }
    public RpcTransactionOperationNotPossibleException(string message, Exception innerException) : base(message, innerException) { }
}

