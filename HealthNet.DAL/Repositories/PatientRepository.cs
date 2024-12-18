using HealthNet.DAL.Entities;
using HealthNet.DAL.Repositories.Abstraction;

namespace HealthNet.DAL.Repositories
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(HealthNetContext context) : base(context)
        {
        }
    }
}
