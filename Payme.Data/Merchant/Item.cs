using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant;
public class Item
{
    /// <summary>
    /// Discount amount in tiyin, considering the quantity of goods or services (optional).
    /// </summary>
    [JsonPropertyName("discount")]
    public ulong? Discount { get; set; }

    /// <summary>
    /// Name of the product or service.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// Price per unit of the product or service in tiyin.
    /// </summary>
    [JsonPropertyName("price")]
    public required ulong Price { get; set; }

    /// <summary>
    /// Quantity of the products or services.
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    /// <summary>
    /// Product or service identification code (IKPU).
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// Measurement unit code (optional).
    /// </summary>
    [JsonPropertyName("units")]
    public int? Units { get; set; }

    /// <summary>
    /// Packaging code of the product.
    /// </summary>
    [JsonPropertyName("package_code")]
    public required string PackageCode { get; set; }

    /// <summary>
    /// VAT percentage applicable to the product or service.
    /// </summary>
    [JsonPropertyName("vat_percent")]
    public required int VatPercent { get; set; }
}

