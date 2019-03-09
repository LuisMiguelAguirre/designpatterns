using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsability
{
    class FaxErrorHandled: IReceiver
    {

        private IReceiver _nextReceiver;
        public FaxErrorHandled(IReceiver nextReceiver)
        {
            _nextReceiver = nextReceiver;
        }

        public bool ProcessMessage(Message msg)
        {
            if (msg.Text.Contains("Fax"))
            {
                Console.WriteLine("FaxErrorHandler processed " + msg.Priority +
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
