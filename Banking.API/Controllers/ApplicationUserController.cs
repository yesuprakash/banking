using Banking.Service.Services;
using Banking.Model;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IUserManagementService _userManagementService;

        public ApplicationUserController(IUserManagementService userManagementService)
        {
            this._userManagementService = userManagementService;
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult PostApplicationUser(ApplicationUserModel usrModel)
        {
            return Ok(_userManagementService.PostApplicationUser(usrModel));
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginUserModel model)
        {
            var result = _userManagementService.Login(model);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
    }
}