using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Prontuario_Eletronico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Open()
        {
            return Ok();
        }
    }
}
