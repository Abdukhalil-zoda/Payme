using Payme.Data.Merchant.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended;
public class RpcException : Exception
{
    public required ErrorResponseDTO ErrorResponse { get; set; }
    public RpcException(string message) : base(message) { }
    public RpcException(string message, Exception innerException) : base(message, innerException) { }
}
