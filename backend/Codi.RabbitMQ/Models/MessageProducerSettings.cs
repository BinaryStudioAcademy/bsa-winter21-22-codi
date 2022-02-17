using RabbitMQ.Client;

namespace Codi.RabbitMQ.Models;

public class MessageProducerSettings
{
    public IModel Channel { get; set; }
    public PublicationAddress PublicationAddress { get; set; }
}