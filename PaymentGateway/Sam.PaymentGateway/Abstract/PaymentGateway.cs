using Sam.Communication.Models;
using Sam.Transaction.Abstract;
using Sam.Command.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sam.Command.Concrete;

namespace Sam.PaymentGateway.Abstract
{
    public abstract class PaymentGateway
    {
        private readonly Transaction<Request, Response> transaction;
        private readonly List<Sam.Command.Abstract.Command> voids;

        public PaymentGateway(Transaction<Request, Response> transaction)
        {
            this.transaction = transaction;
            this.voids = new List<Command.Abstract.Command>();
        }

        public virtual Response Pay(Request request) 
        {
            Sam.Command.Abstract.Command command = new TransactionCommand(transaction);
            Response response = command.Execute();

            voids.Add(command);

            return response;
        }

        public virtual Response Void(Request request) 
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }
}
