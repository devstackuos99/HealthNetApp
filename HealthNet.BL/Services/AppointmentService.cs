
using HealthNet.BL.Model.AppointmentVM;
using HealthNet.BL.Services.IServices;
using HealthNet.DAL.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace HealthNet.BL.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IPatientRepository _patientRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository, IPatientRepository patientRepository)
        {
            _appointmentRepository = appointmentRepository;
            _patientRepository = patientRepository;
        }

        public async Task<List<AppointmentGetResponseDto>> Get()
        {
            var appointment = await _appointmentRepository.Get()
                .Include(a => a.Patient)
                .ToListAsync();
            if (appointment == null)
            {
                return null;
            }
            var result =appointment.Select(x => new AppointmentGetResponseDto
            {
                Id = x.Id,
                DoctorName = x.DoctorName,
                AppointmentDate = x.AppointmentDate,
                ReasonForVisit = x.ReasonForVisit,
                Patient = $"{x.Patient.FullName}"
            }).ToList();
            return result;
        }
    }
}
