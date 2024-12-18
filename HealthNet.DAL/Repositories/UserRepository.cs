
using BDManager.DAL.Entities;
using HealthNet.DAL.Repositories.Abstraction;

namespace HealthNet.DAL.Repositories
{
    public class UserRepository : BaseRepository<SystemUser>, IUserRepository
    {
        public UserRepository(HealthNetContext context) : base(context)
        {
        }
    }
}
