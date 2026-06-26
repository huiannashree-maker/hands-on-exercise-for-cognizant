// Minimal example of a Kafka Consumer
var config = new ConsumerConfig {
    BootstrapServers = "localhost:9092",
    GroupId = "chat-group",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using (var c = new ConsumerBuilder<Ignore, string>(config).Build()) {
    c.Subscribe("chat-message");
    while (true) {
        var cr = c.Consume();
        Console.WriteLine($"Consumed message '{cr.Value}' at: '{cr.TopicPartitionOffset}'.");
    }
}