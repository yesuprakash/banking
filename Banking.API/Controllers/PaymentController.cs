using Banking.Model;
using Banking.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Banking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            this._paymentService = paymentService;
        }

        [HttpPost]
        public Payment Post([FromBody] Payment payment)
        {
            return _paymentService.AddPayment(payment);
        }

        [HttpGet]
        public IEnumerable<Payment> Get()
        {
            return _paymentService.GetPayment();
        }
    }
}