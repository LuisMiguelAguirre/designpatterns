using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter.pattern.demo
{
    class Program
    {
        public Context clientContext = null;
        public IExpression exp = null;

        public Program(Context c)
        {
            clientContext = c;
        }

        public void interpret(string str) {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter your choice 1 o 2");
                string key = Console.ReadLine();

                if (key.Equals("1"))
                {
                    exp = new IntToWords(str);
                    exp.interpret(clientContext);
                }
                else {
                    exp = new StringToBinaryExp(str);
                    exp.interpret(clientContext);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Interpreter Pattern Demo ***");
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            Context context = new Context(number);
            Program client = new Program(context);
            client.interpret(number);

            Console.ReadLine();
        }
    }
}
