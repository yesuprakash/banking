using Banking.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Service.Services
{
    public interface IAccountService
    {
        Account AddAccount(Account account);
        IEnumerable<Account> GetAccount();
    }
}
