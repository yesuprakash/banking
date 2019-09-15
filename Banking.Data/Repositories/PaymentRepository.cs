using Banking.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Banking.Data.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DatabaseContext _databaseContext;

        public PaymentRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public Payment AddPayment(Payment payment)
        {
            _databaseContext.Set<Payment>().Add(payment);
            _databaseContext.Entry(payment.Account).State = EntityState.Unchanged;
            _databaseContext.SaveChanges();
            return payment;
        }

        public IEnumerable<Payment> GetPayment()
        {
            return _databaseContext.Payments;
        }
    }
}
