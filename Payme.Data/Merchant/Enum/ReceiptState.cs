using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.Enum;
public enum ReceiptState
{
    /// <summary>
    /// Receipt created. Waiting for payment confirmation.
    /// </summary>
    Created = 0,

    /// <summary>
    /// First stage of verification. Creating a transaction in the merchant's billing system.
    /// </summary>
    InitialVerification = 1,

    /// <summary>
    /// Money debited from the card.
    /// </summary>
    Debited = 2,

    /// <summary>
    /// Closing the transaction in the merchant's billing system.
    /// </summary>
    MerchantBillingClosure = 3,

    /// <summary>
    /// Receipt paid.
    /// </summary>
    Paid = 4,

    /// <summary>
    /// Receipt on hold.
    /// </summary>
    OnHold = 5,

    /// <summary>
    /// Receiving a command to hold the receipt, then it moves to status 5.
    /// If the receipt remains stuck in this status for too long, contact Payme Business technical specialists.
    /// </summary>
    HoldingInitiated = 6,

    /// <summary>
    /// Receipt is paused for manual intervention.
    /// </summary>
    PausedForManualIntervention = 20,

    /// <summary>
    /// Receipt is in the queue for cancellation.
    /// </summary>
    QueuedForCancellation = 21,

    /// <summary>
    /// Receipt is in the queue for transaction closure in the merchant's billing system.
    /// </summary>
    QueuedForClosure = 30,

    /// <summary>
    /// Receipt canceled.
    /// </summary>
    Canceled = 50
}

