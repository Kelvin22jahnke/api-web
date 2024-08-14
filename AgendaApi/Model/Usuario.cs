using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AgendaAPI.DTO;

namespace AgendaAPI.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }

        public Usuario(UsuarioDTO usuarioDTO )
        {
            this.Login = usuarioDTO.Login;
            this.Senha = usuarioDTO.Senha;
        }
    }
}
