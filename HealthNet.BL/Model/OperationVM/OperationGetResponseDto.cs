

namespace HealthNet.BL.Model.OperationVM
{
    public class OperationGetResponseDto
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime OperationDate { get; set; }
        public string SurgeonName { get; set; }
        public string OperationType { get; set; }
        public decimal Cost { get; set; }
        public int AppointmentId { get; set; }
    }
}
