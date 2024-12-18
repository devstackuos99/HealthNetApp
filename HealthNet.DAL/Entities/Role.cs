using HealthNet.DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace BDManager.DAL.Entities
{
    public class Role : IdentityRole<int>, IBaseEntity
    {
        public override int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public List<SystemUser> Users { get; set; } = new();

    }
}
