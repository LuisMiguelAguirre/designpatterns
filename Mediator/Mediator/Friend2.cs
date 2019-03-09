using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Friend2: Friend
    {
        public Friend2(Mediator mediator, string name)
        {
            base.mediator = mediator;
            this.name = name;
        }

        public void Send(string msg) {
            mediator.Send(this, msg);
        }

        public void Notify(string msg) {
            Console.WriteLine("Sohel gets messaga {0}", msg  );
        }
    }
}
