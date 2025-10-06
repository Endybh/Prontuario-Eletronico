using Microsoft.AspNetCore.Mvc;

namespace SessionAppointment.Api.Controllers
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
