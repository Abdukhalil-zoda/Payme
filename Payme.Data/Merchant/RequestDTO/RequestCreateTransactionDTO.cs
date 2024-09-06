using System.Text.Json.Serialization;

namespace Payme.Data.Merchant.RequestDTO;
public class RequestCreateTransactionDTO
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
    public required long Time { get; set; }

    /// <summary>
    /// Payment amount in tiyin (positive integer greater than zero).
    /// </summary>
    [JsonPropertyName("amount")]
    public required ulong Amount { get; set; }

    /// <summary>
    /// Customer account, represented as an abstract Account type.
    /// </summary>
    [JsonPropertyName("account")]
    public required Account Account { get; set; }
}
