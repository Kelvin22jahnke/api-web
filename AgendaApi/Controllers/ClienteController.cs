using AgendaAPI.DTO;
using AgendaAPI.Infraestrutura.Interface;
using AgendaAPI.Model;
using AgendaAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AgendaAPI.Controllers
{
    [ApiController]
    [Route("api/v1/cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }

        [HttpPost]
        public IActionResult Add(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente(clienteDTO);
            _clienteRepository.Add(cliente);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            List<Cliente> clientes = _clienteRepository.GetAll();
            return Ok(clientes);
        }
    }
}
