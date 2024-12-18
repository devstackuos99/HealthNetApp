using HealthNet.BL.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthNet.Business.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly IOperationService _operationService;
        private readonly IAppointmentService _appointmentService;

        public OperationController(IOperationService operationService, IAppointmentService appointmentService)
        {
            _operationService = operationService;
            _appointmentService = appointmentService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _operationService.Get();
            return Ok(result);
        }
    }
}
