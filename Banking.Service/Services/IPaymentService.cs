using Banking.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Service.Services
{
    public interface IPaymentService
    {
        Payment AddPayment(Payment payment);
        IEnumerable<Payment> GetPayment();
    }
}
