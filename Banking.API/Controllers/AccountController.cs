using Banking.Model;
using Banking.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Banking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        [HttpPost]
        public Account Post([FromBody] Account account)
        {
            return _accountService.AddAccount(account);
        }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _accountService.GetAccount();
        }

    }
}