using System;
using System.Collections.Generic;
using System.Text;
using Banking.Data.Repositories;
using Banking.Model;

namespace Banking.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _paymentRespository;

        public AccountService(IAccountRepository paymentRespository)
        {
            this._paymentRespository = paymentRespository;
        }
        public Account AddAccount(Account account)
        {
            return _paymentRespository.AddAccount(account);
        }
        public IEnumerable<Account> GetAccount()
        {
            return _paymentRespository.GetAccount();
        }
    }
}
