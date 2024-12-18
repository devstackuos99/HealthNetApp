using HealthNet.DAL.Entities;
using HealthNet.DAL.Repositories.Abstraction;
namespace HealthNet.DAL.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(HealthNetContext context) : base(context)
        {
        }
    }
}
