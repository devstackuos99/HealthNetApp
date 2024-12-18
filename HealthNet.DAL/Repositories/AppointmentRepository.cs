
using HealthNet.DAL.Entities;
using HealthNet.DAL.Repositories.Abstraction;

namespace HealthNet.DAL.Repositories
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(HealthNetContext context) : base(context)
        {
        }
    }
}
