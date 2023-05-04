using MicroservicesRabbitMQCourse.Banking.Application.Models;
using MicroservicesRabbitMQCourse.Banking.Domain.Models;

namespace MicroservicesRabbitMQCourse.Banking.Application.Interfaces; 

public interface IAccountService {
  IEnumerable<Account> GetAccounts();
  void Transfer(AccountTransfer accountTransfer);
}