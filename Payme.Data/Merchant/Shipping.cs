using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant;
public class Shipping
{
    /// <summary>
    /// Title or description of the shipping.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// Price of the shipping in tiyin.
    /// </summary>
    [JsonPropertyName("price")]
    public required ulong Price { get; set; }
}
