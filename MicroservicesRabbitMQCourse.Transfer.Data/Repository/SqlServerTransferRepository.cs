using MicroservicesRabbitMQCourse.Transfer.Application.Interfaces;
using MicroservicesRabbitMQCourse.Transfer.Data.Context;
using MicroservicesRabbitMQCourse.Transfer.Domain.Models;

namespace MicroservicesRabbitMQCourse.Transfer.Data.Repository;

public class SqlServerTransferRepository : ITransferRepository {
  private readonly TransferDbContext dbContext;

  public SqlServerTransferRepository(TransferDbContext dbContext) {
    this.dbContext = dbContext;
  }

  public IEnumerable<TransferLog> GetTransferLogs() {
    return dbContext.TransferLogs;
  }
}