using System.Collections.Generic;
using Banking.Model;

namespace Banking.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DatabaseContext _databaseContext;

        public AccountRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }
        public Account AddAccount(Account account)
        {
            _databaseContext.Add(account);
            _databaseContext.SaveChanges();
            return account;
        }

        public IEnumerable<Account> GetAccount()
        {
           return _databaseContext.Accounts;
        }
    }
}
