using System.ComponentModel.DataAnnotations.Schema;
namespace HealthNet.DAL.Entities
{
    public class Patient : IBaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public string FullName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } 

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
