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
        public IActionResult GetMDR()
        {   
            List<Adquirente> list = _mdrService.GetMDRList();
            return Ok(list);
        }

        [HttpPost("transaction")]
        public IActionResult PostMDR([FromBody] Transacao transacao)
        {
            ResultadoTransacao result = _mdrService.CalcTransaction(transacao);
            return Ok(result);
        }
                
    }
}
