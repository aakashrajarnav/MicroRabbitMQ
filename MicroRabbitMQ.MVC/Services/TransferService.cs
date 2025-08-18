using MicroRabbit.MVC.Models.DTO;
using Microsoft.Extensions.Options;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _httpClient;
        private readonly string _bankingApi;

        public TransferService(HttpClient httpClient, IOptions<ApiSettings> options)
        {
            _httpClient = httpClient;
            _bankingApi = options.Value.BankingApi;
        }

        public async Task Transfer(TransferDto transferDto)
        {
            var uri = _bankingApi;
            var transferContent = new StringContent(
                System.Text.Json.JsonSerializer.Serialize(transferDto),
                System.Text.Encoding.UTF8,
                "application/json");
            var response = await _httpClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
