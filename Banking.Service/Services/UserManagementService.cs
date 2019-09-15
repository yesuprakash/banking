using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Banking.Data.Repositories;
using Banking.Model;

namespace Banking.Service.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUserManagementRespository _userManagementRespository;

        public UserManagementService(IUserManagementRespository userManagementRespository)
        {
            this._userManagementRespository = userManagementRespository;
        }
        Task<object> IUserManagementService.Login(LoginUserModel model)
        {
            return _userManagementRespository.Login(model);
        }

        Task<object> IUserManagementService.PostApplicationUser(ApplicationUserModel model)
        {
            return _userManagementRespository.PostApplicationUser(model);
        }
    }
}
