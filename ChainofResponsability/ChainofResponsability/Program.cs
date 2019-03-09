using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsability
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Chain of Responsibility Pattern Demo***\n");
                //Making the chain first: IssueRaiser->FaxErrorhandler->EmailErrorHandler
                IReceiver faxHandler, emailHandler;
                //end of chain
                emailHandler = new EmailErrorHandled(null);
                //fax handler is before email
                faxHandler = new FaxErrorHandled(emailHandler);

                //starting point: raiser will raise issues and set the first handler
                IssueRaiser raiser = new IssueRaiser (faxHandler);

                Message m1 = new Message("Fax is reaching late to the destination",
                MessagePriority.Normal);
                Message m2 = new Message("Email is not going", MessagePriority.High);
                Message m3 = new Message("In Email, BCC field is disabled occasionally",
                MessagePriority.Normal);
                Message m4 = new Message("Fax is not reaching destination",
                MessagePriority.High);

                raiser.RaiseMessage(m1);
                raiser.RaiseMessage(m2);
                raiser.RaiseMessage(m3);
                raiser.RaiseMessage(m4);

                Console.ReadLine();
        }
    }
}
