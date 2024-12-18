using HealthNet.DAL.Entities;

namespace BDManager.DAL.Entities
{
    public class Permission : IBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<SystemUser> Users { get; set; } = new();

        public int Id { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
