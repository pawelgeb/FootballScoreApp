using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System.Reflection.Metadata.Ecma335;

class Publisher
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
        client.UseConnectedHandler(e =>
        {
            Console.WriteLine("Connected to the broker succesfully");
        });
        client.UseDisconnectedHandler(e =>
        {
            Console.WriteLine( "Disconnected from the broker succesfully");
        });
        await client.ConnectAsync(options);

        Console.WriteLine("Plese press a key to publish the message");
        Console.ReadLine();

        await PublishMessageAsync(client);

        await client.DisconnectAsync();
    }

    private static string PutMessagePayload(string message)
    {
        return message;
    }

    private static async Task PublishMessageAsync(IMqttClient client)
    {
        string messagePayload = "abc";
        var message = new MqttApplicationMessageBuilder()
            .WithTopic("First MQTT project")
            .WithPayload(messagePayload)
            .WithAtLeastOnceQoS()
            .Build();
        if (client.IsConnected)
        {
            await client.PublishAsync(message);
        }       
    }
}
