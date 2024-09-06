using Payme.Data.Merchant.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant;
public class Transaction
{
    /// <summary>
    /// Unique identifier of the transaction in Payme Business.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Timestamp of when the transaction was created in Payme Business (milliseconds since Unix epoch).
    /// </summary>
    [JsonPropertyName("time")]
    public ulong Time { get; set; }

    /// <summary>
    /// Payment amount in tiyin (positive integer greater than zero).
    /// </summary>
    [JsonPropertyName("amount")]
    public ulong Amount { get; set; }

    /// <summary>
    /// Customer account, represented as an abstract Account type.
    /// </summary>
    [JsonPropertyName("account")]
    public required Account Account { get; set; }

    /// <summary>
    /// Timestamp of when the transaction was added in the merchant's billing system.
    /// </summary>
    [JsonPropertyName("create_time")]
    public ulong CreateTime { get; set; }

    /// <summary>
    /// Timestamp of when the transaction was performed in the merchant's billing system.
    /// </summary>
    [JsonPropertyName("perform_time")]
    public ulong PerformTime { get; set; }

    /// <summary>
    /// Timestamp of when the transaction was canceled in the merchant's billing system.
    /// </summary>
    [JsonPropertyName("cancel_time")]
    public ulong CancelTime { get; set; }

    /// <summary>
    /// Transaction number or identifier in the merchant's billing system.
    /// Format is defined by the merchant.
    /// </summary>
    [JsonPropertyName("transaction")]
    public string? MerchantTransactionId { get; set; }

    /// <summary>
    /// State of the transaction.
    /// </summary>
    [JsonPropertyName("state")]
    public TransactionState State { get; set; }

    /// <summary>
    /// Optional field, reason for the transaction cancellation.
    /// </summary>
    [JsonPropertyName("reason")]
    public TransactionCancelReason? Reason { get; set; }

    /// <summary>
    /// List of receivers (optional). If the app owner is the receiver, this field should be null.
    /// </summary>
    [JsonPropertyName("receivers")]
    public List<Receiver>? Receivers { get; set; }
}

