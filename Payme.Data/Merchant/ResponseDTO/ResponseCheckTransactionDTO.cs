using Payme.Data.Merchant.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.ResponseDTO;
public class ResponseCheckTransactionDTO
{
    /// <summary>
    /// Timestamp of when the transaction was added in the merchant's billing system (milliseconds since Unix epoch).
    /// </summary>
    [JsonPropertyName("create_time")]
    public long CreateTime { get; set; }

    /// <summary>
    /// Timestamp of when the transaction was performed in the merchant's billing system (milliseconds since Unix epoch).
    /// </summary>
    [JsonPropertyName("perform_time")]
    public long PerformTime { get; set; }

    /// <summary>
    /// Timestamp of when the transaction was canceled in the merchant's billing system (milliseconds since Unix epoch).
    /// </summary>
    [JsonPropertyName("cancel_time")]
    public long CancelTime { get; set; }

    /// <summary>
    /// Transaction number or identifier in the merchant's billing system.
    /// Format is defined by the merchant.
    /// </summary>
    [JsonPropertyName("transaction")]
    public required string MerchantTransactionId { get; set; }

    /// <summary>
    /// The state of the transaction.
    /// </summary>
    [JsonPropertyName("state")]
    public required TransactionState State { get; set; }

    /// <summary>
    /// Reason for the transaction completion or null.
    /// </summary>
    [JsonPropertyName("reason")]
    public TransactionCancelReason? Reason { get; set; }
}
