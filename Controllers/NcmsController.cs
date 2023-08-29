using System.ComponentModel.DataAnnotations;
using System.Net;
using IntegraBrasilApi.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")] 
    public class NcmsController : ControllerBase
    {
        public readonly INcmsService _ncmsService;

         public NcmsController(INcmsService ncmsServices)
         {
            _ncmsService = ncmsServices;
         }

         [HttpGet("busca/todos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

         public async Task<IActionResult> BuscarTodos() 
        {
            var response = await _ncmsService.BuscarTodos();

            if(response.CodigoHttp == System.Net.HttpStatusCode.OK) 
            {
                return Ok(response.DadosRetorno);
            }
            else 
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }

        [HttpGet("busca/{codigoNcms}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Buscar([RegularExpression("^[0-9]*$")] string codigoNcms) 
        {
            var response = await _ncmsService.BuscarNcms(codigoNcms);

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