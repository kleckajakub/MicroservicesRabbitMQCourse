using MediatR;
using MicroservicesrabbitMQCourse.Domain.Core.Commands;
using MicroservicesrabbitMQCourse.Domain.Core.Events;

namespace MicroservicesRabbitMQCourse.Infra.Bus; 

public class RabbitMQBus : IEventBus {
  private readonly IMediator mediator;

  public RabbitMQBus(IMediator mediator) {
    this.mediator = mediator;
  }

  public Task SendCommand<T>(T command) where T : Command {
    return mediator.Send(command);
  }

  public void Publish<T>(T @event) where T : Event {
    throw new NotImplementedException();
  }

  public void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T> {
    throw new NotImplementedException();
  }

  public void Unsubscribe<T, TH>() where T : Event where TH : IEventHandler<T> {
    throw new NotImplementedException();
  }
}