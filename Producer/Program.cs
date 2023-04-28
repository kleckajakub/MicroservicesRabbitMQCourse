using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory {HostName = "localhost"};
using (var connection = factory.CreateConnection()) {
  using (var channel = connection.CreateModel()) {
    channel.QueueDeclare("BasicTest", false, false, false, null);

    var message = "Hello World!";
    var body = Encoding.UTF8.GetBytes(message);

    channel.BasicPublish("", "BasicTest", null, body);
    Console.WriteLine(" [x] Sent {0}", message);
  }
}

Console.WriteLine("Press [enter] to exit.");
Console.ReadLine();
