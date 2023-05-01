using MicroservicesRabbitMQCourse.Banking.Application.Interfaces;
using MicroservicesRabbitMQCourse.Banking.Domain.Interfaces;
using MicroservicesRabbitMQCourse.Banking.Domain.Models;

namespace MicroservicesRabbitMQCourse.Banking.Application.Services; 

public class AccountService : IAccountService {
  private readonly IAccountRepository accountRepository;

  public AccountService(IAccountRepository accountRepository) {
    this.accountRepository = accountRepository;
  }

  public IEnumerable<Account> GetAccounts() {
    return accountRepository.GetAccounts();
  }
}