using MicroservicesRabbitMQCourse.Transfer.Domain.Models;

namespace MicroservicesRabbitMQCourse.Transfer.Application.Interfaces; 

public interface ITransferService {
  IEnumerable<TransferLog> GetTransferLogs();
}