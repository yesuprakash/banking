
using Banking.Model;
using System;
using System.Threading.Tasks;

namespace Banking.Data.Repositories
{
    public interface IUserManagementRespository
    {
        Task<Object> PostApplicationUser(ApplicationUserModel usrModel);
        Task<Object> Login(LoginUserModel model);
    }
}
