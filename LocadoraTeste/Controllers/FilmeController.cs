using LocadoraTeste.Model;
using LocadoraTeste.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LocadoraTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        [ApiController]
        [Route("api/[controller]")]
        public class ClienteController : ControllerBase
        {

            private IFilmeService _filmeService;
            private readonly ILogger<FilmeController> _logger;

            public ClienteController(ILogger<FilmeController> logger, IFilmeService filmeeService)
            {
                _logger = logger;
                _filmeService = filmeeService;
            }
            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_filmeService.FindAll());
            }
            [HttpGet("{id}")]
            public IActionResult Get(long id)
            {
                var cliente = _filmeService.FindById(id);
                if (cliente == null) return NotFound();
                return Ok(cliente);
            }
            [HttpPost]
            public IActionResult Post([FromBody] Filme filme)
            {
                if (filme == null) return BadRequest();
                return Ok(_filmeService.Create(filme));
            }
            [HttpPut]
            public IActionResult Put([FromBody] Filme filme)
            {
                if (filme == null) return BadRequest();
                return Ok(_filmeService.Update(filme));
            }
            [HttpDelete("{id}")]
            public IActionResult Delete(long id)
            {
                _filmeService.Delete(id);
                return NoContent();
            }
        }
    }
}
