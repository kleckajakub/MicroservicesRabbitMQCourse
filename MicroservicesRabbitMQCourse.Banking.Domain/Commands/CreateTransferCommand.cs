namespace MicroservicesRabbitMQCourse.Banking.Domain.Commands; 

public class CreateTransferCommand : TransferCommand {
  public CreateTransferCommand(int sourceAccount, int targetAccount, decimal amount) {
    SourceAccount = sourceAccount;
    TargetAccount = targetAccount;
    Amount = amount;
  }
}