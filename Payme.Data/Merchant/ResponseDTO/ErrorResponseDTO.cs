using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Payme.Data.Merchant.ResponseDTO;
public class ErrorResponseDTO
{

    [JsonPropertyName("error")]
    public ErrorDTO? Error { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
