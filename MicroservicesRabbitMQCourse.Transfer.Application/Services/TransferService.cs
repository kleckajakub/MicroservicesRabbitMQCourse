using MicroservicesrabbitMQCourse.Domain.Core.Events;
using MicroservicesRabbitMQCourse.Transfer.Application.Interfaces;
using MicroservicesRabbitMQCourse.Transfer.Domain.Models;

namespace MicroservicesRabbitMQCourse.Transfer.Application.Services;

public class TransferService : ITransferService {
  private readonly IEventBus eventBus;
  private ITransferRepository transferRepo;
  
  public TransferService(IEventBus eventBus, ITransferRepository transferRepo) {
    this.eventBus = eventBus;
    this.transferRepo = transferRepo;
  }
  
  public IEnumerable<TransferLog> GetTransferLogs() {
    return transferRepo.GetTransferLogs();
  }
}