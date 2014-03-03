using Sam.Communication.Models;
using Sam.Transaction.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.PaymentGateway.Concrete
{
    public class SamsBankPaymentGateway : Abstract.PaymentGateway
    {
        public SamsBankPaymentGateway(Transaction<Request, Response> transaction)
            : base(transaction)
        {

        }

        public override Response Pay(Request request)
        {
            throw new NotImplementedException();
        }

        public override Response Void(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
