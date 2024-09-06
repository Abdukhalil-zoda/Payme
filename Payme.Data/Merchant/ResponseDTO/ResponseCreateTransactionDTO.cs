using Payme.Data.Merchant.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.ResponseDTO;
public class ResponseCreateTransactionDTO
{
    /// <summary>
    /// Timestamp of when the transaction was created in the merchant's system (milliseconds since Unix epoch).
    /// </summary>
    [JsonPropertyName("create_time")]
    public long CreateTime { get; set; }

    /// <summary>
    /// Transaction number or identifier in the merchant's system. The format is determined by the merchant.
    /// </summary>
    [JsonPropertyName("transaction")]
    public required string MerchantTransactionId { get; set; }

    /// <summary>
    /// The state of the transaction.
    /// </summary>
    [JsonPropertyName("state")]
    public TransactionState State { get; set; }

    /// <summary>
    /// List of receivers. Optional parameter. If the app owner is the receiver, this field can be omitted or set to NULL.
    /// </summary>
    [JsonPropertyName("receivers")]
    public List<Receiver>? Receivers { get; set; }
}

