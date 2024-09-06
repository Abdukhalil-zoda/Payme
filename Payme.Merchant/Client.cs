using Payme.Data.Merchant.RequestDTO;
using Payme.Data.Merchant.ResponseDTO;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Payme.Merchant;
public class Client
{
    private const string _sandboxUrl = "https://test.paycom.uz/";
    private const string _prodUrl = "https://checkout.paycom.uz/";
    private readonly string _token;
    private readonly HttpClient _client;

    private string ToBase64(string plainText)
    {
        byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

        string base64String = Convert.ToBase64String(plainTextBytes);

        return base64String;
    }

    public Client(string Login, string Password, bool IsTest = false)
    {
        _token = ToBase64($"{Login}:{Password}");
        _client = new HttpClient()
        {
            BaseAddress = new Uri(IsTest ? _sandboxUrl : _prodUrl)
        };
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _token);
    }

    public async Task<ResponseBase<ResponseCreateTransactionDTO>> CreateTransactionAsync(RequestCreateTransactionDTO request, int id)
    {
        var requestBase = new RequestBase<RequestCreateTransactionDTO>()
        {
            Method = "CreateTransaction",
            Params = request,
            Id = id
        };

        var jsonRequest = JsonSerializer.Serialize(requestBase);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        var httpResponse = await _client.PostAsync("", content);

        var jsonResponse = await httpResponse.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<ResponseBase<ResponseCreateTransactionDTO>>(jsonResponse);
        return result!;

    }

    public async Task<ResponseBase<ResponsePerformTransactionDTO>> PerformTransactionAsync(RequestBase<RequestPerformTransactionDTO> request)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseBase<ResponseCheckPerformTransactionDTO>> CheckPerformTransactionAsync(RequestBase<RequestCheckPerformTransactionDTO> request)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseBase<ResponseCancelTransactionDTO>> CancelTransactionAsync(RequestBase<RequestCancelTransactionDTO> request)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseBase<ResponseCheckTransactionDTO>> CheckTransactionAsync(RequestBase<RequestCheckTransactionDTO> request)
    {
        throw new NotImplementedException();
    }
    public async Task<ResponseBase<ResponseGetStatementDTO>> GetStatementAsync(RequestBase<RequestGetStatementDTO> request)
    {
        throw new NotImplementedException();
    }
    public async Task<ResponseBase<ResponseSetFiscalDataDTO>> SetFiscalDataAsync(RequestBase<RequestSetFiscalDataDTO> request)
    {
        throw new NotImplementedException();
    }
}
