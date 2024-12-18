using HealthNet.BL.Model.PatientVM;
using HealthNet.BL.Services.IServices;
using HealthNet.DAL.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace HealthNet.BL.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public PatientService(IPatientRepository patientRepository , IDepartmentRepository departmentRepository)
        {
            _patientRepository = patientRepository;
            _departmentRepository = departmentRepository;
        }

        public async Task<List<PatientGetResponseDto>> Get()
        {
            var patient = await _patientRepository.Get()
                .Include(p => p.Department)
                .ToListAsync();
            return patient.Select(x => new PatientGetResponseDto
            {
                Id = x.Id,
                FullName = x.FullName,
                ContactNumber = x.ContactNumber,
                Address = x.Address,
                DateOfBirth = x.DateOfBirth,
                Gender = x.Gender,
                Department = $"{x.Department.DepartmentName}",
            }).ToList();
        }
    }
}
