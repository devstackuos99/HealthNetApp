
using HealthNet.BL.Model.DepartmentVM;

namespace HealthNet.BL.Services.IServices
{
    public interface IDepartmentService
    {
        Task<List<DepartmentGetResponseDto>> Get();
    }
}
