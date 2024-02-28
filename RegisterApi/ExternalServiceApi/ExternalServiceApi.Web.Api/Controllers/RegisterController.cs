using ExternalServiceApi.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ExternalServiceApi.Web.Api.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRegisterService _registerService;
        private readonly IServiceTwoIntegrationService _serviceTwoIntegrationService;
        private readonly IRegisterApiIntegrationService _registerApiIntegrationService;
        public RegisterController(IRegisterService registerService, IServiceTwoIntegrationService serviceTwoIntegrationService, IRegisterApiIntegrationService registerApiIntegrationService)
        {
            _registerService = registerService;
            _serviceTwoIntegrationService = serviceTwoIntegrationService;
            _registerApiIntegrationService = registerApiIntegrationService;
        }

        [HttpGet("getUser")]
        public async Task<IActionResult> GetUser(int userId)
        {
            try
            {
                // Lógica para lidar com o cadastro na ServiceTwo
                var result = await _registerService.GetPreviousDataAsync(userId);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // Trate exceção
                // Registre a exceção para monitoramento e análise
                return StatusCode(500, "Erro ao processar o recuperar dados em ServiceTwo");
            }
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                // Lógica para lidar com o cadastro na ServiceTwo
                var result = await _registerService.GetAll();

                return Ok(result);
            }
            catch (Exception ex)
            {
                // Trate exceção
                // Registre a exceção para monitoramento e análise
                return StatusCode(500, "Erro ao processar o recuperar dados em ServiceTwo");
            }
        }

        [HttpGet("getServiceTwo")]
        public async Task<IActionResult> GetUserIdInServiceTwo(int userId)
        {
            try
            {
                // Lógica para lidar com o cadastro na ServiceTwo
                var result = await _serviceTwoIntegrationService.GetUserData(userId);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // Trate exceção
                // Registre a exceção para monitoramento e análise
                return StatusCode(500, "Erro ao processar o recuperar dados em ServiceTwo");
            }
        }

        [HttpGet("getRegisterApi")]
        public async Task<IActionResult> GetUserIdInRegisterApi(int userId)
        {
            try
            {
                // Lógica para lidar com o cadastro na ServiceTwo
                var result = await _registerApiIntegrationService.GetUserData(userId);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // Trate exceção
                // Registre a exceção para monitoramento e análise
                return StatusCode(500, "Erro ao processar o recuperar dados em ServiceTwo");
            }
        }
    }
}
