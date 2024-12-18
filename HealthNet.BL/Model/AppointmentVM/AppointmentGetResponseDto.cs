
namespace HealthNet.BL.Model.AppointmentVM
{
    public class AppointmentGetResponseDto
    {
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string ReasonForVisit { get; set; }
        public string Patient { get; set; }

    }
}
