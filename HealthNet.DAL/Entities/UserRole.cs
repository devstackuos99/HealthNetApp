using HealthNet.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDManager.DAL.Entities
{
    public class UserRole : IdentityUserRole<int>, IBaseEntity
    {
        public SystemUser User { get; set; }
        public Role Role { get; set; }

        [NotMapped]
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
