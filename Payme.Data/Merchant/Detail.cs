using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant;
public class Detail
{
    /// <summary>
    /// Type of receipt, e.g., Sale/Return = 0.
    /// </summary>
    [JsonPropertyName("receipt_type")]
    public required int ReceiptType { get; set; }

    /// <summary>
    /// Shipping details (optional).
    /// </summary>
    [JsonPropertyName("shipping")]
    public Shipping? Shipping { get; set; }

    /// <summary>
    /// List of items being sold or services provided (required for fiscalization).
    /// </summary>
    [JsonPropertyName("items")]
    public required List<Item> Items { get; set; }
}
