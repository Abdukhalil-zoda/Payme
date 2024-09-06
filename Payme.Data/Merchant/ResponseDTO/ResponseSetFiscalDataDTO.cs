using System.Text.Json.Serialization;

namespace Payme.Data.Merchant.ResponseDTO;
public class ResponseSetFiscalDataDTO
{
    /// <summary>
    /// Indicates if the fiscal data was successfully processed.
    /// If true, the operation was successful; otherwise, an error code is returned.
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}
