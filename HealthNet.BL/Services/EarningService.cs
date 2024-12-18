
using HealthNet.BL.Model.EarningVM;
using HealthNet.BL.Services.IServices;
using HealthNet.DAL.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace HealthNet.BL.Services
{
    public class EarningService : IEarningService
    {
        private readonly IEarningRepository _earningRepository;

        public EarningService(IEarningRepository earningRepository)
        {
            _earningRepository = earningRepository;
        }
        public async Task <List<EarningGetResponseDto>> Get()
        {
            var earn = await _earningRepository.Get().ToListAsync();
            return earn.Select(e => new EarningGetResponseDto
            {
                Id = e.Id,
                DateTime = e.DateTime,
                TotalAmount = e.TotalAmount,
            }).ToList();
        }
    }
}
