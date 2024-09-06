using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.Enum;
public enum TransactionState
{
    /// <summary>
    /// Transaction successfully created, awaiting confirmation (initial state 0).
    /// </summary>
    Created = 1,

    /// <summary>
    /// Transaction successfully completed (initial state 1).
    /// </summary>
    Completed = 2,

    /// <summary>
    /// Transaction canceled (initial state 1).
    /// </summary>
    Canceled = -1,

    /// <summary>
    /// Transaction canceled after completion (initial state 2).
    /// </summary>
    ReversedAfterCompletion = -2
}

