using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsability
{
    class EmailErrorHandled: IReceiver
    {
         private IReceiver _nextReceiver;
        public EmailErrorHandled(IReceiver nextReceiver)
        {
            _nextReceiver = nextReceiver;
        }

        public bool ProcessMessage(Message msg)
        {
            if (msg.Text.Contains("Email"))
            {
                Console.WriteLine("EmailErrorHandler processed " + msg.Priority +
                        "priority issue: " + msg.Text);
                return true;

            }
            else {
                if (_nextReceiver != null) {
                    _nextReceiver.ProcessMessage(msg);
                }
            }
            return false;
        }
    }
}
