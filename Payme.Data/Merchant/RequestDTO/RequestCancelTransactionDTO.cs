using Payme.Data.Merchant.Enum;
using System.Text.Json.Serialization;

namespace Payme.Data.Merchant.RequestDTO;

public class RequestCancelTransactionDTO
{
    /// <summary>
    /// Unique identifier of the transaction in Payme Business.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Reason for the cancellation of the transaction.
    /// </summary>
    [JsonPropertyName("reason")]
    public TransactionCancelReason Reason { get; set; }
}
