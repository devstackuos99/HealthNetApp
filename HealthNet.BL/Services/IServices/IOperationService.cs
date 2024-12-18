using HealthNet.BL.Model.OperationVM;

namespace HealthNet.BL.Services.IServices
{
    public interface IOperationService
    {
        Task<List<OperationGetResponseDto>> Get();
    }
}
