namespace HealthNet.DAL.Entities
{
    public class Earning : IBaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime DateTime { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
