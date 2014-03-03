using Sam.Communication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Communication.Interfaces
{
    public interface ICommunicationClient<TRequest, TResponse>
        where TRequest : Request
        where TResponse : Response
    {
        TResponse Communicate(TRequest request);
    }
}
