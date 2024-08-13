using AgendaAPI.Model;

namespace AgendaAPI.Infraestrutura.Interface
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);

        List<Usuario> GetAll();
    }
}
