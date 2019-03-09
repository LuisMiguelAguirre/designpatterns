using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Mediator Pattern Demo***\n");
            ConcretMediator m = new ConcretMediator();

            Friend1 Amit = new Friend1(m, "Amit");
            Friend2 Sohel = new Friend2(m, "Sohel");
            Boss Raghu = new Boss(m, "Raghu");

            m.SetFriend1= Amit;
            m.setFriend2 = Sohel;
            m.setBoss= Raghu;

            Amit.Send("[Amit here]Good Morrning. Can we discuss the mediator pattern?");
            Sohel.Send("[Sohel here]Good Morning.Yes, we can discuss now.");
            Raghu.Send("\n[Raghu here]:Please get back to work quickly");

            Console.ReadLine();
        }
    }
}
