using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Friend
    {
        internal void Notify(string msg)
        {
            throw new NotImplementedException();
        }
        protected Mediator mediator;
        public string name { get; set; }

        public Friend(Mediator _mediator)
        {
            mediator = _mediator;
        }

        public Friend()
        {

        }
    }
}
