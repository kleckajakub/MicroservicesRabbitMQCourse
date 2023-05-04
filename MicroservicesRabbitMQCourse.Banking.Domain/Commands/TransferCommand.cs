using MicroservicesrabbitMQCourse.Domain.Core.Commands;

namespace MicroservicesRabbitMQCourse.Banking.Domain.Commands; 

public abstract class TransferCommand : Command {
  public int SourceAccount { get; protected set; }
  public int TargetAccount { get; protected set; }
  public decimal Amount { get; protected set; }
}