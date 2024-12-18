
namespace HealthNet.BL.Model.PatientVM
{
    public class PatientGetResponseDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }

    }
}
