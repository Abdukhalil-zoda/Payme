using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.ResponseDTO;
public class ResponseGetStatementDTO
{
    /// <summary>
    /// List of transactions that were created within the specified time range.
    /// </summary>
    [JsonPropertyName("transaction")]
    public List<Transaction>? Transactions { get; set; }
}

