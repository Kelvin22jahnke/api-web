using AgendaAPI.infraestrutura;
using AgendaAPI.Model;

namespace AgendaAPI.Infraestrutura
{
    public class UsuarioRepository: IUsuarioRepository
    {
        private readonly ConexaoContext _conexaoContext = new ConexaoContext();

        public void Add(Usuario usuario)
        {
            _conexaoContext.Add(usuario);
            _conexaoContext.SaveChanges();
        }

        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = _conexaoContext.Usuarios.ToList();

            return usuarios;
        }
    }
}
