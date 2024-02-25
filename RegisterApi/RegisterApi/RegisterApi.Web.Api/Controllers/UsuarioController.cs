using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using RegisterApi.Application.DTOs;
using RegisterApi.Core.Contracts;

namespace RegisterApi.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        protected readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("[action]")]
        public async Task<UsuarioOutput> RegistrarUsuario(UsuarioInput args)
        {
            var result = await _usuarioService.CadastrarUsuario(args);
            return result;
        }
    }
}
