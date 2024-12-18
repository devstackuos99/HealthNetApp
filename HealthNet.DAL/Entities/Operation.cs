using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthNet.DAL.Entities
{
    public class Operation : IBaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime OperationDate { get; set; }
        public string SurgeonName { get; set; }
        public string OperationType { get; set; }
        public decimal Cost { get; set; }

        [ForeignKey("AppointmentId")]
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
    }
}
