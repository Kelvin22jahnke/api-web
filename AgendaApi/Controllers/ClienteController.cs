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
        public IActionResult Add(ClienteViewModel clienteViewModel)
        {
            var cliente = new Cliente(clienteViewModel.Nome);
            _clienteRepository.Add(cliente);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var clientes = _clienteRepository.GetAll();
            return Ok(clientes);
        }
    }
}
