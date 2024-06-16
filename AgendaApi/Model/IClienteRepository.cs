namespace AgendaAPI.Model
{
    public interface IClienteRepository
    {
        void Add(Cliente cliente);

        List<Cliente> GetAll();
    }
}
