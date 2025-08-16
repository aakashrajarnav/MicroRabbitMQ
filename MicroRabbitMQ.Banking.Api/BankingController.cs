using MicroRabbitMQ.Banking.Application.Interfaces;
using MicroRabbitMQ.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbitMQ.Banking.Api
{
    [Route("api/[controller]")]
    [ApiController]

    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET: api/Banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            var accounts = _accountService.GetAccounts();
            return Ok(accounts);
        }
    }
}
