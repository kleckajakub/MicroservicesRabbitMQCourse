using MicroservicesRabbitMQCourse.Banking.Application.Interfaces;
using MicroservicesRabbitMQCourse.Banking.Application.Models;
using MicroservicesRabbitMQCourse.Banking.Domain.Commands;
using MicroservicesRabbitMQCourse.Banking.Domain.Interfaces;
using MicroservicesRabbitMQCourse.Banking.Domain.Models;
using MicroservicesrabbitMQCourse.Domain.Core.Events;

namespace MicroservicesRabbitMQCourse.Banking.Application.Services; 

public class AccountService : IAccountService {
  private readonly IAccountRepository accountRepository;
  private readonly IEventBus eventBus;

  public AccountService(IAccountRepository accountRepository, IEventBus eventBus) {
    this.accountRepository = accountRepository;
    this.eventBus = eventBus;
  }

  public IEnumerable<Account> GetAccounts() {
    return accountRepository.GetAccounts();
  }

  public void Transfer(AccountTransfer accountTransfer) {
    var createTransferCommand = new CreateTransferCommand(
      accountTransfer.SourceAccount,
      accountTransfer.TargetAccount,
      accountTransfer.Amount
    );

    eventBus.SendCommand(createTransferCommand);
  }
}