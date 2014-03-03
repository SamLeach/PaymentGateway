using Sam.Communication.Interfaces;
using Sam.Communication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Communication.Concrete
{
    public class Client : ICommunicationClient<Request, Response>
    {
        public Response Communicate(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
