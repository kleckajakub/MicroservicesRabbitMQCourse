using MediatR;
using MicroservicesRabbitMQCourse.Banking.Application.Interfaces;
using MicroservicesRabbitMQCourse.Banking.Application.Services;
using MicroservicesRabbitMQCourse.Banking.Data.Context;
using MicroservicesRabbitMQCourse.Banking.Data.Repository;
using MicroservicesRabbitMQCourse.Banking.Domain.CommandHandlers;
using MicroservicesRabbitMQCourse.Banking.Domain.Commands;
using MicroservicesRabbitMQCourse.Banking.Domain.Interfaces;
using MicroservicesrabbitMQCourse.Domain.Core.Events;
using MicroservicesRabbitMQCourse.Infra.Bus;
using MicroservicesRabbitMQCourse.Transfer.Application.Interfaces;
using MicroservicesRabbitMQCourse.Transfer.Application.Services;
using MicroservicesRabbitMQCourse.Transfer.Data.Context;
using MicroservicesRabbitMQCourse.Transfer.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace MicroservicesRabbitMQCourse.Infra.IoC;

public static class DependencyContainer {
  public static void RegisterServices(IServiceCollection services) {
    // Domain Bus
    services.AddTransient<IEventBus, RabbitMQBus>();

    //Domain Events
    services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

    // Application Services
    services.AddTransient<IAccountService, AccountService>();
    services.AddTransient<ITransferService, TransferService>();

    // Data
    services.AddTransient<IAccountRepository, SqlServerAccountRepository>();
    services.AddTransient<ITransferRepository, SqlServerTransferRepository>();
    services.AddTransient<BankingDbContext>();
    services.AddTransient<TransferDbContext>();
  }
}