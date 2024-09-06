using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant;
public class FiscalData
{
    /// <summary>
    /// Unique sequential number of the payment for the Virtual Fiscal Module.
    /// </summary>
    [JsonPropertyName("receipt_id")]
    public string ReceiptId { get; set; }

    /// <summary>
    /// Status code for the receipt.
    /// </summary>
    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; }

    /// <summary>
    /// Detailed error information (if an error occurred while registering the receipt with the fiscal module).
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Virtual Fiscal Module terminal number.
    /// </summary>
    [JsonPropertyName("terminal_id")]
    public string? TerminalId { get; set; }

    /// <summary>
    /// Fiscal sign of the payment receipt.
    /// </summary>
    [JsonPropertyName("fiscal_sign")]
    public string? FiscalSign { get; set; }

    /// <summary>
    /// URL address of the fiscal receipt.
    /// </summary>
    [JsonPropertyName("qr_code_url")]
    public string? QrCodeUrl { get; set; }

    /// <summary>
    /// Date of receipt registration on the side of the fiscal module.
    /// </summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }
}

