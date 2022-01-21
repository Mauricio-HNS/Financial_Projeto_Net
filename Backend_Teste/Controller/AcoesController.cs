using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Backend_Teste_Domain.Models;
using Backend_Teste_Domain.Services;

namespace Backend_Teste.Controllers
{
    [ApiController]
    [Route("investimentos")]
    public class AcoesController : ControllerBase
    {
        private readonly ILogger<AcoesController> _logger;
        private readonly IAcoesService _service;

        public AcoesController(ILogger<AcoesController> logger, IAcoesService service)
        {
            _logger = logger;
            _service = service;
        }

        [Route("cadastro")]
        [HttpPost]
        public IActionResult CadastroAcoes([FromBody] NovaAcao request)
        {
            try
            {
                _service.CadastroAcoes(request);

                return Created("", request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("cotacao")]
        [HttpGet]
        public IActionResult CotacaoAcao()
        {
            try
            {
                var cotacao = _service.CotacaoAcao();

                return Ok(cotacao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("compra")]
        [HttpPost]
        public IActionResult CompraAcao([FromBody] ComprarAcao request)
        {
            try
            {
                _service.ComprarAcao(request);

                return Created("", request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("venda")]
        [HttpPost]
        public IActionResult VendaAcao([FromBody] VendaAcao request)
        {
            try
            {
                _service.VendaAcao(request);

                return Created("", request);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
