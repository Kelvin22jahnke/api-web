using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AgendaAPI.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }

        public Usuario(string login, string senha)
        {
            this.Login = login ?? throw new ArgumentNullException(nameof(login));
            this.Senha = senha ?? throw new ArgumentNullException(nameof(login));
        }
    }
}
