using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payme.Merchant.Extended.OtherExceptions;
/// <summary>
/// Error code range -31050 to -31099: Errors related to invalid user input for the “account“ field.
/// For example, the entered login is not found, or the entered phone number is not found. 
/// The "message" field should contain a localized error message, and the "data" field should contain the "account" subfield.
/// </summary>
public class RpcInvalidUserInputException : RpcException
{
    public RpcInvalidUserInputException() : base("Invalid user input for the account field.") { }
    public RpcInvalidUserInputException(string message) : base(message) { }
    public RpcInvalidUserInputException(string message, Exception innerException) : base(message, innerException) { }
}
