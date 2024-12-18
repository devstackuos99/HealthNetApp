using HealthNet.BL.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthNet.Business.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        private readonly IDepartmentService _departmentService;

        public PatientController(IPatientService patientService, IDepartmentService departmentService)
        {
            _patientService = patientService;
            _departmentService = departmentService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _patientService.Get();
            return Ok(result);
        }
    }
}
