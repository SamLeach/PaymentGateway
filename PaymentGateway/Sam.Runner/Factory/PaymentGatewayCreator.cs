using Funq;
using Sam.Communication.Concrete;
using Sam.Communication.Interfaces;
using Sam.Communication.Models;
using Sam.PaymentGateway.Concrete;
using Sam.Transaction.Abstract;
using Sam.Transaction.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Runner.Factory
{
    public class PaymentGatewayCreator : Creator
    {
        private readonly Container container;

        public PaymentGatewayCreator()
        {
            container = new Container();
        }

        public override PaymentGateway.Abstract.PaymentGateway CreatePaymentGateway()
        {
            RegisterCommunicationClient();
            RegisterTransaction();
            RegisterPaymentGateway();

            PaymentGateway.Abstract.PaymentGateway paymentGateway = ResolvePaymentGateway();

            paymentGateway.Name = "Sam's Bank";

            return paymentGateway;
        }

        private PaymentGateway.Abstract.PaymentGateway ResolvePaymentGateway()
        {
            PaymentGateway.Abstract.PaymentGateway paymentGateway = container.Resolve<SamsBankPaymentGateway>();
            return paymentGateway;
        }

        private void RegisterPaymentGateway()
        {
            container.Register<PaymentGateway.Abstract.PaymentGateway>(c => new SamsBankPaymentGateway(c.Resolve<Transaction<Request, Response>>()));
        }

        private void RegisterTransaction()
        {
            container.Register<Transaction<Request, Response>>(c => new SamsBankTransaction(c.Resolve<ICommunicationClient<Request, Response>>()));
        }

        private void RegisterCommunicationClient()
        {
            container.Register<ICommunicationClient<Request, Response>>(c => new Client());
        }
    }
}
