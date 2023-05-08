using MicroservicesRabbitMQCourse.Transfer.Domain.Models;

namespace MicroservicesRabbitMQCourse.Transfer.Application.Interfaces; 

public interface ITransferRepository {
  IEnumerable<TransferLog> GetTransferLogs();
}