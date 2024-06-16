using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaAPI.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Cliente(string nome) 
        {
            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }    
    }
}
