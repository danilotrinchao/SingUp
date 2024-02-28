using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RegisterApi.Application.DTOs;
using RegisterApi.Core.Contracts;
using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace RegisterApi.Infra.Data.ExternalService
{
    public class ServiceTwoIntegrationService : IServiceTwoIntegrationService
    {
        private static IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public ServiceTwoIntegrationService(IConfiguration configuration,IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> IntegrateWithServiceTwo(UsuarioInput usuarioInput)
        {
            try
            {
                // Configurar o HttpClient usando a fábrica
                var baseAddress = _configuration.GetSection("API:baseAddress");
                var httpClient = _httpClientFactory.CreateClient("ServiceTwo");         
                httpClient.BaseAddress = new Uri(baseAddress.Value);
                // Construir o corpo da requisição com os dados do usuário
                var requestBody = new StringContent(JsonConvert.SerializeObject(usuarioInput), Encoding.UTF8, "application/json");

                // Enviar os dados para a ServiceTwo
                var response = await httpClient.PostAsync("api/receiveData", requestBody);

                // Verificar a resposta e tratar conforme necessário
                if (response.IsSuccessStatusCode)
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();

                    var result = JsonSerializer.Deserialize<UsuarioOutput>(
                                    stringResponse,
                                    new JsonSerializerOptions
                                    {
                                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                                    });

                    return true;
                }
                else
                {
                    throw new HttpRequestException(response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Tratar exceção
                // Registrar a exceção para monitoramento e análise
                return false;
            }
        }
    }
}
