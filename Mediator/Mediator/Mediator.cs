using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class Mediator
    {
        public abstract void Send(Friend frd, string msg);
    }
}
