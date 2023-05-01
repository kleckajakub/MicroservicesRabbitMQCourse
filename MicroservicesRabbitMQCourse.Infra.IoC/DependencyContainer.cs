using MicroservicesrabbitMQCourse.Domain.Core.Events;
using MicroservicesRabbitMQCourse.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroservicesRabbitMQCourse.Infra.IoC;

public class DependencyContainer {
  public static void RegisterServices(IServiceCollection services) {
    // Domain Bus
    services.AddTransient<IEventBus, RabbitMQBus>();
  }
}