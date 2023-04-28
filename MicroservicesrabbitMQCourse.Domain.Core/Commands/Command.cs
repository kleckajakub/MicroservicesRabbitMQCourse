using MicroservicesrabbitMQCourse.Domain.Core.Events;

namespace MicroservicesrabbitMQCourse.Domain.Core.Commands; 

public abstract class Command : Message {
  protected Command () {
    Timestamp = DateTime.Now;
  }

  public DateTime Timestamp { get; protected set; }
}