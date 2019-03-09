using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Boss: Friend
    {
        public Boss(Mediator mediator, string name)
        {
            base.mediator = mediator;
            this.name = name;
        }

        public void Send(string msg) {
            mediator.Send(this, msg);
        }

        public void Notify(string msg) {
            Console.WriteLine("Boss sees messaga {0}", msg  );
        }
    }
}
