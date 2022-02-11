using LocadoraTeste.Model;
using LocadoraTeste.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LocadoraTeste.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
  
        private IClienteService _clienteService;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger, IClienteService clienteService)
        {
            _logger = logger;
            _clienteService = clienteService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clienteService.FindAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var cliente = _clienteService.FindById(id);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            if (cliente == null) return BadRequest();
            return Ok(_clienteService.Create(cliente));
        }
        [HttpPut]
        public IActionResult Put([FromBody] Cliente cliente)
        {
            if (cliente == null) return BadRequest();
            return Ok(_clienteService.Update(cliente));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _clienteService.Delete(id);
            return NoContent();
        }
    }
}
