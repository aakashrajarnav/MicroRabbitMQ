using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Transfer.Domain.Events;
using MicroRabbitMQ.Transfer.Domain.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Models;

namespace MicroRabbitMQ.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public async Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog()
            {
                FromAccount = @event.FromAccount,
                ToAccount = @event.ToAccount,
                TransferAmount = @event.TransferAmount
            });

            await Task.CompletedTask;
        }
    }
}
