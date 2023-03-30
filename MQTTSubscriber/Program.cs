using MQTTnet.Client;
using MQTTnet;
using MQTTnet.Client.Options;
using System.Text;

class Subscriber
{
    static async Task Main(string[] args)
    {
        var mqttFactory = new MqttFactory();
        var client = mqttFactory.CreateMqttClient();
        var options = new MqttClientOptionsBuilder()
            .WithClientId(Guid.NewGuid().ToString())
            .WithTcpServer("test.mosquitto.org", 1883)
            .WithCleanSession()
            .Build();
        client.UseConnectedHandler(async e =>
        {
            Console.WriteLine("Connected to ther broker succesfully");
            var topicFilter = new MqttTopicFilterBuilder()
            .WithTopic("First MQTT project")
            .Build();
            await client.SubscribeAsync(topicFilter);
        });
        client.UseDisconnectedHandler(e =>
        {
            Console.WriteLine("Disconnected from the broker succesfully");
        });

        client.UseApplicationMessageReceivedHandler(e =>
        {
            Console.WriteLine($"Received Message = {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
        });
        await client.ConnectAsync(options);

        Console.ReadLine();

        await client.DisconnectAsync();
    }
}