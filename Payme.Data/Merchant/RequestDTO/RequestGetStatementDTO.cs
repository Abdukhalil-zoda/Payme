using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.RequestDTO;
public class RequestGetStatementDTO
{
    /// <summary>
    /// Timestamp representing the start of the period (milliseconds since Unix epoch).
    /// </summary>
    [JsonPropertyName("from")]
    public long From { get; set; }

    /// <summary>
    /// Timestamp representing the end of the period (milliseconds since Unix epoch).
    /// </summary>
    [JsonPropertyName("to")]
    public long To { get; set; }
}

