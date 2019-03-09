using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight.pattern.demo
{
    class SmallRobot: IRobot
    {

        public void Print()
        {
            Console.WriteLine("This is a small robot");
        }
    }
}
