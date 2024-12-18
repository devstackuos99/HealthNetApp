using HealthNet.BL.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace HealthNet.Business.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _departmentService.Get();
            return Ok(result);
        }
    }
}
