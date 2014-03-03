using Sam.Communication.Interfaces;
using Sam.Communication.Models;
using Sam.Transaction.Abstract;
using Sam.Transaction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Transaction.Concrete
{
    public class SamsBankTransaction : Transaction<Request, Response>
    {
        public SamsBankTransaction(ICommunicationClient<Request, Response> communicationClient)
            : base(communicationClient) { }

        public override Response Do(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
