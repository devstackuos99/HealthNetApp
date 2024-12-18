
using HealthNet.BL.Model.DepartmentVM;
using HealthNet.BL.Services.IServices;
using HealthNet.DAL.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace HealthNet.BL.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentrepository;

        public DepartmentService(IDepartmentRepository departmentrepository)
        {
            _departmentrepository = departmentrepository;
        }
        public async Task<List<DepartmentGetResponseDto>> Get()
        {
            var department = await _departmentrepository.Get().ToListAsync();
            return department.Select(x => new DepartmentGetResponseDto
            {
                Id = x.Id,
                DepartmentName = x.DepartmentName,
            }).ToList();
                
        }
    }
}
