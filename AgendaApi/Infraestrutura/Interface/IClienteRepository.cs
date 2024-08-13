using AgendaAPI.Model;

namespace AgendaAPI.Infraestrutura.Interface
{
    public interface IClienteRepository
    {
        void Add(Cliente cliente);

        List<Cliente> GetAll();
    }
}
