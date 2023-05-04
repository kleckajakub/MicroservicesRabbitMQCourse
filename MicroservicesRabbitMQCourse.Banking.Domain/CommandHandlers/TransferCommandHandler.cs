using MediatR;
using MicroservicesRabbitMQCourse.Banking.Domain.Commands;
using MicroservicesRabbitMQCourse.Banking.Domain.Events;
using MicroservicesrabbitMQCourse.Domain.Core.Events;

namespace MicroservicesRabbitMQCourse.Banking.Domain.CommandHandlers; 

public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool> {
  private readonly IEventBus eventBus;

  public TransferCommandHandler(IEventBus eventBus) {
    this.eventBus = eventBus;
  }

  public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken) {
    eventBus.Publish(new TransferCreatedEvent(request.SourceAccount, request.TargetAccount, request.Amount));
    return Task.FromResult(true);
  }
}