using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Banking.Common;
using BankingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace BankingApp.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IConfiguration _config;
        public AccountsController(IConfiguration config)
        {
            this._config = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var accountList = new List<AccountModel>();            
            var client = new HttpClient();            
            client.BaseAddress = new Uri(Common.DecryptString(_config.GetSection("AccountsUrl").Value));
            HttpResponseMessage response = await client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                accountList = JsonConvert.DeserializeObject<List<AccountModel>>(result);
            }
            return View("Index", accountList);
        }


    }
}