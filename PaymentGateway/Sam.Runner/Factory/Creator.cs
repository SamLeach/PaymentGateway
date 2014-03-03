using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Runner.Factory
{
    public abstract class Creator
    {
        public abstract PaymentGateway.Abstract.PaymentGateway CreatePaymentGateway();
    }
}
