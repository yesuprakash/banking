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

namespace BankinApp.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly IConfiguration _config;
        public PaymentsController(IConfiguration config)
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
            var paymentList = new List<PaymentModel>();
            var client = new HttpClient();
            client.BaseAddress = new Uri(Common.DecryptString(_config.GetSection("PaymentUrl").Value));
            HttpResponseMessage response = await client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                paymentList = JsonConvert.DeserializeObject<List<PaymentModel>>(result);
            }
            return View("Index", paymentList);
        }

    }
}