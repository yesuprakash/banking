using System;
using System.Net.Http;
using Banking.Common;
using BankingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BankingApp.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly IConfiguration _config;
        public UserAccountController(IConfiguration config)
        {
            this._config = config;
        }
       
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {                    
                    client.BaseAddress = new Uri(Common.DecryptString(_config.GetSection("ApplicationUserUrl").Value));
                    var postTask = client.PostAsJsonAsync("Login", model);
                    postTask.Wait();

                    var result = postTask.Result;
                    var ss = result.StatusCode;
                    if (result.StatusCode != System.Net.HttpStatusCode.NotFound)
                    {
                        return RedirectToAction("Get", "Accounts");                        
                    }
                }
                return View();
            }
            return View();
        }
    }
}