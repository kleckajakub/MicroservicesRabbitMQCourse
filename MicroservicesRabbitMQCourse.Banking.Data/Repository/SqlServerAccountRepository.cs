using MicroservicesRabbitMQCourse.Banking.Data.Context;
using MicroservicesRabbitMQCourse.Banking.Domain.Interfaces;
using MicroservicesRabbitMQCourse.Banking.Domain.Models;

namespace MicroservicesRabbitMQCourse.Banking.Data.Repository; 

public class SqlServerAccountRepository : IAccountRepository {
  private readonly  BankingDbContext dbContext;

  public SqlServerAccountRepository(BankingDbContext dbContext) {
    this.dbContext = dbContext;
  }

  public IEnumerable<Account> GetAccounts() {
    return dbContext.Accounts;
  }
}