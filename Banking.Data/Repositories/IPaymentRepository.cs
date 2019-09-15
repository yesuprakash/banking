using Banking.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Banking.Data.Repositories
{
    public interface IPaymentRepository
    {
        Payment AddPayment(Payment payment);
        IEnumerable<Payment> GetPayment();
    }
}
