using MicroservicesrabbitMQCourse.Domain.Core.Commands;

namespace MicroservicesrabbitMQCourse.Domain.Core.Events; 

public interface IEventBus {
  Task SendCommand<T> (T command) where T : Command;
  
  void Publish<T> (T @event) where T : Event;

  void Subscribe<T, TH>()
    where T : Event
    where TH : IEventHandler<T>;
  
  void Unsubscribe<T, TH>()
    where T : Event
    where TH : IEventHandler<T>;
}