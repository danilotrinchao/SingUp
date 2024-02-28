using Microsoft.AspNetCore.Mvc;
using ServiceTwo.Core.Contracts;
using ServiceTwo.Core.DTOs;

namespace ServiceTwo.Web.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class SignUpController : Controller
    {
        private readonly ISignUpService _signUpService;

        public SignUpController(ISignUpService signUpService)
        {
           _signUpService = signUpService;
        }

        [HttpPost("receiveData")]
        public async Task<IActionResult> RegisterUser([FromBody] UsuarioInput usuarioInput)
        {
            try
            {
                // Lógica para lidar com o cadastro na ServiceTwo
                var result = await _signUpService.Register(usuarioInput);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // Trate exceção
                // Registre a exceção para monitoramento e análise
                return StatusCode(500, "Erro ao processar o cadastro em ServiceTwo");
            }
        }
        [HttpGet("getUserId")]
        public async Task<IActionResult> GetUserId(int userId)
        {
            try
            {
                // Lógica para lidar com o cadastro na ServiceTwo
                var result = await _signUpService.GetByUserId(userId);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // Trate exceção
                // Registre a exceção para monitoramento e análise
                return StatusCode(500, "Usuario não encontra  em Service Two");
            }
        }
    }
}
