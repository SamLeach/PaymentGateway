using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sam.Command.Abstract;
using Sam.Transaction.Abstract;
using Sam.Transaction.Models;
using Sam.Communication.Models;

namespace Sam.Command.Concrete
{
    public class TransactionCommand : Abstract.Command
    {
        private Transaction<Request, Response> transaction;

        public TransactionCommand(Transaction<Request, Response> transaction)
        {
            this.transaction = transaction;
        }

        public override Response Execute()
        {
            throw new NotImplementedException();
        }

        public override Response UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
