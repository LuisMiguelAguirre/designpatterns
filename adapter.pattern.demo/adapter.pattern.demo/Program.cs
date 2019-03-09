using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.pattern.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorAdapter cal = new CalculatorAdapter();
            Triangle t = new Triangle(20, 10);

            Console.WriteLine("Area is equal to: {0}", cal.getArea(t));
            Console.ReadLine();
        }
    }
}
