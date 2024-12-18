using HealthNet.DAL.Entities;
using HealthNet.DAL.Repositories.Abstraction;

namespace HealthNet.DAL.Repositories
{
    public class EarningRepository : BaseRepository<Earning>, IEarningRepository
    {
        public EarningRepository(HealthNetContext context) : base(context)
        {
        }
    }
}
