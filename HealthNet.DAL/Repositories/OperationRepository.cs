
using HealthNet.DAL.Entities;
using HealthNet.DAL.Repositories.Abstraction;

namespace HealthNet.DAL.Repositories
{
    public class OperationRepository : BaseRepository<Operation>, IOperationRepository
    {
        public OperationRepository(HealthNetContext context) : base(context)
        {
        }
    }
}
