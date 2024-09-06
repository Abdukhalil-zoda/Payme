using Payme.Data.Merchant.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.ResponseDTO;
public class ResponseCancelTransactionDTO
{
    /// <summary>
    /// Transaction number or identifier in the merchant's billing system.
    /// Format is defined by the merchant.
    /// </summary>
    [JsonPropertyName("transaction")]
    public required string MerchantTransactionId { get; set; }

    /// <summary>
    /// Timestamp of when the transaction was canceled (milliseconds since Unix epoch).
    /// </summary>
    [JsonPropertyName("cancel_time")]
    public long CancelTime { get; set; }

    /// <summary>
    /// The state of the transaction.
    /// </summary>
    [JsonPropertyName("state")]
    public TransactionState State { get; set; }
}
