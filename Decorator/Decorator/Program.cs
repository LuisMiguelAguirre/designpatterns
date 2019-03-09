using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Decorator pattern Demo***");
            ConcreteComponent cc = new ConcreteComponent();
            ConcreteDecoratorEx_1 cd_1 = new ConcreteDecoratorEx_1();
            cd_1.SetTheComponent(cc);
            cd_1.doJob();

            ConcreteDecoratorEx_2 cd_2 = new ConcreteDecoratorEx_2();
            cd_2.SetTheComponent(cd_1);
            cd_2.doJob();

            Console.ReadLine();

        }
    }
}
