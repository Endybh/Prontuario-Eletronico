using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Prontuario_Eletronico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProntuarioController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Abrir()
        {
            return Ok();
        }
    }
}
