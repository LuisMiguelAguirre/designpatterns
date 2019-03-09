using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Friend1: Friend
    {
        public Friend1(Mediator mediator, string name)
        {
            base.mediator = mediator;
            this.name = name;
        }

        public void Send(string msg) {
            mediator.Send(this, msg);
        }

        public void Notify(string msg) {
            Console.WriteLine("Amit gets messaga {0}", msg  );
        }
    }
}
