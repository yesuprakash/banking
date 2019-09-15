using Banking.Model;
using System;
using System.Threading.Tasks;

namespace Banking.Service.Services
{
    public interface IUserManagementService
    {
        Task<Object> PostApplicationUser(ApplicationUserModel usrModel);
        Task<Object> Login(LoginUserModel model);
    }
}
