using Funq;
using Sam.PaymentGateway.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sam.PaymentGateway.Abstract;
using Sam.Runner.Factory;

namespace Sam.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new PaymentGatewayCreator();
            PaymentGateway.Abstract.PaymentGateway paymentGateway = creator.CreatePaymentGateway();
        }
    }
}
