using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer = new ProducerBuilder<Null, string>(config).Build();

Console.WriteLine("Kafka Producer Started");
Console.WriteLine("Type 'exit' to quit");

while (true)
{
    Console.Write("Message: ");
    string? message = Console.ReadLine();

    if (message?.ToLower() == "exit")
        break;

    var result = await producer.ProduceAsync("chat",
        new Message<Null, string> { Value = message });

    Console.WriteLine($"Sent -> {result.Value}");
}