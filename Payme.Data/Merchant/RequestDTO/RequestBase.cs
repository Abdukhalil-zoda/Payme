using System.Text.Json.Serialization;

namespace Payme.Data.Merchant.RequestDTO;
public class RequestBase<T>
{
    [JsonPropertyName("method")]
    public required string Method { get; set; }

    [JsonPropertyName("params")]
    public required T Params { get; set; }

    [JsonPropertyName("id")]
    public required int Id { get; set; }

}
