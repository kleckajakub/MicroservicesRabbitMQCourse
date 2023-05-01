using MicroservicesRabbitMQCourse.Banking.Domain.Models;

namespace MicroservicesRabbitMQCourse.Banking.Domain.Interfaces; 

public interface IAccountRepository {
  IEnumerable<Account> GetAccounts();
}