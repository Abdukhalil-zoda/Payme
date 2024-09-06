using Payme.Data.Merchant.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.ResponseDTO;
public class ResponsePerformTransactionDTO
{
    /// <summary>
    /// Transaction number or identifier in the merchant's system.
    /// </summary>
    [JsonPropertyName("transaction")]
    public required string Transaction { get; set; }

    /// <summary>
    /// Timestamp of when the transaction was performed in the merchant's system (milliseconds since Unix epoch).
    /// </summary>
    [JsonPropertyName("perform_time")]
    public long PerformTime { get; set; }

    /// <summary>
    /// The state of the transaction.
    /// </summary>
    [JsonPropertyName("state")]
    public TransactionState State { get; set; }
}
