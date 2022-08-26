using MDRApi.Models;
using MDRApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MDRApi.Controllers
{
    [ApiController]    
    public class MDRController  : ControllerBase
    {
        private MDRService _mdrService;

        public MDRController()
        {
            _mdrService = new MDRService();
        }

        [HttpGet("mdr")]
        [Produces(typeof(List<AdquirenteModel>))]
        public IActionResult GetMDR()
        {   
            List<AdquirenteModel> list = _mdrService.GetMDRList();
            return Ok(list);
        }

        [HttpPost("transaction")]
        [Produces(typeof(ResultadoTransacaoModel))]
        public IActionResult PostMDR([FromBody] TransacaoModel transacao)
        {
            try
            {
                ResultadoTransacaoModel result = _mdrService.CalcTransaction(transacao);
                return Ok(result);
            }
            catch(Exception erro)
            {
                return BadRequest(new
                {
                    erro = erro.Message
                });
            }            
        }
                
    }
}
