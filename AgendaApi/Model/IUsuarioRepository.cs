namespace AgendaAPI.Model
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);

        List<Usuario> GetAll();
    }
}
