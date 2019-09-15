using System;
using System.Collections.Generic;
using System.Text;
using Banking.Data.Repositories;
using Banking.Model;

namespace Banking.Service.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRespository;

        public PaymentService(IPaymentRepository paymentRespository)
        {
            this._paymentRespository = paymentRespository;

        }
        public Payment AddPayment(Payment payment)
        {
            return _paymentRespository.AddPayment(payment);
        }
        public IEnumerable<Payment> GetPayment()
        {
            return _paymentRespository.GetPayment();
        }
    }
}
