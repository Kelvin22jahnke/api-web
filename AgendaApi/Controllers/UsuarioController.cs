using AgendaAPI.DTO;
using AgendaAPI.Infraestrutura.Interface;
using AgendaAPI.Model;
using AgendaAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AgendaAPI.Controllers
{
    [ApiController]
    [Route("api/v1/usuario")]
    public class UsuarioController : Controller
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this._usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public IActionResult Add(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario(usuarioDTO);
            _usuarioRepository.Add(usuario);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Usuario> usuarios = _usuarioRepository.GetAll();
            return Ok(usuarios);
        }
    }
}
