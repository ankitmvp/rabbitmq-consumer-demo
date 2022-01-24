using RabbitMQ.Client.Core.DependencyInjection.MessageHandlers;
using RabbitMQ.Client.Events;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client.Core.DependencyInjection;

namespace Examples.ConsumerHost
{
    public class RabbitMessageHandler : IMessageHandler 
    {
        private readonly ILogger<RabbitMessageHandler> _logger;
        public RabbitMessageHandler(ILogger<RabbitMessageHandler> logger)
        {
            _logger = logger;
        }

        public void Handle(BasicDeliverEventArgs eventArgs, string matchingRoute)
        {
            _logger.LogInformation(eventArgs.GetMessage());
        }
    }
}