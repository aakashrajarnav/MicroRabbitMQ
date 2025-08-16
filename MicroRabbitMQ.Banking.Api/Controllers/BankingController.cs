using MicroRabbitMQ.Banking.Application.Interfaces;
using MicroRabbitMQ.Banking.Application.Models;
using MicroRabbitMQ.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbitMQ.Banking.Api.Controllers
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

        // POST: api/Banking/transfer
        [HttpPost]
        public IActionResult Transfer([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok("Transfer successful");
        }
    }
}
