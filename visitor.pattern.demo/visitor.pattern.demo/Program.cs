using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor.pattern.demo
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("***Visitor Pattern Demo***\n");
                IVisitor v = new Visitor();
                MyClass myClass = new MyClass();
                myClass.accept(v);

                Console.ReadLine();
        }
    }
}
