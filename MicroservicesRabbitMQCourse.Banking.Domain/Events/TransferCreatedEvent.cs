using MicroservicesrabbitMQCourse.Domain.Core.Events;

namespace MicroservicesRabbitMQCourse.Banking.Domain.Events; 

public class TransferCreatedEvent : Event {
  public TransferCreatedEvent(int sourceAccount, int targetAccount, decimal amount) {
    SourceAccount = sourceAccount;
    TargetAccount = targetAccount;
    Amount = amount;
  }

  public int SourceAccount { get; private set; }
  public int TargetAccount { get; private set; }
  public decimal Amount { get; private set; }
}