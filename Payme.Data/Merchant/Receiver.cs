using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant;
public class Receiver
{
    /// <summary>
    /// A string of 24 characters representing a unique identifier in the Payme Business system.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// A positive, unsigned integer representing the payment amount in tiyin.
    /// </summary>
    [JsonPropertyName("amount")]
    public required ulong Amount { get; set; }
}
