using ExternalServiceApi.Core.Contracts;
using ExternalServiceApi.Core.DTOs;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ExternalServiceApi.Infra.ExternalService
{
    public class ServiceTwoIntegrationService : IServiceTwoIntegrationService
    {
        private static IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public ServiceTwoIntegrationService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<DadosInput> GetUserData(int userId)
        {
            try
            {
                // Configurar o HttpClient usando a fábrica
                var baseAddress = _configuration.GetSection("API:baseAddress");
                var httpClient = _httpClientFactory.CreateClient("ServiceTwo");
                httpClient.BaseAddress = new Uri(baseAddress.Value);

                // Construir o corpo da requisição com os dados do usuário
                var requestBody = new { userId }; // Aqui você pode ajustar conforme a estrutura esperada pelo serviço

                // Converter o objeto para JSON
                var jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                // Construir a URL completa
                var apiUrl = "api/getUserId?userId=";
                var fullUrl = apiUrl + userId;

                // Enviar os dados para a ServiceTwo
                var response = await httpClient.GetAsync(fullUrl);

                // Verificar a resposta e tratar conforme necessário
                if (response.IsSuccessStatusCode)
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();

                    var result = JsonSerializer.Deserialize<DadosInput>(
                                    stringResponse,
                                    new JsonSerializerOptions
                                    {
                                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                                    });

                    return result;
                }
                else
                {
                    throw new HttpRequestException(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                // Tratar exceção
                // Registrar a exceção para monitoramento e análise
                throw new Exception(ex.Message);
            }
        }
    }
}
