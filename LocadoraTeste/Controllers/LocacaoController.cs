using LocadoraTeste.Data;
using LocadoraTeste.Model;
using LocadoraTeste.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocacaoController : ControllerBase
    {
        private ILocacaoService _locacaoService;
        private readonly ILogger<LocacaoController> _logger;

        public LocacaoController(ILogger<LocacaoController> logger, ILocacaoService locacaoService)
        {
            _logger = logger;
            _locacaoService = locacaoService;
        }
        [HttpGet]
            public IActionResult Get()
            {
                return Ok(_locacaoService.FindAll());
            }
            [HttpGet("{id}")]
            public IActionResult Get(long id)
            {
                var cliente = _locacaoService.FindById(id);
                if (cliente == null) return NotFound();
                return Ok(cliente);
            }
            [HttpPost]
            public IActionResult Post([FromBody] Locacao locacao)
            {
                if (locacao == null) return BadRequest();
                return Ok(_locacaoService.Create(locacao));
            } 
        } 
    }
