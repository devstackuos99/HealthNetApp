using HealthNet.BL.Services.IServices;
using Microsoft.AspNetCore.Mvc;
namespace HealthNet.Business.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IPatientService _patientService;
        
        public AppointmentController(IAppointmentService appointmentService, IPatientService patientService)
        {
            _appointmentService = appointmentService;
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _appointmentService.Get();
            return Ok(result);
        }

    }
}
