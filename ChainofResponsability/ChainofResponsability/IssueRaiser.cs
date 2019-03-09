using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsability
{
    class IssueRaiser
    {
        public IReceiver setFirstReceiver;
        public IssueRaiser(IReceiver firstReceiver)
        {
            this.setFirstReceiver = firstReceiver;
        }

        public void RaiseMessage(Message msg){
            if (setFirstReceiver != null) {
                setFirstReceiver.ProcessMessage(msg);
            }
        }
    }
}
