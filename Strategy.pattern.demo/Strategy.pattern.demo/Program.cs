using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using choices;
using contextofchoice;

namespace Strategy.pattern.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Context cxt = new Context();
            IChoice ic=null;
            string input1, input2;
            Console.WriteLine("***Strategy Pattern Demo***");

            try
            {
                for (int i = 1; i <= 2; i++)
                {
                    Console.WriteLine("Enter an integer");
                    input1 = Console.ReadLine();
                    Console.WriteLine("Enter another integer");
                    input2 = Console.ReadLine();
                    Console.WriteLine("Enter your choice 1 or 2");
                    Console.WriteLine("Press 1 for Addition, 2 for Concatenation");
                    string c = Console.ReadLine();

                    if (c == "1")
                    {
                        ic = new FirstChoice();
                    }
                    else
                    {
                        ic = new SecondChoice();
                    }

                    cxt.SetChoice(ic);
                    cxt.ShowChoice(input1, input2);

                }
            }
            finally {
                Console.WriteLine("End of Strategy pattern");
            }

            Console.ReadLine();
        }
    }
}
