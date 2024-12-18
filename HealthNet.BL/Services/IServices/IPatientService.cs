
using HealthNet.BL.Model.PatientVM;

namespace HealthNet.BL.Services.IServices
{
    public interface IPatientService
    {
        Task<List<PatientGetResponseDto>> Get();
    }
}
