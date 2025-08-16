namespace MicroRabbitMQ.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int fromAccount, int toAccount, decimal amount)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            TransferAmount = amount;
        }
    }
}
