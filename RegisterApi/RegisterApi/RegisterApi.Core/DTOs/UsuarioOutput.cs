using RegisterApi.Core.Contracts;

namespace RegisterApi.Application.DTOs
{
    public class UsuarioOutput : ResponseMessage
    {
        public List<string> Errors { get; private set; }
        public UsuarioOutput(bool success, List<string> errors, string message = null) : base(success, message)
        {
            Errors = errors;
        }
    }
}
