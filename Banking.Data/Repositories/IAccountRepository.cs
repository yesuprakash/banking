using Banking.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Data.Repositories
{
    public interface IAccountRepository
    {
        Account AddAccount(Account account);
        IEnumerable<Account> GetAccount();
    }
}
