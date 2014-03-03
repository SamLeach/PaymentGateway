using Sam.Communication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Command.Abstract
{
    public abstract class Command
    {
        public abstract Response Execute();
        public abstract Response UnExecute();
    }
}
