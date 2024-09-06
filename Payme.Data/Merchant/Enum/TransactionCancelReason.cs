using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.Enum;
public enum TransactionCancelReason
{
    /// <summary>
    /// One or more recipients were not found or are inactive in Payme Business.
    /// </summary>
    RecipientNotFoundOrInactive = 1,

    /// <summary>
    /// Error during the debit operation at the processing center.
    /// </summary>
    DebitOperationError = 2,

    /// <summary>
    /// Transaction execution error.
    /// </summary>
    TransactionExecutionError = 3,

    /// <summary>
    /// Transaction canceled due to timeout.
    /// </summary>
    TimeoutCancellation = 4,

    /// <summary>
    /// Money refunded.
    /// </summary>
    Refund = 5,

    /// <summary>
    /// Unknown error.
    /// </summary>
    UnknownError = 10
}

