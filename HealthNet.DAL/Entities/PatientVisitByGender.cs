namespace HealthNet.DAL.Entities
{
    public class PatientVisitByGender : IBaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Gender { get; set; } 
        public int VisitCount { get; set; }
    }
}
