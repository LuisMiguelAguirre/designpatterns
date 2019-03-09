using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsability
{

    enum MessagePriority { 
        Normal, 
        High
    }

    class Message
    {
        public string Text;
        public MessagePriority Priority;

        public Message(string msg, MessagePriority p)
        {
            Text = msg;
            this.Priority = p;
        }
    }
}
