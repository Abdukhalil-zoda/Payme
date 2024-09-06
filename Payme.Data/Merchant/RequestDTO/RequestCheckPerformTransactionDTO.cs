using System.Text.Json.Serialization;

namespace Payme.Data.Merchant.RequestDTO;
public class RequestCheckPerformTransactionDTO
{
    /// <summary>
    /// The payment amount in tiyin (positive integer greater than zero).
    /// </summary>
    [JsonPropertyName("amount")]
    public required ulong Amount { get; set; }

    /// <summary>
    /// The customer account, represented as an abstract Account type.
    /// </summary>
    [JsonPropertyName("account")]
    public required Account Account { get; set; }
}
