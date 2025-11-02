using System.ComponentModel.DataAnnotations;

namespace CadastroUsuarioAPI.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}

