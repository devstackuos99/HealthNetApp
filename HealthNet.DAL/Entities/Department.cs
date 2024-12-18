namespace HealthNet.DAL.Entities
{
    public class Department : IBaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public string DepartmentName { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
