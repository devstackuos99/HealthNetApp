
using HealthNet.BL.Model.OperationVM;
using HealthNet.BL.Services.IServices;
using HealthNet.DAL.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace HealthNet.BL.Services
{
    public class OperationService : IOperationService
    {
        private readonly IOperationRepository _operationRepository;
        private readonly IAppointmentRepository _appointmentRepository;

        public OperationService(IOperationRepository operationRepository, IAppointmentRepository appointmentRepository)
        {
            _operationRepository = operationRepository;
            _appointmentRepository = appointmentRepository;
        }

        public async Task<List<OperationGetResponseDto>> Get()
        {
            var operation = await _operationRepository.Get()
                .ToListAsync();
            return operation.Select(o => new OperationGetResponseDto
            {
                Id = o.Id,
                OperationDate = o.OperationDate,
                SurgeonName = o.SurgeonName,
                OperationType = o.OperationType,
                Cost = o.Cost,
                AppointmentId = o.AppointmentId,
            }).ToList();
        }
    }
}
