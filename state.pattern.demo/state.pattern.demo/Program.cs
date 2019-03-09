using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state.pattern.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Off initialState = new Off();
            TV tv = new TV(initialState);
            tv.pressButton();
            tv.pressButton();

            Console.ReadLine();
        }
    }
}
