using MicroRabbitMQ.Banking.Data.Context;
using MicroRabbitMQ.Banking.Domain.Interfaces;
using MicroRabbitMQ.Banking.Domain.Models;

namespace MicroRabbitMQ.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _context;

        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}
