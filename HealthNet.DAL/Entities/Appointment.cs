
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthNet.DAL.Entities
{
    public class Appointment : IBaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime AppointmentDate { get; set; }
        public string DoctorName { get; set; }
        public string ReasonForVisit { get; set; }

        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public List<Operation> Operations { get; set; }
    }
}
