using MicroRabbitMQ.Domain.Core.Commands;

namespace MicroRabbitMQ.Banking.Domain.Commands
{
    public abstract class TransferCommand : Command
    {
        public int FromAccount { get; protected set; }
        public int ToAccount { get; protected set; }
        public decimal TransferAmount { get; protected set; }
    }
}
