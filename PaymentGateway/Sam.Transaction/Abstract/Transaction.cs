using Sam.Communication.Interfaces;
using Sam.Communication.Models;
using Sam.Transaction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Transaction.Abstract
{
    public abstract class Transaction<TRequest, TResponse> 
        where TRequest : Request
        where TResponse : Response
    {
        protected readonly ICommunicationClient<TRequest, TResponse> communicationClient;

        public Transaction(ICommunicationClient<TRequest, TResponse> communicationClient)
        {
            this.communicationClient = communicationClient; 
        }

        public abstract TResponse Do(TRequest request);
    }
}
