using MediatR;
using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Domain.Core.Commands;
using MicroRabbitMQ.Domain.Core.Events;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace MicroRabbitMQ.Infra.Bus
{
    public sealed class RabbitMQBus : IEventBus
    {
        private readonly IMediator _mediator;
        private readonly Dictionary<string, List<Type>> _handlers;
        private readonly List<Type> _eventTypes;

        public RabbitMQBus(IMediator mediator)
        {
            _mediator = mediator;
            _handlers = new Dictionary<string, List<Type>>();
            _eventTypes = new List<Type>();
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

        public async void Publish<T>(T @event) where T : Event
        {
            var factory = new ConnectionFactory() { HostName = "localhost " };
            using var connection = await factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            var eventName = @event.GetType().Name;
            await channel.QueueDeclareAsync(eventName, false, false, false, null);

            var message = JsonConvert.SerializeObject(@event);
            var body = Encoding.UTF8.GetBytes(message);

            await channel.BasicPublishAsync("", eventName, body);
        }

        public void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>
        {
            throw new NotImplementedException();
        }
    }
}
