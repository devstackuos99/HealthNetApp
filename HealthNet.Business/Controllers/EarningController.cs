using HealthNet.BL.Services;
using HealthNet.BL.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace HealthNet.Business.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EarningController : ControllerBase
    {
        private readonly IEarningService _earningService;

        public EarningController(IEarningService earningService)
        {
            _earningService = earningService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _earningService.Get();
            return Ok(result);
        }
    }

}
