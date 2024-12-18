namespace HealthNet.DAL.Entities
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
