using AgendaAPI.Infraestrutura.DB;
using AgendaAPI.Infraestrutura.Interface;
using AgendaAPI.Model;

namespace AgendaAPI.infraestrutura
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ConexaoContext _conexaoContext = new ConexaoContext();

        public void Add(Cliente cliente)
        {
            _conexaoContext.Add(cliente);
            _conexaoContext.SaveChanges();
        }

        public List<Cliente> GetAll()
        {
            List<Cliente> clientes = _conexaoContext.Clientes.ToList();

            return clientes;
        }
    }
}
