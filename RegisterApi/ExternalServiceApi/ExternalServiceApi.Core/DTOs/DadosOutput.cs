using ExternalServiceApi.Core.Contracts;

namespace ExternalServiceApi.Core.DTOs
{
    public class DadosOutput : ResponseMessage
    {
        public List<string> Errors { get; private set; }
        public DadosOutput(bool success, List<string> errors, string message = null) : base(success, message)
        {
            Errors = errors;
        }
    }
}
