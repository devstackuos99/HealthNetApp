using HealthNet.BL.Model.AppointmentVM;

namespace HealthNet.BL.Services.IServices
{
    public interface IAppointmentService
    {
        Task<List<AppointmentGetResponseDto>> Get();
    }
}
