namespace ServiceTwo.Core.DTOs
{
    public class UsuarioInput
    {
        public UsuarioInput() { }
        public UsuarioInput(string nome, string sobrenome, string email, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Telefone = telefone;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Dt_Alteracao { get; set; }
    }
}
