using System.ComponentModel.DataAnnotations;
using System.Net;
using IntegraBrasilApi.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]  
    public class TaxasController : ControllerBase
    {
        public readonly ITaxasService _taxasService;

        public TaxasController(ITaxasService taxaService)
        {
            _taxasService = taxaService;
        }

        [HttpGet("busca/todos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodos() 
        {
            var response = await _taxasService.BuscarTodasTaxas();

            if(response.CodigoHttp == System.Net.HttpStatusCode.OK) 
            {
                return Ok(response.DadosRetorno);
            }
            else 
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }

        [HttpGet("busca/{sigla}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Buscar(string sigla) 
        {
            var response = await _taxasService.BuscarTaxas(sigla);

            if(response.CodigoHttp == HttpStatusCode.OK) 
            {
                return Ok(response.DadosRetorno);
            }
            else 
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }        
    }
}