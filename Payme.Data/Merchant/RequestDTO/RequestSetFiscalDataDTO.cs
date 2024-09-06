using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.RequestDTO;
public class RequestSetFiscalDataDTO
{
    /// <summary>
    /// Unique ID of the receipt in the Payme database.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Type of the receipt, either "PERFORM" for payment or "CANCEL" for cancellation.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Fiscal data of the receipt.
    /// </summary>
    [JsonPropertyName("fiscal_data")]
    public FiscalData FiscalData { get; set; }
}
