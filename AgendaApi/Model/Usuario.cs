using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AgendaAPI.ViewModel;

namespace AgendaAPI.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }

        public Usuario(UsuarioViewModel usuarioViewModel )
        {
            this.Login = usuarioViewModel.Login;
            this.Senha = usuarioViewModel.Senha;
        }
    }
}
