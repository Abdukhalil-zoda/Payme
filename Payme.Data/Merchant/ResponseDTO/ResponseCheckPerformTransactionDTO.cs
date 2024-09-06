using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.ResponseDTO;
public class ResponseCheckPerformTransactionDTO
{
    /// <summary>
    /// If true, the transaction can be performed. Otherwise, the method returns errors.
    /// </summary>
    [JsonPropertyName("allow")]

    public bool Allow { get; set; }
    /// <summary>
    /// An optional object that can contain additional information from the provider's billing system (e.g., user balance, order data).
    /// </summary>
    [JsonPropertyName("additional")]
    public Additional? Additional { get; set; }

    /// <summary>
    /// Detail object containing data about goods or services for receipt fiscalization.
    /// </summary>
    [JsonPropertyName("detail")]
    public Detail? Detail { get; set; }

}
