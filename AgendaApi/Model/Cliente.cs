using AgendaAPI.DTO;
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
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }

        public Cliente(ClienteDTO clienteDTO) 
        {
            this.Nome = clienteDTO.Nome;
            this.Endereco = clienteDTO.Endereco;
            this.Telefone = clienteDTO.Telefone;
        }    
    }
}
