
using HealthNet.BL.Model.EarningVM;

namespace HealthNet.BL.Services.IServices
{
    public interface IEarningService
    {
        Task<List<EarningGetResponseDto>> Get();
    }
}
