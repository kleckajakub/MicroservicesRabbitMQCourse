using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost" };
using (var connection = factory.CreateConnection()) {
  using (var channel = connection.CreateModel()) {
    channel.QueueDeclare("BasicTest", false, false, false, null);

    var consumer = new EventingBasicConsumer(channel);
    consumer.Received += (sender, eventArgs) => {
      var body = eventArgs.Body;
      var message = Encoding.UTF8.GetString(body.ToArray());
      Console.WriteLine($"Received message {message}");
    };

    channel.BasicConsume("BasicTest", true, consumer);

    Console.WriteLine("Press [enter] to exit.");
    Console.ReadLine();
  }
}