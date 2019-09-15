using System.Threading.Tasks;
using Banking.Model;
using Microsoft.AspNetCore.Identity;

namespace Banking.Data.Repositories
{
    public class UserManagementRespository : IUserManagementRespository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public UserManagementRespository(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public async Task<object> Login(LoginUserModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
            if (result.Succeeded)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public async Task<object> PostApplicationUser(ApplicationUserModel usrModel)
        {
            var appUser = new UserLogin()
            {
                UserName = usrModel.UserName
            };
            var result = await _userManager.CreateAsync(appUser, usrModel.Password);
            return result;
        }
    }
}
