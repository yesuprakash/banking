using Banking.Data;
using Banking.Data.Repositories;
using Banking.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Banking.Config
{
    public class DependencyResolver
    {
        public static void RegisterDependency(IServiceCollection _ServiceCollection)
        {
            //Adding DI
            _ServiceCollection.AddTransient<IUserManagementRespository, UserManagementRespository>();
            _ServiceCollection.AddTransient<IUserManagementService, UserManagementService>();
            _ServiceCollection.AddTransient<IAccountRepository, AccountRepository>();
            _ServiceCollection.AddTransient<IAccountService, AccountService>();
            _ServiceCollection.AddTransient<IPaymentRepository, PaymentRepository>();
            _ServiceCollection.AddTransient<IPaymentService, PaymentService>();
        }
    }
}
