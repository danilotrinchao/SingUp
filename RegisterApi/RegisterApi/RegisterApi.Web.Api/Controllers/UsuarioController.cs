using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using RegisterApi.Application.DTOs;
using RegisterApi.Core.Contracts;

namespace RegisterApi.Web.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class UsuarioController : ControllerBase
    {
        protected readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<UsuarioOutput> RegistrarUsuario([FromBody]UsuarioInput args)
        {
            var result = await _usuarioService.CadastrarUsuario(args);
            return result;
        }
        [HttpGet("getUserId")]
        public async Task<IActionResult> GetUserId(int userId)
        {
            try
            {
                // Lógica para lidar com o cadastro na ServiceTwo
                var result = await _usuarioService.GetByUserId(userId);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // Trate exceção
                // Registre a exceção para monitoramento e análise
                return StatusCode(500, "Usuario não encontrado  em Register Api");
            }
        }
    }
}
