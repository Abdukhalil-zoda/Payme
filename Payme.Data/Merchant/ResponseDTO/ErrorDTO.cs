using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.ResponseDTO;
public class ErrorDTO
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("message")]
    public Message? Message { get; set; }

    [JsonPropertyName("data")]
    public dynamic? Data { get; set; }
}

public class Message
{
    [JsonPropertyName("ru")]
    public string? Ru { get; set; }

    [JsonPropertyName("uz")]
    public string? Uz { get; set; }

    [JsonPropertyName("en")]
    public string? En { get; set; }
}