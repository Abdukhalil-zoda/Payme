using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.RequestDTO;
public class RequestPerformTransactionDTO
{
    /// <summary>
    /// Unique identifier of the transaction in Payme Business.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}

