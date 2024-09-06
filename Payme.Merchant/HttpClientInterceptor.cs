using Payme.Data.Merchant.ResponseDTO;
using Payme.Merchant.Extended.CommonExceptions;
using Payme.Merchant.Extended.OtherExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Payme.Merchant;
public class HttpClientInterceptor : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("X-Custom-Header", "MyCustomValue");

        var response = await base.SendAsync(request, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var errorResponse = JsonSerializer.Deserialize<ErrorResponseDTO>(jsonResponse);

            switch (errorResponse!.Error!.Code)
            {
                case -32300:
                    throw new RpcInvalidRequestMethodException() { ErrorResponse = errorResponse};
                case -32700:
                    throw new RpcJsonParsingException() { ErrorResponse = errorResponse };
                case -32600:
                    throw new RpcInvalidRequestException() { ErrorResponse = errorResponse };
                case -32601:
                    throw new RpcMethodNotFoundException() { ErrorResponse = errorResponse };
                case -32504:
                    throw new RpcInsufficientPrivilegesException() { ErrorResponse = errorResponse };
                case -32400:
                    throw new RpcSystemErrorException() { ErrorResponse = errorResponse };

                case -31001:
                    throw new RpcInvalidAmountException() { ErrorResponse = errorResponse };
                case -31003:
                    throw new RpcTransactionNotFoundException() { ErrorResponse = errorResponse };
                case -31007:
                    throw new RpcSystemErrorException() { ErrorResponse = errorResponse };
                case -31008:
                    throw new RpcSystemErrorException() { ErrorResponse = errorResponse };
                case int code when code >= -31050 && code <= -31099:
                    throw new RpcInvalidUserInputException() { ErrorResponse = errorResponse };

                default:
                    throw new Exception("Unknown error occurred.");
            }
        }

        return response;
    }

}
