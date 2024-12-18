using HealthNet.DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDManager.DAL.Entities
{
    public class UserPermission : IBaseEntity
    {
        [NotMapped]
        public int Id { get; set; }

        public bool IsActive { get; set; } = true;

        public int UserId { get; set; }

        public int PermissionId { get; set; }


        [ForeignKey("UserId")]
        public SystemUser User { get; set; }

    }
}
