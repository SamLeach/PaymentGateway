using Funq;
using Sam.PaymentGateway.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Runner.Factory
{
    public class PaymentGatewayCreator : Creator
    {
        public override PaymentGateway.Abstract.PaymentGateway CreatePaymentGateway()
        {
            Container container = new Container();
            container.Register<PaymentGateway.Abstract.PaymentGateway>(c => new SamsBankPaymentGateway());

            PaymentGateway.Abstract.PaymentGateway paymentGateway = container.Resolve<SamsBankPaymentGateway>();

            paymentGateway.Name = "Sam's Bank";

            return paymentGateway;
        }
    }
}
